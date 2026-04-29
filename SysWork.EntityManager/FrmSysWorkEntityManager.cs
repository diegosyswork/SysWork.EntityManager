using FluentValidation;
using FluentValidation.Results;
using Humanizer;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SysWork.Data.Common.Interfaces.CodeWriter;
using SysWork.Data.Common.ValueObjects;
using SysWork.Data.GenericDataManager.CodeWriter;
using SysWork.Data.GenericDataManager.CodeWriter.Properties;
using SysWork.Data.GenericRepository.CodeWriter;
using SysWork.Data.GenericViewManager.CodeWriter;
using SysWork.Data.Utilities;
using SysWork.EntityManager.Data;
using SysWork.Forms.Utilities;
using SysWork.MetroControls.MetroToolbars;
using SysWork.Data.Common.Metro.DbConnector;

namespace SysWork.EntityManager
{
    //TODO: 20220723 Comparar archivos y preguntar solo sobreescribir los que tengan algun cambio.
    //TODO: Reemplazar ListView por DataGridView.
    //TODO: Permitir cambiar los nombres del repositorio y de la public property.

    public partial class FrmEntityManager : MetroForm
    {
        EFormEditState _formEditState;

        bool _loadingData = false;

        readonly Db _db;
        readonly DisplaySettingsManager _displaySettingsManager;
        readonly ListViewColumnSorter _listViewColumnSorter;
        readonly ProfileValidator _profileValidator;

        Profile _currentProfile = null;

        public FrmEntityManager()
        {
            InitializeComponent();

            _db = new Db();
            _listViewColumnSorter = new ListViewColumnSorter();
            _profileValidator = new ProfileValidator();
            _currentProfile = new Profile();

            var configTheme = (DisplaySettingsTheme)long.Parse(_db.GetConfiguration("Theme", ((long)DisplaySettingsTheme.Light).ToString()));
            var configStyle = (DisplaySettingsStyle)long.Parse(_db.GetConfiguration("Style", ((long)(DisplaySettingsStyle.Blue)).ToString()));

            _displaySettingsManager = new DisplaySettingsManager(this, MetroStyleManager1)
            {
                MetroTheme = configTheme,
                MetroStyle = configStyle,
                MetroStyleExtender = metroStyleExtender1,
                MetroRendererManager = MetroRendererManager1
            };

            _displaySettingsManager.MetroToolbarsCRUDSmall.Add(this.MetroToolbarCRUDSmall1);
            _displaySettingsManager.MetroToolbarsDisplaySettings.Add(this.metroToolbarDisplaySettings1);


            _displaySettingsManager.Apply();
        }

        void FrmEntityManager_Load(object sender, EventArgs e)
        {
            CmbDataBaseEngine.DataSource = Enum.GetValues(typeof(EDatabaseEngine));

            ControlEditState(EFormEditState.Unconnected);

            _loadingData = true;
            LoadProfiles();
            _loadingData = false;
        }

        void FrmEntityManager_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            _loadingData = true;
            CmbProfiles.Focus();
            this.Activate();
            _loadingData = false;
        }

        void ControlEditState(EFormEditState editState)
        {
            this._formEditState = editState;

            BtnConnect.Enabled = (this._formEditState == EFormEditState.Unconnected);
            BtnUnconnect.Enabled = !BtnConnect.Enabled;

            CmbDataBaseEngine.Enabled = BtnConnect.Enabled;
            TxtConnectionString.Enabled = BtnConnect.Enabled;

            GrpDetails.Enabled = !BtnConnect.Enabled;

            MetroToolbarCRUDSmall1.SaveEnabled = editState == EFormEditState.Connected;
            MetroToolbarCRUDSmall1.DeleteEnabled = editState == EFormEditState.Unconnected;
            MetroToolbarCRUDSmall1.RefreshEnabled = editState == EFormEditState.Unconnected;
        }

        private void LstObjectsItemCheched(ItemCheckedEventArgs e)
        {
            SetSubtextItem(e.Item);

            lblObChecked.Text = "";
            if (LstObjects.CheckedItems.Count > 0)
            {
                lblObChecked.Text = $"Objetos Seleccionados: {LstObjects.CheckedItems.Count}.";
                lblObChecked.Refresh();
            }
        }

        void FillObjects()
        {
            if (_loadingData)
                return;

            EDatabaseEngine databaseEngine = (EDatabaseEngine)CmbDataBaseEngine.SelectedValue;
            var dbUtil = new DbUtil(databaseEngine, TxtConnectionString.Text);
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Maximum = 0;

            LstObjects.ListViewItemSorter = null;
            bool exludeSys = ChkExcludeSysObjects.Checked;
            if (ChkTables.Checked)
            {
                if (LstObjects.Items.Cast<ListViewItem>().Where(l => l.Text.ToLower() == "table").ToList().Count == 0)
                {
                    var tableList = dbUtil.GetTables();
                    MetroProgressbarObj.Maximum += tableList.Count;
                    foreach (var item in tableList)
                    {
                        if (!(exludeSys && (item.ToLower().StartsWith("sys") || item.ToLower().StartsWith("logdb"))))
                        {
                            LstObjects.Items.Add(CreateListViewItem("Table", item));
                            MetroProgressbarObj.Value++;
                        }
                    }
                }
            }
            else
            {
                LstObjects.Items.Cast<ListViewItem>().ToList().ForEach((l) =>
                {
                    if (l.Text.ToLower() == "table")
                        l.Remove();
                });
            }

            if (ChkViews.Checked)
            {
                if (LstObjects.Items.Cast<ListViewItem>().Where(l => l.Text.ToLower() == "view").ToList().Count == 0)
                {
                    var viewList = dbUtil.GetViews();
                    MetroProgressbarObj.Maximum += viewList.Count;
                    foreach (var item in viewList)
                    {
                        if (!(exludeSys && (item.ToLower().StartsWith("sys") || item.ToLower().StartsWith("logdb"))))
                        {
                            LstObjects.Items.Add(CreateListViewItem("view", item));
                            MetroProgressbarObj.Value++;
                        }
                    }
                }
            }
            else
            {
                LstObjects.Items.Cast<ListViewItem>().ToList().ForEach((l) =>
                {
                    if (l.Text.ToLower() == "view")
                        l.Remove();
                });
            }

            _listViewColumnSorter.SortColumn = 0;
            LstObjects.ListViewItemSorter = _listViewColumnSorter;
            MetroProgressbarObj.Visible = false;
        }

        ListViewItem CreateListViewItem(string objectType, string objectName)
        {
            return new ListViewItem(new string[] { objectType, objectName, "", "" });
        }

        private void CmbDataBaseEngine_Validating(object sender, CancelEventArgs e)
        {
            if (_loadingData) return;

            ValidateCmbDatabaseEngine();
        }

        bool ValidateCmbDatabaseEngine()
        {
            _currentProfile.DatabaseEngine = CmbDataBaseEngine.Text;
            errorProvider1.SetError(CmbDataBaseEngine, "");
            ValidationResult result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("DatabaseEngine"));
            if (!result.IsValid)
                errorProvider1.SetError(CmbDataBaseEngine, ErroresValidacion(result.Errors));

            return result.IsValid;
        }

        void CmbDataBaseEngine_SelectedValueChanged(object sender, EventArgs e)
        {
            TxtConnectionString.WaterMark = "Ingresa aqui tu cadena de conexion";
        }

        void CmbProfiles_Validating(object sender, CancelEventArgs e)
        {
            MetroToolbarCRUDSmall1.DeleteEnabled = (CmbProfiles.SelectedItem != null);
        }

        void TxtConnectionString_Validating(object sender, CancelEventArgs e)
        {
            ValidateTxtConnectionString();
        }

        bool ValidateTxtConnectionString()
        {
            _currentProfile.ConnectionString = TxtConnectionString.Text;
            errorProvider1.SetError(TxtConnectionString, "");
            ValidationResult result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("ConnectionString"));
            if (!result.IsValid)
                errorProvider1.SetError(TxtConnectionString, ErroresValidacion(result.Errors));

            return result.IsValid;
        }

        private void TxtConnectionString_ButtonClick(object sender, EventArgs e)
        {
            GetDBParameters();
        }

        void GetDBParameters()
        {

            var dbConnector = new MetroDataBaseConnector((EDatabaseEngine)CmbDataBaseEngine.SelectedValue, this.Theme, this.Style)
            {
                ConnectionString = TxtConnectionString.Text,
                PromptUser = true,
                BeforeConnectShowDefaultsParameters = true
            };
            dbConnector.Connect();
            if (dbConnector.IsConnectionSuccess)
                TxtConnectionString.Text = dbConnector.ConnectionString;
        }

        void BtnConnect_Click(object sender, EventArgs e)
        {
            if (ValidateTxtConnectionString() && ValidateTxtConnectionString())
                ConnectToDatabase();
        }

        void ConnectToDatabase()
        {
            var databaseEngine = (EDatabaseEngine)CmbDataBaseEngine.SelectedValue;
            if (!new DbUtil(databaseEngine, TxtConnectionString.Text).ConnectionSuccess(out string errMessage))
            {
                MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error {errMessage}", "Aviso al operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ControlEditState(EFormEditState.Connected);
            }

            FillObjects();

            if (CmbProfiles.SelectedItem != null)
            {
                _currentProfile = (Profile)CmbProfiles.SelectedItem;
                LoadProfileToControls();
            }
        }

        private void BtnUnconnect_Click(object sender, EventArgs e)
        {
            UnconnectDatabase();
        }

        void UnconnectDatabase()
        {
            ControlEditState(EFormEditState.Unconnected);
            LstObjects.Items.Clear();
        }


        private void TxtNamespace_Validating(object sender, CancelEventArgs e)
        {
            ValidateTxtNamespace();
        }

        private bool ValidateTxtNamespace()
        {
            _currentProfile.Namespace = TxtNamespace.Text;
            errorProvider1.SetError(TxtNamespace, "");
            ValidationResult result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("Namespace"));
            if (!result.IsValid)
                errorProvider1.SetError(TxtNamespace, ErroresValidacion(result.Errors));

            return result.IsValid;
        }

        private void ChkCreateEntity_CheckedChanged(object sender, EventArgs e)
        {
            TxtEntitiesDirectory.Enabled = ChkCreateEntity.Checked;
        }

        private void ChkCreateRepository_CheckedChanged(object sender, EventArgs e)
        {
            TxtRepositoriesDirectory.Enabled = ChkCreateRepository.Checked;
        }

        private void ChkCreateDataManager_CheckedChanged(object sender, EventArgs e)
        {
            TxtDataManagerDirectory.Enabled = ChkCreateDataManager.Checked;
            GrpDataManagerStyle.Visible = ChkCreateDataManager.Checked;
        }

        private void TxtEntitiesDirectory_Validating(object sender, CancelEventArgs e)
        {
            ValidateTxtEntitiesDirectory();
        }

        private bool ValidateTxtEntitiesDirectory()
        {
            _currentProfile.EntitiesDirectory = TxtEntitiesDirectory.Text;
            _currentProfile.CreateEntity = ChkCreateEntity.Checked;

            errorProvider1.SetError(TxtEntitiesDirectory, "");
            ValidationResult result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("EntitiesDirectory"));
            if (!result.IsValid)
                errorProvider1.SetError(TxtEntitiesDirectory, ErroresValidacion(result.Errors));

            return result.IsValid;
        }

        private void TxtEntitiesDirectory_ButtonClick(object sender, EventArgs e)
        {
            BrowseDirectoryEntities();
        }

        void BrowseDirectoryEntities()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                TxtEntitiesDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void TxtEntitiesDirectory_EnabledChanged(object sender, EventArgs e)
        {
            TxtEntitiesDirectory.CustomButton.Enabled = TxtEntitiesDirectory.Enabled;
        }

        private void TxtRepositoriesDirectory_Validating(object sender, CancelEventArgs e)
        {
            ValidateTxtRepositoriesDirectory();
        }

        private bool ValidateTxtRepositoriesDirectory()
        {
            _currentProfile.RepositoriesDirectory = TxtRepositoriesDirectory.Text;
            _currentProfile.CreateRepository = ChkCreateRepository.Checked;

            errorProvider1.SetError(TxtRepositoriesDirectory, "");
            ValidationResult result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("RepositoriesDirectory"));
            if (!result.IsValid)
                errorProvider1.SetError(TxtRepositoriesDirectory, ErroresValidacion(result.Errors));

            return result.IsValid;
        }

        private void TxtRepositoriesDirectory_ButtonClick(object sender, EventArgs e)
        {
            BrowseDirectoryRepositories();
        }

        void BrowseDirectoryRepositories()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                TxtRepositoriesDirectory.Text = folderBrowserDialog1.SelectedPath;
        }
        private void TxtRepositoriesDirectory_EnabledChanged(object sender, EventArgs e)
        {
            TxtRepositoriesDirectory.CustomButton.Enabled = TxtRepositoriesDirectory.Enabled;
        }

        private void TxtDataManagerDirectory_Validating(object sender, CancelEventArgs e)
        {
            ValidateTxtDataManagerDirectory();
        }

        private bool ValidateTxtDataManagerDirectory()
        {
            _currentProfile.DataManagerDirectory = TxtDataManagerDirectory.Text;
            _currentProfile.CreateDataManager = ChkCreateDataManager.Checked;

            errorProvider1.SetError(TxtDataManagerDirectory, "");
            ValidationResult result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("DataManagerDirectory"));
            if (!result.IsValid)
                errorProvider1.SetError(TxtDataManagerDirectory, ErroresValidacion(result.Errors));

            return result.IsValid;
        }

        private void TxtDataManagerDirectory_ButtonClick(object sender, EventArgs e)
        {
            BrowseDirectoryDataManager();
        }

        void BrowseDirectoryDataManager()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                TxtDataManagerDirectory.Text = folderBrowserDialog1.SelectedPath;
        }

        private void TxtDataManagerDirectory_EnabledChanged(object sender, EventArgs e)
        {
            TxtDataManagerDirectory.CustomButton.Enabled = (TxtDataManagerDirectory.Enabled);
        }

        private void RbtnDatamanagerStyle_CheckedChanged(object sender, EventArgs e)
        {
            ChkUseLazyLoad.Visible = this.RbtnInstantiable.Checked || RbtnDbContext.Checked;

            if (LstObjects.CheckedItems.Count > 0)
                RefreshListitemsSubtext();
        }

        void RefreshListitemsSubtext()
        {
            foreach (ListViewItem item in LstObjects.Items)
                SetSubtextItem(item);
        }

        void SetSubtextItem(ListViewItem item)
        {
            if (!item.Checked)
            {
                item.SubItems[2].Text = "";
                item.SubItems[3].Text = "";
            }
            else
            {
                item.SubItems[2].Text = GetEntityClassName(item.SubItems[1].Text);
                item.SubItems[3].Text = GetRepositoryPropertyDataManager(item.SubItems[1].Text, SelectedDatamanagerStyle());
            }
        }

        #region CLIPBOARD GENERATION
        void CopyToClipboard()
        {
            //    if (!ValidControls())
            //        return;

            //    EDatabaseEngine dataBaseEngine = (EDatabaseEngine)CmbDataBaseEngine.SelectedValue;

            //    StringBuilder sb = new StringBuilder();

            //    var repositories = new List<DbObjectWriterProperty>();
            //    var viewManagers = new List<DbObjectWriterProperty>();

            //    EDatamagerStyle dataManagerStyle = RbtnSingleton.Checked ? EDatamagerStyle.Singleton : EDatamagerStyle.SingletonPublicProperties;

            //    foreach (ListViewItem item in LstObjects.CheckedItems)
            //    {
            //        string dbObjectName = item.SubItems[1].Text;
            //        string dbObjectType = item.Text;
            //        bool isTable = (dbObjectType.ToLower() == "table");
            //        string className = item.SubItems[2].Text;

            //        if (isTable)
            //        {
            //            if (dataManagerStyle == EDatamagerStyle.SingletonPublicProperties)
            //                repositories.Add(new DbObjectWriterProperty(className + "Repository", dbObjectName));
            //            else
            //                repositories.Add(new DbObjectWriterProperty(className + "Repository", className + "Repository"));
            //        }
            //        else
            //        {
            //            if (dataManagerStyle == EDatamagerStyle.SingletonPublicProperties)
            //                viewManagers.Add(new DbObjectWriterProperty(className + "ViewManager", dbObjectName));
            //            else
            //                viewManagers.Add(new DbObjectWriterProperty(className + "ViewManager", className + "ViewManager"));
            //        }

            //        if (ChkCreateEntity.Checked)
            //        {
            //            object classCreator;
            //            if (isTable)
            //                classCreator = new EntityClassFromTable(dataBaseEngine, TxtConnectionString.Text, dbObjectName, className, TxtNamespace.Text, ChkCreatePartialClass.Checked);
            //            else
            //                classCreator = new EntityClassFromView(dataBaseEngine, TxtConnectionString.Text, dbObjectName, className, TxtNamespace.Text, ChkCreatePartialClass.Checked);

            //            sb.AppendLine(string.Format("// OBJETO {0}", className + ".cs"));
            //            sb.AppendLine("");
            //            sb.AppendLine(classCreator.ToString());
            //        }

            //        if (ChkCreateRepository.Checked)
            //        {
            //            object classCreator;
            //            if (isTable)
            //                classCreator = new RepositoryClassFromTable(dataBaseEngine, TxtConnectionString.Text, className, TxtNamespace.Text, dbObjectName, ChkCreatePartialClass.Checked);
            //            else
            //                classCreator = new ViewManagerClassFromView(dataBaseEngine, TxtConnectionString.Text, className, TxtNamespace.Text, dbObjectName, ChkCreatePartialClass.Checked);

            //            sb.AppendLine(string.Format("// OBJETO {0}", className + ".cs"));
            //            sb.AppendLine("");
            //            sb.AppendLine(classCreator.ToString());
            //        }
            //    }

            //    if (ChkCreateDataManager.Checked)
            //    {
            //        object dataManagerWriter;

            //        if (RbtnInstantiable.Checked)
            //            dataManagerWriter = new DataManagerInstantiableClassWriter(dataBaseEngine, TxtConnectionString.Text, TxtNamespace.Text, repositories, viewManagers, ChkUseLazyLoad.Checked, ChkCreatePartialClass.Checked);
            //        else
            //            dataManagerWriter = new DataManagerClassWriter(dataBaseEngine, TxtConnectionString.Text, TxtNamespace.Text, repositories, viewManagers, dataManagerStyle, ChkCreatePartialClass.Checked);


            //        if (dataManagerStyle == EDatamagerStyle.Singleton)
            //            sb.AppendLine(string.Format("// OBJETO {0}", "DataManager.cs"));
            //        else
            //            sb.AppendLine(string.Format("// OBJETO {0}", "Db.cs"));

            //        sb.AppendLine("");
            //        sb.AppendLine(dataManagerWriter.ToString());
            //    }

            //    Clipboard.SetText(sb.ToString());
            //    MetroMessageBox.Show(this, "Se ha copiado al portapapeles correctamente", "Aviso al operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion

        #region FILES CREATION
        void CreateFiles()
        {
            if (!ValidControls())
                return;

            if (ExistsGeneratedFiles())
            {
                if (MFChkOverrideFiles.Checked)
                {
                    if (MetroMessageBox.Show(this, "Atencion se han detectado archivos existentes en los directorios informados, y se ha seleccionado la opcion SOBREESCRIBIR archivos AUTOMATICAMENTE"
                        + Environment.NewLine
                        + "No recibirá ninguna advertencia. Este cambio no puede deshacerse."
                        + Environment.NewLine + Environment.NewLine + "¿Está de Acuerdo?", "Aviso al operador",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    if (MetroMessageBox.Show(this, "Atencion se han detectado archivos existentes en los directorios informados, y NO se ha seleccionado la opcion SOBREESCRIBIR archivos AUTOMATICAMENTE."
                        + Environment.NewLine
                        + "el proceso preguntará que hacer ARCHIVO por ARCHIVO." + Environment.NewLine + Environment.NewLine + "¿Está de Acuerdo?", "Aviso al operador",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            EDatabaseEngine dataBaseEngine = (EDatabaseEngine)CmbDataBaseEngine.SelectedValue;

            string dbObjectName = "";
            string dbObjectType = "";
            string className = "";
            int fileCounter = 0;
            var repositories = new List<DbObjectWriterProperty>();
            var viewManagers = new List<DbObjectWriterProperty>();

            EDatamagerStyle dataManagerStyle;
            if (RbtnInstantiable.Checked)
                dataManagerStyle = EDatamagerStyle.Instantiable;
            else if (RbtnSingleton.Checked)
                dataManagerStyle = EDatamagerStyle.Singleton;
            else if (RbtnSingletonPublicProperties.Checked)
                dataManagerStyle = EDatamagerStyle.SingletonPublicProperties;
            else
                throw new ArgumentOutOfRangeException("Estilo de Datamanager desconocido");

            var hasViews = LstObjects.CheckedItems.Cast<ListViewItem>().Where(v => v.Text.ToLower() == "view").Count() > 0;
            var hasTables = LstObjects.CheckedItems.Cast<ListViewItem>().Where(v => v.Text.ToLower() == "table").Count() > 0;

            string DataManagerDirectory = TxtDataManagerDirectory.Text;
            string EntitiesDirectory = TxtEntitiesDirectory.Text;
            string RepositoriesDirectory = TxtRepositoriesDirectory.Text;

            string filename = "";
            bool write;

            MFPrgbarFileCreation.Minimum = 0;
            MFPrgbarFileCreation.Maximum = LstObjects.CheckedItems.Count + 2;
            MFPrgbarFileCreation.Visible = true;

            foreach (ListViewItem item in LstObjects.CheckedItems)
            {
                dbObjectName = item.SubItems[1].Text;
                dbObjectType = item.Text;

                bool isTable = (dbObjectType.ToLower() == "table");
                MFPrgbarFileCreation.Value++;

                className = item.SubItems[2].Text;
                if (isTable)
                {
                    if (dataManagerStyle == EDatamagerStyle.SingletonPublicProperties || dataManagerStyle == EDatamagerStyle.Instantiable)
                        repositories.Add(new DbObjectWriterProperty(className + "Repository", className, dbObjectName));
                    else
                        repositories.Add(new DbObjectWriterProperty(className + "Repository", className + "Repository", dbObjectName));
                }
                else
                {
                    if (dataManagerStyle == EDatamagerStyle.SingletonPublicProperties || dataManagerStyle == EDatamagerStyle.Instantiable)
                        viewManagers.Add(new DbObjectWriterProperty(className + "ViewManager", className, dbObjectName));
                    else
                        viewManagers.Add(new DbObjectWriterProperty(className + "ViewManager", className + "ViewManager", dbObjectName));
                }

                if (ChkCreateEntity.Checked)
                {
                    object classCreator;
                    if (isTable)
                        classCreator = new EntityClassFromTable(dataBaseEngine, TxtConnectionString.Text, dbObjectName, className, TxtNamespace.Text, ChkCreatePartialClass.Checked);
                    else
                        classCreator = new EntityClassFromView(dataBaseEngine, TxtConnectionString.Text, dbObjectName, className, TxtNamespace.Text, ChkCreatePartialClass.Checked);

                    filename = Path.Combine(EntitiesDirectory, className + ".cs");

                    write = true;
                    if (File.Exists(filename) && !MFChkOverrideFiles.Checked)
                        write = MetroMessageBox.Show(this, string.Format("El archivo {0} ya existe, ¿desea reemplazarlo?", filename), "Aviso al operador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                    if (write)
                    {
                        try
                        {
                            File.WriteAllText(filename, classCreator.ToString());
                            fileCounter++;
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar escribir el archivo: {filename} {Environment.NewLine} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                if (ChkCreateRepository.Checked)
                {
                    ICodeWriterClass classCreator;
                    if (isTable)
                    {
                        classCreator = new RepositoryClassFromTable(dataBaseEngine, TxtConnectionString.Text, className, TxtNamespace.Text, dbObjectName, ChkCreatePartialClass.Checked);
                        filename = Path.Combine(RepositoriesDirectory, className + "Repository.cs");
                    }
                    else
                    {
                        classCreator = new ViewManagerClassFromView(dataBaseEngine, TxtConnectionString.Text, className, TxtNamespace.Text, dbObjectName, ChkCreatePartialClass.Checked);
                        filename = Path.Combine(RepositoriesDirectory, className + "ViewManager.cs");
                    }

                    write = true;
                    if (File.Exists(filename) && !MFChkOverrideFiles.Checked)
                        write = MetroMessageBox.Show(this, string.Format("El archivo {0} ya existe, ¿desea reemplazarlo?", filename), "Aviso al operador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                    if (write)
                    {
                        try
                        {
                            File.WriteAllText(filename, classCreator.ToString());
                            fileCounter++;
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar escribir el archivo: {filename} {Environment.NewLine} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }

            if (ChkCreateDataManager.Checked)
            {
                object dataManagerWriter;
                if (dataManagerStyle == EDatamagerStyle.Instantiable)
                    dataManagerWriter = new DataManagerInstantiableClassWriter(dataBaseEngine, TxtConnectionString.Text, TxtNamespace.Text, repositories, viewManagers, ChkUseLazyLoad.Checked, ChkCreatePartialClass.Checked);
                else
                    dataManagerWriter = new DataManagerClassWriter(dataBaseEngine, TxtConnectionString.Text, TxtNamespace.Text, repositories, viewManagers, dataManagerStyle, ChkCreatePartialClass.Checked);

                if (dataManagerStyle == EDatamagerStyle.Instantiable || dataManagerStyle == EDatamagerStyle.SingletonPublicProperties)
                    filename = Path.Combine(TxtDataManagerDirectory.Text, "Db.cs");
                else
                    filename = Path.Combine(TxtDataManagerDirectory.Text, "Datamanager.cs");

                write = true;
                if (File.Exists(filename) && !MFChkOverrideFiles.Checked)
                    write = MetroMessageBox.Show(this, string.Format("El archivo {0} ya existe, ¿desea reemplazarlo?", filename), "Aviso al operador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                if (write)
                {
                    try
                    {
                        File.WriteAllText(filename, dataManagerWriter.ToString());
                        fileCounter++;
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar escribir el archivo: {filename} {Environment.NewLine} {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MFPrgbarFileCreation.Visible = false;

            MetroMessageBox.Show(this, $"Se han generado {fileCounter} archivos correctamente", "Aviso al operador", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ExistsGeneratedFiles()
        {
            return ((!string.IsNullOrWhiteSpace(TxtEntitiesDirectory.Text)) && (Directory.GetFiles(TxtEntitiesDirectory.Text, "*.cs").Length > 0))
                || ((!string.IsNullOrWhiteSpace(TxtRepositoriesDirectory.Text)) && (Directory.GetFiles(TxtRepositoriesDirectory.Text, "*.cs").Length > 0))
                || ((!string.IsNullOrWhiteSpace(TxtDataManagerDirectory.Text)) && (Directory.GetFiles(TxtDataManagerDirectory.Text, "*.cs").Length > 0));
        }
        #endregion

        #region PROFILE ACTIONS
        void DeleteProfile()
        {
            if (_currentProfile.IdProfile == -1)
            {
                MetroMessageBox.Show(this, "El nombre de perfil seleccionado no se puede eliminar porque no existe!!",
                    "Aviso al operador",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MetroMessageBox.Show(this, "¿Realmente desea eliminar el perfil seleccionado?",
                    "Aviso al operador",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        _db.DeleteProfile(_currentProfile);

                        MetroMessageBox.Show(this, "Se ha eliminado correctamente el perfil seleccionado",
                            "Aviso al operador",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        _currentProfile = new Profile();
                        _currentProfile.IdProfile = -1;
                        LoadProfiles();
                    }
                    catch (Exception exception)
                    {
                        MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar eliminar el perfil:{exception.Message}",
                            "Aviso al operador",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        void LoadProfiles()
        {
            _loadingData = true;
            try
            {
                CmbProfiles.DataSource = null;
                CmbProfiles.DisplayMember = "ProfileName";
                CmbProfiles.ValueMember = "IdProfile";
                CmbProfiles.DataSource = _db.GetProfilesWithSelectedObjects();
                CmbProfiles.AutoCompleteSource = AutoCompleteSource.ListItems;
                CmbProfiles.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                CmbProfiles.Refresh();

                if (_currentProfile.IdProfile == -1)
                    CmbProfiles.SelectedItem = null;
                else
                {
                    CmbProfiles.SelectedValue = _currentProfile.IdProfile;
                    LoadProfileToControls();
                }

            }
            catch (Exception e)
            {

                MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar cargar los perfiles: {e.Message}",
                                "Aviso al operador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _loadingData = false;
        }

        void LoadProfileToControls()
        {
            if (_currentProfile == null) return;

            _loadingData = true;

            CmbProfiles.Text = _currentProfile.ProfileName;
            CmbDataBaseEngine.Text = "";
            if (Enum.TryParse<EDatabaseEngine>(_currentProfile.DatabaseEngine, out EDatabaseEngine databaseEngine))
                CmbDataBaseEngine.Text = databaseEngine.ToString();

            TxtConnectionString.Text = _currentProfile.ConnectionString;
            ChkCreateEntity.Checked = _currentProfile.CreateEntity;
            ChkCreateRepository.Checked = _currentProfile.CreateRepository;
            ChkCreateDataManager.Checked = _currentProfile.CreateDataManager;

            if (Enum.TryParse(_currentProfile.DatamanagerStyle, out EDatamagerStyle dms))
            {
                RbtnInstantiable.Checked = (dms == EDatamagerStyle.Instantiable);
                RbtnSingleton.Checked = (dms == EDatamagerStyle.Singleton);
                RbtnSingletonPublicProperties.Checked = (dms == EDatamagerStyle.SingletonPublicProperties);
            }

            ChkUseLazyLoad.Checked = _currentProfile.UseLazyLoad;
            TxtNamespace.Text = _currentProfile.Namespace;
            ChkTables.Checked = _currentProfile.FillTables;
            ChkViews.Checked = _currentProfile.FillViews;
            ChkCreatePartialClass.Checked = _currentProfile.CreatePartialClass;

            RbtnSingularizatorNone.Checked = (string.IsNullOrWhiteSpace(_currentProfile.Singularizator));
            RbtnSingularizatorHumanizer.Checked = (_currentProfile.Singularizator == "Humanizer");
            RbtnSingularizatorInternal.Checked = (_currentProfile.Singularizator == "Internal");

            TxtEntitiesDirectory.Text = _currentProfile.EntitiesDirectory;
            TxtRepositoriesDirectory.Text = _currentProfile.RepositoriesDirectory;
            TxtDataManagerDirectory.Text = _currentProfile.DataManagerDirectory;

            LstObjects.CheckedItems.Cast<ListViewItem>().ToList().ForEach(l => l.Checked = false);

            foreach (var item in _currentProfile.ProfileSelectedObjects)
            {
                var lvi = (ListViewItem)LstObjects.Items.Cast<ListViewItem>().Where(l => l.Text == item.ObjectType && l.SubItems[1].Text == item.ObjectName).SingleOrDefault();
                if (lvi != null)
                {
                    LstObjects.Items[lvi.Index].Checked = true;
                    LstObjects.Items[lvi.Index].Tag = item;
                }
            }

            if (_currentProfile.SortColumn > 0)
            {
                _listViewColumnSorter.SortColumn = _currentProfile.SortColumn;
                _listViewColumnSorter.Order = (SortOrder)_currentProfile.SortOrder;

                foreach (var item in LstObjects.Columns)
                    SetSortArrow((ColumnHeader)item, SortOrder.None);
            }

            LstObjects.Sort();

            _loadingData = false;
        }

        void GetProfileFromControlsValues()
        {
            _ = _currentProfile.IdProfile;
            _currentProfile.ProfileName = CmbProfiles.Text;
            _currentProfile.DatabaseEngine = CmbDataBaseEngine.Text;
            _currentProfile.ConnectionString = TxtConnectionString.Text;
            _currentProfile.CreateEntity = ChkCreateEntity.Checked;
            _currentProfile.CreateRepository = ChkCreateRepository.Checked;
            _currentProfile.CreateDataManager = ChkCreateDataManager.Checked;
            _currentProfile.DatamanagerStyle = SelectedDatamanagerStyle().ToString();
            _currentProfile.UseLazyLoad = ChkUseLazyLoad.Checked && SelectedDatamanagerStyle() == EDatamagerStyle.Instantiable;
            _currentProfile.Namespace = TxtNamespace.Text;
            _currentProfile.FillTables = ChkTables.Checked;
            _currentProfile.FillViews = ChkViews.Checked;
            _currentProfile.Singularizator = GetSingularizatorValue();
            _currentProfile.EntitiesDirectory = TxtEntitiesDirectory.Text;
            _currentProfile.RepositoriesDirectory = TxtRepositoriesDirectory.Text;
            _currentProfile.DataManagerDirectory = TxtDataManagerDirectory.Text;
            _currentProfile.SortColumn = _listViewColumnSorter.SortColumn;
            _currentProfile.SortOrder = (int)_listViewColumnSorter.Order;
            _currentProfile.CreatePartialClass = ChkCreatePartialClass.Checked;

            _currentProfile.ProfileSelectedObjects.Clear();
            foreach (var item in LstObjects.CheckedItems.Cast<ListViewItem>())
            {
                var idProfileSelectedObject = (item.Tag != null) ? ((ProfileSelectedObject)item.Tag).IdProfileSelectedObject : -1;

                _currentProfile.ProfileSelectedObjects.Add
                (
                    new ProfileSelectedObject(_currentProfile.IdProfile, item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, idProfileSelectedObject)
                );
            }
        }

        private string GetSingularizatorValue()
        {

            if (RbtnSingularizatorHumanizer.Checked)
                return "Humanizer";
            else if (RbtnSingularizatorInternal.Checked)
                return "Internal";
            else
                return "";
        }

        #endregion

        #region CAPTURE EVENTS 
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTextInListView();
        }

        void SearchTextInListView()
        {
            LstObjects.SelectedItems.Clear();
            if ((!TxtSearch.Text.Equals("")) && (LstObjects.Items.Count > 0))
            {
                ListViewItem l;

                l = FormUtil.FindItemContainsText(LstObjects, TxtSearch.Text);

                if (l != null)
                {
                    LstObjects.Items[l.Index].Selected = true;
                    LstObjects.Items[l.Index].EnsureVisible();
                }
            }
        }

        private void BtnCreateFiles_Click(object sender, EventArgs e)
        {
            CreateFiles();
        }

        private void BtnCopyClipboard_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }


        private void LstObjects_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            LstObjectsItemCheched(e);
        }

        private void LstObjects_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            LstObjects.ListViewItemSorter = _listViewColumnSorter;

            if (e.Column == _listViewColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (_listViewColumnSorter.Order == System.Windows.Forms.SortOrder.Ascending)
                    _listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Descending;
                else
                    _listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                _listViewColumnSorter.SortColumn = e.Column;
                _listViewColumnSorter.Order = System.Windows.Forms.SortOrder.Ascending;
            }

            foreach (var item in LstObjects.Columns)
                SetSortArrow((ColumnHeader)item, SortOrder.None);


            SetSortArrow(LstObjects.Columns[e.Column], _listViewColumnSorter.Order);

            // Perform the sort with these new sort options.
            LstObjects.Sort();
        }

        private void BtnRefreshSingularizator_Click(object sender, EventArgs e)
        {
            RefreshListitemsSubtext();
        }

        private void ChkTables_CheckedChanged(object sender, EventArgs e)
        {
            FillObjects();
        }

        private void ChkViews_CheckedChanged(object sender, EventArgs e)
        {
            FillObjects();
        }

        private void TsbSelectAll_ButtonClick(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void SelectAll()
        {
            MetroProgressbarObj.Minimum = 0;
            MetroProgressbarObj.Maximum = LstObjects.Items.Count;
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Value = 0;
            MetroProgressbarObj.Refresh();

            foreach (var l in LstObjects.Items.Cast<ListViewItem>().ToList())
            {
                l.Checked = true;
                MetroProgressbarObj.Value++;
            }
            MetroProgressbarObj.Visible = false;
        }

        private void TsbUnSelectAll_ButtonClick(object sender, EventArgs e)
        {
            UnSelectAll();
        }

        private void UnSelectAll()
        {
            MetroProgressbarObj.Minimum = 0;
            MetroProgressbarObj.Maximum = LstObjects.Items.Count;
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Value = 0;
            MetroProgressbarObj.Refresh();
            foreach (var l in LstObjects.Items.Cast<ListViewItem>().ToList())
            {
                l.Checked = false;
                MetroProgressbarObj.Value++;
            }
            MetroProgressbarObj.Visible = false;
        }

        private void TablasSelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllTables();
        }

        private void SelectAllTables()
        {
            var tableList = LstObjects.Items.Cast<ListViewItem>()
                .Where(i => i.Text.ToLower() == "table")
                .ToList();
            MetroProgressbarObj.Minimum = 0;
            MetroProgressbarObj.Maximum = tableList.Count;
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Value = 0;
            MetroProgressbarObj.Refresh();
            foreach (var l in tableList)
            {
                l.Checked = true;
                MetroProgressbarObj.Value++;
            }
            MetroProgressbarObj.Visible = false;
        }

        private void ViewsSelectAllToolStripMenuItem_Click(object sender, EventArgs e) =>
            SelectAllViews();

        private void SelectAllViews()
        {
            var tableList = LstObjects.Items.Cast<ListViewItem>()
                .Where(i => i.Text.ToLower() == "view")
                .ToList();
            MetroProgressbarObj.Minimum = 0;
            MetroProgressbarObj.Maximum = tableList.Count;
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Value = 0;
            MetroProgressbarObj.Refresh();
            foreach (var l in tableList)
            {
                l.Checked = true;
                MetroProgressbarObj.Value++;
            }
            MetroProgressbarObj.Visible = false;
        }

        private void TablasUnselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnSelectAllTables();
        }

        private void UnSelectAllTables()
        {
            var tableList = LstObjects.Items.Cast<ListViewItem>()
                .Where(i => i.Text.ToLower() == "table")
                .ToList();
            MetroProgressbarObj.Minimum = 0;
            MetroProgressbarObj.Maximum = tableList.Count;
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Value = 0;
            MetroProgressbarObj.Refresh();
            foreach (var l in tableList)
            {
                l.Checked = false;
                MetroProgressbarObj.Value++;
            }
            MetroProgressbarObj.Visible = false;
        }

        private void ViewsUnselectAllToolStripMenuItem_Click(object sender, EventArgs e) =>
            UnSelectAllViews();

        private void UnSelectAllViews()
        {
            var tableList = LstObjects.Items.Cast<ListViewItem>()
                .Where(i => i.Text.ToLower() == "view")
                .ToList();

            MetroProgressbarObj.Minimum = 0;
            MetroProgressbarObj.Maximum = tableList.Count;
            MetroProgressbarObj.Visible = true;
            MetroProgressbarObj.Value = 0;
            MetroProgressbarObj.Refresh();

            foreach (var l in tableList)
            {
                l.Checked = false;
                MetroProgressbarObj.Value++;
            }

            MetroProgressbarObj.Visible = false;
        }
        #endregion

        #region HELPERS
        string ErroresValidacion(List<ValidationFailure> errores)
        {
            string result = "";
            foreach (ValidationFailure error in errores)
                result += error.ErrorMessage + Environment.NewLine;

            return result;
        }
        EDatamagerStyle SelectedDatamanagerStyle()
        {
            if (this.RbtnInstantiable.Checked)
                return EDatamagerStyle.Instantiable;
            else if (this.RbtnSingleton.Checked)
                return EDatamagerStyle.Singleton;
            else if (this.RbtnSingletonPublicProperties.Checked)
                return EDatamagerStyle.SingletonPublicProperties;
            else
                throw new ArgumentOutOfRangeException();
        }

        string GetEntityClassName(string tableOrViewName)
        {
            tableOrViewName = Regex.Replace(tableOrViewName, "[^a-zA-Z0-9_]", "_");

            if (NoSingularizator())
                return tableOrViewName;
            else
                return SingularizeWord(tableOrViewName, UseHumanizer());
        }



        string GetRepositoryClassName(string tableOrViewName)
        {
            tableOrViewName = Regex.Replace(tableOrViewName, "[^a-zA-Z0-9_]", "_");
            return tableOrViewName + "Repository";
        }

        string GetRepositoryPropertyDataManager(string tableOrViewName, EDatamagerStyle datamanagerStyle)
        {
            tableOrViewName = Regex.Replace(tableOrViewName, "[^a-zA-Z0-9_]", "_");
            switch (datamanagerStyle)
            {
                case EDatamagerStyle.Singleton:
                    return GetRepositoryClassName(tableOrViewName);
                case EDatamagerStyle.SingletonPublicProperties:
                    return tableOrViewName;
                case EDatamagerStyle.Instantiable:
                    return tableOrViewName;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        string[] CamelCaseToSpaceSeparated(string camelCaseString)
        {
            if (string.IsNullOrEmpty(camelCaseString))
            {
                return new string[0];
            }

            var res = new StringBuilder();
            res.Append(camelCaseString[0]);
            for (var i = 1; i < camelCaseString.Length; i++)
            {
                if (char.IsUpper(camelCaseString[i]))
                    res.Append(' ');

                res.Append(camelCaseString[i]);

            }
            return res.ToString().Split(' ');
        }

        string SpecialSpanishSingularizeWord(string word)
        {
            string ret;
            if (word.ToLower().EndsWith("as"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("jes"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("lles"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("ls"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("rnes"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("bles"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("es"))
            {
                ret = word.Substring(0, word.Length - 2);
                if (ret.EndsWith("t"))
                    ret += "e";
            }
            else if (word.ToLower().EndsWith("is"))
            {
                ret = word.Substring(0, word.Length - 1);

            }
            else if (word.ToLower().EndsWith("os"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else if (word.ToLower().EndsWith("us"))
            {
                ret = word.Substring(0, word.Length - 1);
            }
            else
            {
                ret = word;
            }

            ret = ret.Substring(0, 1).ToUpper() + ret.Substring(1);

            return ret;
        }
        string SingularizeWord(string words, bool useHumanizer)
        {
            List<string> result;
            if (!useHumanizer)
            {
                result = CamelCaseToSpaceSeparated(words).ToList();
                for (int i = 0; i < result.Count; i++)
                    result[i] = SpecialSpanishSingularizeWord(result[i]).Transform(To.LowerCase, To.TitleCase);
            }
            else
            {
                result = words.Humanize()
                            .Split(' ')
                            .ToList();
                for (int i = 0; i < result.Count; i++)
                    result[i] = result[i].Singularize().Transform(To.LowerCase, To.TitleCase);
            }

            return string.Join(" ", result).Dehumanize();
        }

        void SetSortArrow(ColumnHeader head, SortOrder order)
        {
            const string ascArrow = " ▲";
            const string descArrow = " ▼";

            // remove arrow
            if (head.Text.EndsWith(ascArrow) || head.Text.EndsWith(descArrow))
                head.Text = head.Text.Substring(0, head.Text.Length - 2);

            // add arrow
            switch (order)
            {
                case SortOrder.Ascending: head.Text += ascArrow; break;
                case SortOrder.Descending: head.Text += descArrow; break;
            }
        }
        #endregion

        private void SaveProfile()
        {
            if (!ValidControls())
                return;

            var result = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("ProfileName"));
            if (!result.IsValid)
            {
                MetroMessageBox.Show(this, ErroresValidacion(result.Errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentProfile.IdProfile == -1)
            {
                try
                {
                    if (MetroMessageBox.Show(this, "¿Realmente desea dar de alta este Perfil?", "Aviso al operador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _currentProfile = _db.AddProfile(_currentProfile);
                    }
                    LoadProfiles();

                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar grabar el perfil:{exception.Message}",
                        "Aviso al operador",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    if (MetroMessageBox.Show(this, "¿Realmente desea actualizar el Perfil seleccionado", "Aviso al operador", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        if (_db.UpdateProfile(_currentProfile))
                            LoadProfiles();
                }
                catch (Exception exception)
                {
                    MetroMessageBox.Show(this, $"Ha ocurrido el siguiente error al intentar actualizar el perfil:{exception.Message}",
                        "Aviso al operador",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        bool ValidControls()
        {
            GetProfileFromControlsValues();

            var result = ValidateCmbDatabaseEngine();
            result &= ValidateTxtConnectionString();
            result &= ValidateTxtNamespace();
            result &= ValidateTxtEntitiesDirectory();
            result &= ValidateTxtRepositoriesDirectory();
            result &= ValidateTxtDataManagerDirectory();

            if (result)
            {
                ValidationResult vlResult = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("CheckCreateSomeObject"));
                if (!vlResult.IsValid)
                {
                    MetroMessageBox.Show(this, ErroresValidacion(vlResult.Errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (result)
            {
                ValidationResult vlResult = _profileValidator.Validate(_currentProfile, options => options.IncludeRuleSets("ProfileSelectedObject"));
                if (!vlResult.IsValid)
                {
                    MetroMessageBox.Show(this, ErroresValidacion(vlResult.Errors), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return result;
        }

        private void CmbProfile_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_loadingData)
            {
                _currentProfile = (Profile)CmbProfiles.SelectedItem;
                LoadProfileToControls();
            }
        }

        private void MetroToolbarDisplaySettings_SettingsChanged(object sender, MetroControls.MetroToolbars.MetroToolbarDisplaySettingsChangeEventArgs e)
        {
            _displaySettingsManager.MetroTheme = e.Theme;
            _displaySettingsManager.MetroStyle = e.Style;
            _displaySettingsManager.Apply();

            _db.SaveConfiguration("Theme", ((long)(e.Theme)).ToString());
            _db.SaveConfiguration("Style", ((long)(e.Style)).ToString());
        }

        private void MetroToolbarCRUDSmall_ActionSelected(object sender, MetroToolbarCRUDClickEventArgs e)
        {
            switch (e.Action)
            {
                case MetroToolbarCRUDAction.Delete:
                    DeleteProfile();
                    break;
                case MetroToolbarCRUDAction.Refresh:
                    LoadProfiles();
                    break;
                case MetroToolbarCRUDAction.Save:
                    SaveProfile();
                    break;
                default:
                    break;
            }
        }

        private bool UseHumanizer()
        {
            return RbtnSingularizatorHumanizer.Checked;
        }
        private bool NoSingularizator()
        {
            return RbtnSingularizatorNone.Checked;
        }

        private enum EFormEditState
        {
            Connected,
            Unconnected
        }

        private class DbObject
        {
            public bool Checked { get; set; }
            public string ObjectType { get; set; }
            public string ObjectName { get; set; }
            public string EntityName { get; set; }
            public string PublicPropertyName { get; set; }
        }

        private void ChkExcludeSysObjects_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtConnectionString_Click(object sender, EventArgs e)
        {

        }
    }
}
