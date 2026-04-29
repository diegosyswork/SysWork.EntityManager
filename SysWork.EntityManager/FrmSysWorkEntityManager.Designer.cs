namespace SysWork.EntityManager
{
    partial class FrmEntityManager
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntityManager));
            this.GrpDetails = new MetroFramework.Controls.MetroGroupBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.ToolStripSelectUnselect = new System.Windows.Forms.ToolStrip();
            this.ToolStripBtnSelectAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnSelectAll_DD = new System.Windows.Forms.ToolStripSplitButton();
            this.SelectTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripBtnUnselectAll = new System.Windows.Forms.ToolStripButton();
            this.ToolStripBtnUnselectAll_DD = new System.Windows.Forms.ToolStripSplitButton();
            this.UnselectTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnselectViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MFPrgbarFileCreation = new MetroFramework.Controls.MetroProgressBar();
            this.MFChkOverrideFiles = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtDataManagerDirectory = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtRepositoriesDirectory = new MetroFramework.Controls.MetroTextBox();
            this.MetroProgressbarObj = new MetroFramework.Controls.MetroProgressBar();
            this.ChkCreatePartialClass = new MetroFramework.Controls.MetroCheckBox();
            this.ChkExcludeSysObjects = new MetroFramework.Controls.MetroCheckBox();
            this.lblObChecked = new MetroFramework.Controls.MetroLabel();
            this.GrpDataManagerStyle = new MetroFramework.Controls.MetroGroupBox();
            this.RbtnDbContext = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnInstantiable = new MetroFramework.Controls.MetroRadioButton();
            this.ChkUseLazyLoad = new MetroFramework.Controls.MetroCheckBox();
            this.RbtnSingleton = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnSingletonPublicProperties = new MetroFramework.Controls.MetroRadioButton();
            this.MetroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.GrpSingularizator = new MetroFramework.Controls.MetroGroupBox();
            this.RbtnSingularizatorNone = new MetroFramework.Controls.MetroRadioButton();
            this.BtnRefreshSingularizator = new MetroFramework.Controls.MetroButton();
            this.RbtnSingularizatorInternal = new MetroFramework.Controls.MetroRadioButton();
            this.RbtnSingularizatorHumanizer = new MetroFramework.Controls.MetroRadioButton();
            this.ChkCreateDataManager = new MetroFramework.Controls.MetroCheckBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.TxtSearch = new MetroFramework.Controls.MetroTextBox();
            this.TxtEntitiesDirectory = new MetroFramework.Controls.MetroTextBox();
            this.ChkViews = new MetroFramework.Controls.MetroCheckBox();
            this.ChkTables = new MetroFramework.Controls.MetroCheckBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.ChkCreateRepository = new MetroFramework.Controls.MetroCheckBox();
            this.ChkCreateEntity = new MetroFramework.Controls.MetroCheckBox();
            this.TxtNamespace = new MetroFramework.Controls.MetroTextBox();
            this.Namespace = new MetroFramework.Controls.MetroLabel();
            this.BtnCreateFiles = new MetroFramework.Controls.MetroButton();
            this.BtnCopyClipboard = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroScrollBar1 = new MetroFramework.Controls.MetroScrollBar();
            this.LstObjects = new MetroFramework.Controls.MetroListView();
            this.ColType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColObjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColEntityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPublicPropertyName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GrpDBParameters = new MetroFramework.Controls.MetroGroupBox();
            this.BtnUnconnect = new MetroFramework.Controls.MetroButton();
            this.BtnConnect = new MetroFramework.Controls.MetroButton();
            this.TxtConnectionString = new MetroFramework.Controls.MetroTextBox();
            this.CmbDataBaseEngine = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrpProfiles = new MetroFramework.Controls.MetroGroupBox();
            this.MetroToolbarCRUDSmall1 = new SysWork.MetroControls.MetroToolbars.MetroToolbarCRUDSmall();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CmbProfiles = new MetroFramework.Controls.MetroComboBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.MetroRendererManager1 = new MetroFramework.Components.MetroRendererManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.miniToolStrip = new MetroFramework.Controls.MetroToolStrip();
            this.metroToolbarDisplaySettings1 = new SysWork.MetroControls.MetroToolbars.MetroToolbarDisplaySettings();
            this.GrpDetails.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.ToolStripSelectUnselect.SuspendLayout();
            this.GrpDataManagerStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager1)).BeginInit();
            this.GrpSingularizator.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.GrpDBParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.GrpProfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpDetails
            // 
            this.GrpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpDetails.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Full;
            this.GrpDetails.Controls.Add(this.metroPanel2);
            this.GrpDetails.Controls.Add(this.MFPrgbarFileCreation);
            this.GrpDetails.Controls.Add(this.MFChkOverrideFiles);
            this.GrpDetails.Controls.Add(this.metroLabel3);
            this.GrpDetails.Controls.Add(this.TxtDataManagerDirectory);
            this.GrpDetails.Controls.Add(this.metroLabel2);
            this.GrpDetails.Controls.Add(this.TxtRepositoriesDirectory);
            this.GrpDetails.Controls.Add(this.MetroProgressbarObj);
            this.GrpDetails.Controls.Add(this.ChkCreatePartialClass);
            this.GrpDetails.Controls.Add(this.ChkExcludeSysObjects);
            this.GrpDetails.Controls.Add(this.lblObChecked);
            this.GrpDetails.Controls.Add(this.GrpDataManagerStyle);
            this.GrpDetails.Controls.Add(this.label6);
            this.GrpDetails.Controls.Add(this.GrpSingularizator);
            this.GrpDetails.Controls.Add(this.ChkCreateDataManager);
            this.GrpDetails.Controls.Add(this.label5);
            this.GrpDetails.Controls.Add(this.label1);
            this.GrpDetails.Controls.Add(this.TxtSearch);
            this.GrpDetails.Controls.Add(this.TxtEntitiesDirectory);
            this.GrpDetails.Controls.Add(this.ChkViews);
            this.GrpDetails.Controls.Add(this.ChkTables);
            this.GrpDetails.Controls.Add(this.label2);
            this.GrpDetails.Controls.Add(this.ChkCreateRepository);
            this.GrpDetails.Controls.Add(this.ChkCreateEntity);
            this.GrpDetails.Controls.Add(this.TxtNamespace);
            this.GrpDetails.Controls.Add(this.Namespace);
            this.GrpDetails.Controls.Add(this.BtnCreateFiles);
            this.GrpDetails.Controls.Add(this.BtnCopyClipboard);
            this.GrpDetails.DrawBottomLine = false;
            this.GrpDetails.DrawShadows = false;
            this.GrpDetails.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrpDetails.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.GrpDetails.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.GrpDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.GrpDetails.Location = new System.Drawing.Point(7, 234);
            this.GrpDetails.Name = "GrpDetails";
            this.GrpDetails.PaintDefault = false;
            this.GrpDetails.Size = new System.Drawing.Size(974, 524);
            this.GrpDetails.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrpDetails.StyleManager = this.MetroStyleManager1;
            this.GrpDetails.TabIndex = 1;
            this.GrpDetails.TabStop = false;
            this.GrpDetails.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrpDetails.UseStyleColors = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel2.Controls.Add(this.ToolStripSelectUnselect);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(6, 368);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(292, 30);
            this.metroPanel2.TabIndex = 57;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // ToolStripSelectUnselect
            // 
            this.ToolStripSelectUnselect.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripSelectUnselect.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripBtnSelectAll,
            this.ToolStripBtnSelectAll_DD,
            this.ToolStripBtnUnselectAll,
            this.ToolStripBtnUnselectAll_DD});
            this.ToolStripSelectUnselect.Location = new System.Drawing.Point(0, 0);
            this.ToolStripSelectUnselect.Name = "ToolStripSelectUnselect";
            this.ToolStripSelectUnselect.Size = new System.Drawing.Size(292, 25);
            this.ToolStripSelectUnselect.TabIndex = 2;
            this.ToolStripSelectUnselect.Text = "toolStrip1";
            // 
            // ToolStripBtnSelectAll
            // 
            this.ToolStripBtnSelectAll.Checked = true;
            this.ToolStripBtnSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripBtnSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripBtnSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnSelectAll.Image")));
            this.ToolStripBtnSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnSelectAll.Name = "ToolStripBtnSelectAll";
            this.ToolStripBtnSelectAll.Size = new System.Drawing.Size(101, 22);
            this.ToolStripBtnSelectAll.Text = "&Seleccionar Todo";
            this.ToolStripBtnSelectAll.Click += new System.EventHandler(this.TsbSelectAll_ButtonClick);
            // 
            // ToolStripBtnSelectAll_DD
            // 
            this.ToolStripBtnSelectAll_DD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripBtnSelectAll_DD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectTablesToolStripMenuItem,
            this.SelectViewsToolStripMenuItem});
            this.ToolStripBtnSelectAll_DD.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnSelectAll_DD.Image")));
            this.ToolStripBtnSelectAll_DD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnSelectAll_DD.Name = "ToolStripBtnSelectAll_DD";
            this.ToolStripBtnSelectAll_DD.Size = new System.Drawing.Size(16, 22);
            // 
            // SelectTablesToolStripMenuItem
            // 
            this.SelectTablesToolStripMenuItem.Name = "SelectTablesToolStripMenuItem";
            this.SelectTablesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.SelectTablesToolStripMenuItem.Text = "Tables";
            this.SelectTablesToolStripMenuItem.Click += new System.EventHandler(this.TablasSelectAllToolStripMenuItem_Click);
            // 
            // SelectViewsToolStripMenuItem
            // 
            this.SelectViewsToolStripMenuItem.Name = "SelectViewsToolStripMenuItem";
            this.SelectViewsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.SelectViewsToolStripMenuItem.Text = "Views";
            this.SelectViewsToolStripMenuItem.Click += new System.EventHandler(this.ViewsSelectAllToolStripMenuItem_Click);
            // 
            // ToolStripBtnUnselectAll
            // 
            this.ToolStripBtnUnselectAll.Checked = true;
            this.ToolStripBtnUnselectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripBtnUnselectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripBtnUnselectAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnUnselectAll.Image")));
            this.ToolStripBtnUnselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnUnselectAll.Name = "ToolStripBtnUnselectAll";
            this.ToolStripBtnUnselectAll.Size = new System.Drawing.Size(114, 22);
            this.ToolStripBtnUnselectAll.Text = "&Deseleccionar Todo";
            this.ToolStripBtnUnselectAll.Click += new System.EventHandler(this.TsbUnSelectAll_ButtonClick);
            // 
            // ToolStripBtnUnselectAll_DD
            // 
            this.ToolStripBtnUnselectAll_DD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ToolStripBtnUnselectAll_DD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UnselectTablesToolStripMenuItem,
            this.UnselectViewsToolStripMenuItem});
            this.ToolStripBtnUnselectAll_DD.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripBtnUnselectAll_DD.Image")));
            this.ToolStripBtnUnselectAll_DD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripBtnUnselectAll_DD.Name = "ToolStripBtnUnselectAll_DD";
            this.ToolStripBtnUnselectAll_DD.Size = new System.Drawing.Size(16, 22);
            // 
            // UnselectTablesToolStripMenuItem
            // 
            this.UnselectTablesToolStripMenuItem.Name = "UnselectTablesToolStripMenuItem";
            this.UnselectTablesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.UnselectTablesToolStripMenuItem.Text = "Tables";
            this.UnselectTablesToolStripMenuItem.Click += new System.EventHandler(this.TablasUnselectAllToolStripMenuItem_Click);
            // 
            // UnselectViewsToolStripMenuItem
            // 
            this.UnselectViewsToolStripMenuItem.Name = "UnselectViewsToolStripMenuItem";
            this.UnselectViewsToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.UnselectViewsToolStripMenuItem.Text = "Views";
            this.UnselectViewsToolStripMenuItem.Click += new System.EventHandler(this.ViewsUnselectAllToolStripMenuItem_Click);
            // 
            // MFPrgbarFileCreation
            // 
            this.MFPrgbarFileCreation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MFPrgbarFileCreation.Location = new System.Drawing.Point(449, 503);
            this.MFPrgbarFileCreation.Name = "MFPrgbarFileCreation";
            this.MFPrgbarFileCreation.Size = new System.Drawing.Size(514, 15);
            this.MFPrgbarFileCreation.TabIndex = 56;
            this.MFPrgbarFileCreation.Visible = false;
            // 
            // MFChkOverrideFiles
            // 
            this.MFChkOverrideFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MFChkOverrideFiles.AutoSize = true;
            this.MFChkOverrideFiles.Location = new System.Drawing.Point(149, 499);
            this.MFChkOverrideFiles.Name = "MFChkOverrideFiles";
            this.MFChkOverrideFiles.Size = new System.Drawing.Size(293, 15);
            this.MFChkOverrideFiles.TabIndex = 55;
            this.MFChkOverrideFiles.Text = "Sobreescribir Archivos Existentes Automaticamente";
            this.MFChkOverrideFiles.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(6, 464);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 15);
            this.metroLabel3.TabIndex = 54;
            this.metroLabel3.Text = "Directorio DataManager";
            // 
            // TxtDataManagerDirectory
            // 
            this.TxtDataManagerDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtDataManagerDirectory.CustomButton.Image = global::SysWork.EntityManager.Properties.Resources.Search18dpWhite;
            this.TxtDataManagerDirectory.CustomButton.Location = new System.Drawing.Point(792, 2);
            this.TxtDataManagerDirectory.CustomButton.Name = "";
            this.TxtDataManagerDirectory.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtDataManagerDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDataManagerDirectory.CustomButton.TabIndex = 1;
            this.TxtDataManagerDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtDataManagerDirectory.CustomButton.UseSelectable = true;
            this.TxtDataManagerDirectory.Lines = new string[0];
            this.TxtDataManagerDirectory.Location = new System.Drawing.Point(138, 459);
            this.TxtDataManagerDirectory.MaxLength = 32767;
            this.TxtDataManagerDirectory.Name = "TxtDataManagerDirectory";
            this.TxtDataManagerDirectory.PasswordChar = '\0';
            this.TxtDataManagerDirectory.PromptText = "..\\Data\\";
            this.TxtDataManagerDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDataManagerDirectory.SelectedText = "";
            this.TxtDataManagerDirectory.SelectionLength = 0;
            this.TxtDataManagerDirectory.SelectionStart = 0;
            this.TxtDataManagerDirectory.ShortcutsEnabled = true;
            this.TxtDataManagerDirectory.ShowButton = true;
            this.TxtDataManagerDirectory.Size = new System.Drawing.Size(812, 22);
            this.TxtDataManagerDirectory.TabIndex = 23;
            this.TxtDataManagerDirectory.UseSelectable = true;
            this.TxtDataManagerDirectory.WaterMark = "..\\Data\\";
            this.TxtDataManagerDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDataManagerDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDataManagerDirectory.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtDataManagerDirectory_ButtonClick);
            this.TxtDataManagerDirectory.EnabledChanged += new System.EventHandler(this.TxtDataManagerDirectory_EnabledChanged);
            this.TxtDataManagerDirectory.Validating += new System.ComponentModel.CancelEventHandler(this.TxtDataManagerDirectory_Validating);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(6, 437);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(121, 15);
            this.metroLabel2.TabIndex = 51;
            this.metroLabel2.Text = "Directorio Repositories";
            // 
            // TxtRepositoriesDirectory
            // 
            this.TxtRepositoriesDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtRepositoriesDirectory.CustomButton.Image = global::SysWork.EntityManager.Properties.Resources.Search18dpWhite;
            this.TxtRepositoriesDirectory.CustomButton.Location = new System.Drawing.Point(792, 2);
            this.TxtRepositoriesDirectory.CustomButton.Name = "";
            this.TxtRepositoriesDirectory.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtRepositoriesDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtRepositoriesDirectory.CustomButton.TabIndex = 1;
            this.TxtRepositoriesDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtRepositoriesDirectory.CustomButton.UseSelectable = true;
            this.TxtRepositoriesDirectory.Lines = new string[0];
            this.TxtRepositoriesDirectory.Location = new System.Drawing.Point(138, 432);
            this.TxtRepositoriesDirectory.MaxLength = 32767;
            this.TxtRepositoriesDirectory.Name = "TxtRepositoriesDirectory";
            this.TxtRepositoriesDirectory.PasswordChar = '\0';
            this.TxtRepositoriesDirectory.PromptText = "..\\Data\\Repositories";
            this.TxtRepositoriesDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtRepositoriesDirectory.SelectedText = "";
            this.TxtRepositoriesDirectory.SelectionLength = 0;
            this.TxtRepositoriesDirectory.SelectionStart = 0;
            this.TxtRepositoriesDirectory.ShortcutsEnabled = true;
            this.TxtRepositoriesDirectory.ShowButton = true;
            this.TxtRepositoriesDirectory.Size = new System.Drawing.Size(812, 22);
            this.TxtRepositoriesDirectory.TabIndex = 22;
            this.TxtRepositoriesDirectory.UseSelectable = true;
            this.TxtRepositoriesDirectory.WaterMark = "..\\Data\\Repositories";
            this.TxtRepositoriesDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtRepositoriesDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtRepositoriesDirectory.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtRepositoriesDirectory_ButtonClick);
            this.TxtRepositoriesDirectory.EnabledChanged += new System.EventHandler(this.TxtRepositoriesDirectory_EnabledChanged);
            this.TxtRepositoriesDirectory.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRepositoriesDirectory_Validating);
            // 
            // MetroProgressbarObj
            // 
            this.MetroProgressbarObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroProgressbarObj.Location = new System.Drawing.Point(685, 369);
            this.MetroProgressbarObj.Name = "MetroProgressbarObj";
            this.MetroProgressbarObj.Size = new System.Drawing.Size(123, 15);
            this.MetroProgressbarObj.TabIndex = 48;
            this.MetroProgressbarObj.Visible = false;
            // 
            // ChkCreatePartialClass
            // 
            this.ChkCreatePartialClass.AutoSize = true;
            this.ChkCreatePartialClass.Checked = true;
            this.ChkCreatePartialClass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCreatePartialClass.Location = new System.Drawing.Point(10, 52);
            this.ChkCreatePartialClass.Name = "ChkCreatePartialClass";
            this.ChkCreatePartialClass.Size = new System.Drawing.Size(122, 15);
            this.ChkCreatePartialClass.TabIndex = 8;
            this.ChkCreatePartialClass.Text = "Crear &Partial Classs";
            this.ChkCreatePartialClass.UseSelectable = true;
            // 
            // ChkExcludeSysObjects
            // 
            this.ChkExcludeSysObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChkExcludeSysObjects.AutoSize = true;
            this.ChkExcludeSysObjects.Checked = true;
            this.ChkExcludeSysObjects.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkExcludeSysObjects.Location = new System.Drawing.Point(361, 368);
            this.ChkExcludeSysObjects.Name = "ChkExcludeSysObjects";
            this.ChkExcludeSysObjects.Size = new System.Drawing.Size(190, 15);
            this.ChkExcludeSysObjects.TabIndex = 46;
            this.ChkExcludeSysObjects.Text = "Excluir Objetos del sistema (sys)";
            this.ChkExcludeSysObjects.UseSelectable = true;
            // 
            // lblObChecked
            // 
            this.lblObChecked.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblObChecked.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblObChecked.Location = new System.Drawing.Point(813, 364);
            this.lblObChecked.Name = "lblObChecked";
            this.lblObChecked.Size = new System.Drawing.Size(155, 19);
            this.lblObChecked.TabIndex = 45;
            this.lblObChecked.Text = ".";
            // 
            // GrpDataManagerStyle
            // 
            this.GrpDataManagerStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDataManagerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpDataManagerStyle.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Full;
            this.GrpDataManagerStyle.Controls.Add(this.RbtnDbContext);
            this.GrpDataManagerStyle.Controls.Add(this.RbtnInstantiable);
            this.GrpDataManagerStyle.Controls.Add(this.ChkUseLazyLoad);
            this.GrpDataManagerStyle.Controls.Add(this.RbtnSingleton);
            this.GrpDataManagerStyle.Controls.Add(this.RbtnSingletonPublicProperties);
            this.GrpDataManagerStyle.DrawBottomLine = false;
            this.GrpDataManagerStyle.DrawShadows = false;
            this.GrpDataManagerStyle.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrpDataManagerStyle.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.GrpDataManagerStyle.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.GrpDataManagerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GrpDataManagerStyle.Location = new System.Drawing.Point(463, 10);
            this.GrpDataManagerStyle.Name = "GrpDataManagerStyle";
            this.GrpDataManagerStyle.PaintDefault = false;
            this.GrpDataManagerStyle.Size = new System.Drawing.Size(502, 70);
            this.GrpDataManagerStyle.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrpDataManagerStyle.StyleManager = this.MetroStyleManager1;
            this.GrpDataManagerStyle.TabIndex = 43;
            this.GrpDataManagerStyle.TabStop = false;
            this.GrpDataManagerStyle.Text = "Estilo";
            this.GrpDataManagerStyle.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrpDataManagerStyle.UseStyleColors = false;
            this.GrpDataManagerStyle.Visible = false;
            // 
            // RbtnDbContext
            // 
            this.RbtnDbContext.AutoSize = true;
            this.RbtnDbContext.Location = new System.Drawing.Point(17, 21);
            this.RbtnDbContext.Name = "RbtnDbContext";
            this.RbtnDbContext.Size = new System.Drawing.Size(79, 15);
            this.RbtnDbContext.TabIndex = 13;
            this.RbtnDbContext.Text = "DbContext";
            this.RbtnDbContext.UseSelectable = true;
            // 
            // RbtnInstantiable
            // 
            this.RbtnInstantiable.AutoSize = true;
            this.RbtnInstantiable.Checked = true;
            this.RbtnInstantiable.Location = new System.Drawing.Point(120, 21);
            this.RbtnInstantiable.Name = "RbtnInstantiable";
            this.RbtnInstantiable.Size = new System.Drawing.Size(86, 15);
            this.RbtnInstantiable.TabIndex = 9;
            this.RbtnInstantiable.TabStop = true;
            this.RbtnInstantiable.Text = "Instanciable";
            this.RbtnInstantiable.UseSelectable = true;
            this.RbtnInstantiable.CheckedChanged += new System.EventHandler(this.RbtnDatamanagerStyle_CheckedChanged);
            // 
            // ChkUseLazyLoad
            // 
            this.ChkUseLazyLoad.AutoSize = true;
            this.ChkUseLazyLoad.Location = new System.Drawing.Point(18, 42);
            this.ChkUseLazyLoad.Name = "ChkUseLazyLoad";
            this.ChkUseLazyLoad.Size = new System.Drawing.Size(218, 15);
            this.ChkUseLazyLoad.TabIndex = 12;
            this.ChkUseLazyLoad.Text = "Usar Lazy Load (Para los repositorios)";
            this.ChkUseLazyLoad.UseSelectable = true;
            // 
            // RbtnSingleton
            // 
            this.RbtnSingleton.AutoSize = true;
            this.RbtnSingleton.Location = new System.Drawing.Point(216, 21);
            this.RbtnSingleton.Name = "RbtnSingleton";
            this.RbtnSingleton.Size = new System.Drawing.Size(73, 15);
            this.RbtnSingleton.TabIndex = 10;
            this.RbtnSingleton.Text = "Singleton";
            this.RbtnSingleton.UseSelectable = true;
            this.RbtnSingleton.CheckedChanged += new System.EventHandler(this.RbtnDatamanagerStyle_CheckedChanged);
            // 
            // RbtnSingletonPublicProperties
            // 
            this.RbtnSingletonPublicProperties.AutoSize = true;
            this.RbtnSingletonPublicProperties.Location = new System.Drawing.Point(295, 21);
            this.RbtnSingletonPublicProperties.Name = "RbtnSingletonPublicProperties";
            this.RbtnSingletonPublicProperties.Size = new System.Drawing.Size(173, 15);
            this.RbtnSingletonPublicProperties.TabIndex = 11;
            this.RbtnSingletonPublicProperties.Text = "Singleton (Public Properties)";
            this.RbtnSingletonPublicProperties.UseSelectable = true;
            this.RbtnSingletonPublicProperties.CheckedChanged += new System.EventHandler(this.RbtnDatamanagerStyle_CheckedChanged);
            // 
            // MetroStyleManager1
            // 
            this.MetroStyleManager1.Owner = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label6.Location = new System.Drawing.Point(138, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Singularizador";
            // 
            // GrpSingularizator
            // 
            this.GrpSingularizator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpSingularizator.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Full;
            this.GrpSingularizator.Controls.Add(this.RbtnSingularizatorNone);
            this.GrpSingularizator.Controls.Add(this.BtnRefreshSingularizator);
            this.GrpSingularizator.Controls.Add(this.RbtnSingularizatorInternal);
            this.GrpSingularizator.Controls.Add(this.RbtnSingularizatorHumanizer);
            this.GrpSingularizator.DrawBottomLine = false;
            this.GrpSingularizator.DrawShadows = false;
            this.GrpSingularizator.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrpSingularizator.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.GrpSingularizator.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.GrpSingularizator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GrpSingularizator.Location = new System.Drawing.Point(222, 117);
            this.GrpSingularizator.Name = "GrpSingularizator";
            this.GrpSingularizator.PaintDefault = false;
            this.GrpSingularizator.Size = new System.Drawing.Size(350, 35);
            this.GrpSingularizator.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrpSingularizator.StyleManager = this.MetroStyleManager1;
            this.GrpSingularizator.TabIndex = 40;
            this.GrpSingularizator.TabStop = false;
            this.GrpSingularizator.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrpSingularizator.UseStyleColors = false;
            // 
            // RbtnSingularizatorNone
            // 
            this.RbtnSingularizatorNone.AutoSize = true;
            this.RbtnSingularizatorNone.Checked = true;
            this.RbtnSingularizatorNone.Location = new System.Drawing.Point(6, 11);
            this.RbtnSingularizatorNone.Name = "RbtnSingularizatorNone";
            this.RbtnSingularizatorNone.Size = new System.Drawing.Size(70, 15);
            this.RbtnSingularizatorNone.TabIndex = 16;
            this.RbtnSingularizatorNone.TabStop = true;
            this.RbtnSingularizatorNone.Text = "&Ninguno";
            this.RbtnSingularizatorNone.UseSelectable = true;
            // 
            // BtnRefreshSingularizator
            // 
            this.BtnRefreshSingularizator.Location = new System.Drawing.Point(323, 11);
            this.BtnRefreshSingularizator.Name = "BtnRefreshSingularizator";
            this.BtnRefreshSingularizator.Size = new System.Drawing.Size(21, 21);
            this.BtnRefreshSingularizator.TabIndex = 19;
            this.BtnRefreshSingularizator.Text = ".";
            this.BtnRefreshSingularizator.UseSelectable = true;
            this.BtnRefreshSingularizator.Click += new System.EventHandler(this.BtnRefreshSingularizator_Click);
            // 
            // RbtnSingularizatorInternal
            // 
            this.RbtnSingularizatorInternal.AutoSize = true;
            this.RbtnSingularizatorInternal.Location = new System.Drawing.Point(88, 11);
            this.RbtnSingularizatorInternal.Name = "RbtnSingularizatorInternal";
            this.RbtnSingularizatorInternal.Size = new System.Drawing.Size(139, 15);
            this.RbtnSingularizatorInternal.TabIndex = 17;
            this.RbtnSingularizatorInternal.Text = "Interno (Solo Español)";
            this.RbtnSingularizatorInternal.UseSelectable = true;
            // 
            // RbtnSingularizatorHumanizer
            // 
            this.RbtnSingularizatorHumanizer.AutoSize = true;
            this.RbtnSingularizatorHumanizer.Location = new System.Drawing.Point(236, 11);
            this.RbtnSingularizatorHumanizer.Name = "RbtnSingularizatorHumanizer";
            this.RbtnSingularizatorHumanizer.Size = new System.Drawing.Size(81, 15);
            this.RbtnSingularizatorHumanizer.TabIndex = 18;
            this.RbtnSingularizatorHumanizer.Text = "Humanizer";
            this.RbtnSingularizatorHumanizer.UseSelectable = true;
            // 
            // ChkCreateDataManager
            // 
            this.ChkCreateDataManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkCreateDataManager.AutoSize = true;
            this.ChkCreateDataManager.Location = new System.Drawing.Point(313, 17);
            this.ChkCreateDataManager.Name = "ChkCreateDataManager";
            this.ChkCreateDataManager.Size = new System.Drawing.Size(134, 15);
            this.ChkCreateDataManager.TabIndex = 7;
            this.ChkCreateDataManager.Text = "Genera &DataManager";
            this.ChkCreateDataManager.UseSelectable = true;
            this.ChkCreateDataManager.CheckedChanged += new System.EventHandler(this.ChkCreateDataManager_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label5.Location = new System.Drawing.Point(6, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Directorio Entities";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label1.Location = new System.Drawing.Point(712, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "&Buscar";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtSearch.CustomButton.Image = global::SysWork.EntityManager.Properties.Resources.Search18dpWhite;
            this.TxtSearch.CustomButton.Location = new System.Drawing.Point(183, 2);
            this.TxtSearch.CustomButton.Name = "";
            this.TxtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSearch.CustomButton.TabIndex = 1;
            this.TxtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtSearch.CustomButton.UseSelectable = true;
            this.TxtSearch.IconRight = true;
            this.TxtSearch.Lines = new string[0];
            this.TxtSearch.Location = new System.Drawing.Point(756, 128);
            this.TxtSearch.MaxLength = 32767;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.ShortcutsEnabled = true;
            this.TxtSearch.ShowButton = true;
            this.TxtSearch.Size = new System.Drawing.Size(207, 26);
            this.TxtSearch.TabIndex = 20;
            this.TxtSearch.UseSelectable = true;
            this.TxtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // TxtEntitiesDirectory
            // 
            this.TxtEntitiesDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtEntitiesDirectory.CustomButton.Image = global::SysWork.EntityManager.Properties.Resources.Search18dpWhite;
            this.TxtEntitiesDirectory.CustomButton.Location = new System.Drawing.Point(792, 2);
            this.TxtEntitiesDirectory.CustomButton.Name = "";
            this.TxtEntitiesDirectory.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtEntitiesDirectory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEntitiesDirectory.CustomButton.TabIndex = 1;
            this.TxtEntitiesDirectory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtEntitiesDirectory.CustomButton.UseSelectable = true;
            this.TxtEntitiesDirectory.Lines = new string[0];
            this.TxtEntitiesDirectory.Location = new System.Drawing.Point(138, 404);
            this.TxtEntitiesDirectory.MaxLength = 32767;
            this.TxtEntitiesDirectory.Name = "TxtEntitiesDirectory";
            this.TxtEntitiesDirectory.PasswordChar = '\0';
            this.TxtEntitiesDirectory.PromptText = "..\\Data\\Entities";
            this.TxtEntitiesDirectory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEntitiesDirectory.SelectedText = "";
            this.TxtEntitiesDirectory.SelectionLength = 0;
            this.TxtEntitiesDirectory.SelectionStart = 0;
            this.TxtEntitiesDirectory.ShortcutsEnabled = true;
            this.TxtEntitiesDirectory.ShowButton = true;
            this.TxtEntitiesDirectory.Size = new System.Drawing.Size(812, 22);
            this.TxtEntitiesDirectory.TabIndex = 21;
            this.TxtEntitiesDirectory.UseSelectable = true;
            this.TxtEntitiesDirectory.WaterMark = "..\\Data\\Entities";
            this.TxtEntitiesDirectory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEntitiesDirectory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtEntitiesDirectory.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtEntitiesDirectory_ButtonClick);
            this.TxtEntitiesDirectory.EnabledChanged += new System.EventHandler(this.TxtEntitiesDirectory_EnabledChanged);
            this.TxtEntitiesDirectory.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEntitiesDirectory_Validating);
            // 
            // ChkViews
            // 
            this.ChkViews.AutoSize = true;
            this.ChkViews.Location = new System.Drawing.Point(79, 137);
            this.ChkViews.Name = "ChkViews";
            this.ChkViews.Size = new System.Drawing.Size(53, 15);
            this.ChkViews.TabIndex = 15;
            this.ChkViews.Text = "&Views";
            this.ChkViews.UseSelectable = true;
            this.ChkViews.CheckedChanged += new System.EventHandler(this.ChkViews_CheckedChanged);
            // 
            // ChkTables
            // 
            this.ChkTables.AutoSize = true;
            this.ChkTables.Location = new System.Drawing.Point(15, 137);
            this.ChkTables.Name = "ChkTables";
            this.ChkTables.Size = new System.Drawing.Size(56, 15);
            this.ChkTables.TabIndex = 14;
            this.ChkTables.Text = "&Tablas";
            this.ChkTables.UseSelectable = true;
            this.ChkTables.CheckedChanged += new System.EventHandler(this.ChkTables_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Namespace";
            // 
            // ChkCreateRepository
            // 
            this.ChkCreateRepository.AutoSize = true;
            this.ChkCreateRepository.Location = new System.Drawing.Point(105, 17);
            this.ChkCreateRepository.Name = "ChkCreateRepository";
            this.ChkCreateRepository.Size = new System.Drawing.Size(202, 15);
            this.ChkCreateRepository.TabIndex = 6;
            this.ChkCreateRepository.Text = "Genera &Repository / ViewManager";
            this.ChkCreateRepository.UseSelectable = true;
            this.ChkCreateRepository.CheckedChanged += new System.EventHandler(this.ChkCreateRepository_CheckedChanged);
            // 
            // ChkCreateEntity
            // 
            this.ChkCreateEntity.AutoSize = true;
            this.ChkCreateEntity.Location = new System.Drawing.Point(10, 17);
            this.ChkCreateEntity.Name = "ChkCreateEntity";
            this.ChkCreateEntity.Size = new System.Drawing.Size(93, 15);
            this.ChkCreateEntity.TabIndex = 5;
            this.ChkCreateEntity.Text = "Genera &Entity";
            this.ChkCreateEntity.UseSelectable = true;
            this.ChkCreateEntity.CheckedChanged += new System.EventHandler(this.ChkCreateEntity_CheckedChanged);
            // 
            // TxtNamespace
            // 
            this.TxtNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtNamespace.CustomButton.Image = null;
            this.TxtNamespace.CustomButton.Location = new System.Drawing.Point(838, 2);
            this.TxtNamespace.CustomButton.Name = "";
            this.TxtNamespace.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtNamespace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNamespace.CustomButton.TabIndex = 1;
            this.TxtNamespace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNamespace.CustomButton.UseSelectable = true;
            this.TxtNamespace.CustomButton.Visible = false;
            this.TxtNamespace.Lines = new string[0];
            this.TxtNamespace.Location = new System.Drawing.Point(86, 89);
            this.TxtNamespace.MaxLength = 32767;
            this.TxtNamespace.Name = "TxtNamespace";
            this.TxtNamespace.PasswordChar = '\0';
            this.TxtNamespace.PromptText = "Ingrese el nombre del Namespace predeterminado(se añadirá .Entities y .Repositori" +
    "es en caso que Entidades y  Repositorios)";
            this.TxtNamespace.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNamespace.SelectedText = "";
            this.TxtNamespace.SelectionLength = 0;
            this.TxtNamespace.SelectionStart = 0;
            this.TxtNamespace.ShortcutsEnabled = true;
            this.TxtNamespace.Size = new System.Drawing.Size(858, 22);
            this.TxtNamespace.TabIndex = 13;
            this.TxtNamespace.UseSelectable = true;
            this.TxtNamespace.WaterMark = "Ingrese el nombre del Namespace predeterminado(se añadirá .Entities y .Repositori" +
    "es en caso que Entidades y  Repositorios)";
            this.TxtNamespace.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNamespace.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtNamespace.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNamespace_Validating);
            // 
            // Namespace
            // 
            this.Namespace.AutoSize = true;
            this.Namespace.Location = new System.Drawing.Point(12, 21);
            this.Namespace.Name = "Namespace";
            this.Namespace.Size = new System.Drawing.Size(0, 0);
            this.Namespace.TabIndex = 14;
            // 
            // BtnCreateFiles
            // 
            this.BtnCreateFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCreateFiles.Location = new System.Drawing.Point(8, 496);
            this.BtnCreateFiles.Name = "BtnCreateFiles";
            this.BtnCreateFiles.Size = new System.Drawing.Size(135, 22);
            this.BtnCreateFiles.TabIndex = 24;
            this.BtnCreateFiles.Text = "&Generar Archivos";
            this.BtnCreateFiles.UseSelectable = true;
            this.BtnCreateFiles.Click += new System.EventHandler(this.BtnCreateFiles_Click);
            // 
            // BtnCopyClipboard
            // 
            this.BtnCopyClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCopyClipboard.Location = new System.Drawing.Point(8, 482);
            this.BtnCopyClipboard.Name = "BtnCopyClipboard";
            this.BtnCopyClipboard.Size = new System.Drawing.Size(135, 22);
            this.BtnCopyClipboard.TabIndex = 13;
            this.BtnCopyClipboard.Text = "Copiar al &Portapapeles";
            this.BtnCopyClipboard.UseSelectable = true;
            this.BtnCopyClipboard.Visible = false;
            this.BtnCopyClipboard.Click += new System.EventHandler(this.BtnCopyClipboard_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.metroScrollBar1);
            this.metroPanel1.Controls.Add(this.LstObjects);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(15, 403);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(960, 198);
            this.metroPanel1.TabIndex = 97;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroScrollBar1
            // 
            this.metroScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroScrollBar1.HighlightOnWheel = true;
            this.metroScrollBar1.LargeChange = 10;
            this.metroScrollBar1.Location = new System.Drawing.Point(938, 31);
            this.metroScrollBar1.Maximum = 101;
            this.metroScrollBar1.Minimum = 0;
            this.metroScrollBar1.MouseWheelBarPartitions = 10;
            this.metroScrollBar1.Name = "metroScrollBar1";
            this.metroScrollBar1.Orientation = MetroFramework.Controls.MetroScrollOrientation.Vertical;
            this.metroScrollBar1.ScrollbarSize = 17;
            this.metroScrollBar1.Size = new System.Drawing.Size(17, 160);
            this.metroScrollBar1.TabIndex = 4;
            this.metroScrollBar1.UseBarColor = true;
            this.metroScrollBar1.UseSelectable = true;
            // 
            // LstObjects
            // 
            this.LstObjects.AlternateRowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LstObjects.AlternateRowColorEnabled = true;
            this.LstObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstObjects.AutoSizeLastColumn = true;
            this.LstObjects.CheckBoxes = true;
            this.LstObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColType,
            this.ColObjectName,
            this.ColEntityName,
            this.ColPublicPropertyName});
            this.LstObjects.EnableDragDrop = false;
            this.LstObjects.EnableHeaderGlow = false;
            this.LstObjects.EnableHeaderHotTrack = false;
            this.LstObjects.EnableHeaderRendering = true;
            this.LstObjects.EnableSelectionBorder = false;
            this.LstObjects.EnableSorting = true;
            this.LstObjects.EnableVistaCheckBoxes = false;
            this.LstObjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LstObjects.FontSize = MetroFramework.MetroListViewSize.Medium;
            this.LstObjects.FontWeight = MetroFramework.MetroListViewWeight.Regular;
            this.LstObjects.ForceLeftAlign = false;
            this.LstObjects.FullRowSelect = true;
            this.LstObjects.HideSelection = false;
            this.LstObjects.ItemHeight = 0;
            this.LstObjects.LineAfter = -1;
            this.LstObjects.LineBefore = -1;
            this.LstObjects.Location = new System.Drawing.Point(0, 5);
            this.LstObjects.Name = "LstObjects";
            this.LstObjects.OwnerDraw = true;
            this.LstObjects.SelectEntireRowOnSubItem = true;
            this.LstObjects.Size = new System.Drawing.Size(957, 188);
            this.LstObjects.Style = MetroFramework.MetroColorStyle.Blue;
            this.LstObjects.StyleManager = this.MetroStyleManager1;
            this.LstObjects.TabIndex = 20;
            this.LstObjects.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LstObjects.UseCustomBackColor = false;
            this.LstObjects.UseCustomForeColor = false;
            this.LstObjects.UseSelectable = false;
            this.LstObjects.UseStyleColors = false;
            this.LstObjects.View = System.Windows.Forms.View.Details;
            this.LstObjects.VScrollbar = this.metroScrollBar1;
            this.LstObjects.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LstObjects_ColumnClick);
            this.LstObjects.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.LstObjects_ItemChecked);
            // 
            // ColType
            // 
            this.ColType.Text = "Tipo";
            this.ColType.Width = 70;
            // 
            // ColObjectName
            // 
            this.ColObjectName.Text = "Nombre";
            this.ColObjectName.Width = 150;
            // 
            // ColEntityName
            // 
            this.ColEntityName.Text = "Nombre Entidad";
            this.ColEntityName.Width = 150;
            // 
            // ColPublicPropertyName
            // 
            this.ColPublicPropertyName.Text = "Nombre propiedad publica DataManager";
            this.ColPublicPropertyName.Width = 250;
            // 
            // GrpDBParameters
            // 
            this.GrpDBParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpDBParameters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpDBParameters.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Full;
            this.GrpDBParameters.Controls.Add(this.BtnUnconnect);
            this.GrpDBParameters.Controls.Add(this.BtnConnect);
            this.GrpDBParameters.Controls.Add(this.TxtConnectionString);
            this.GrpDBParameters.Controls.Add(this.CmbDataBaseEngine);
            this.GrpDBParameters.Controls.Add(this.label3);
            this.GrpDBParameters.Controls.Add(this.label4);
            this.GrpDBParameters.DrawBottomLine = false;
            this.GrpDBParameters.DrawShadows = false;
            this.GrpDBParameters.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrpDBParameters.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.GrpDBParameters.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.GrpDBParameters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GrpDBParameters.Location = new System.Drawing.Point(7, 121);
            this.GrpDBParameters.Name = "GrpDBParameters";
            this.GrpDBParameters.PaintDefault = false;
            this.GrpDBParameters.Size = new System.Drawing.Size(974, 117);
            this.GrpDBParameters.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrpDBParameters.StyleManager = this.MetroStyleManager1;
            this.GrpDBParameters.TabIndex = 93;
            this.GrpDBParameters.TabStop = false;
            this.GrpDBParameters.Text = "DB Parameters";
            this.GrpDBParameters.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrpDBParameters.UseStyleColors = false;
            // 
            // BtnUnconnect
            // 
            this.BtnUnconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnUnconnect.Location = new System.Drawing.Point(553, 86);
            this.BtnUnconnect.Name = "BtnUnconnect";
            this.BtnUnconnect.Size = new System.Drawing.Size(129, 21);
            this.BtnUnconnect.TabIndex = 4;
            this.BtnUnconnect.Text = "&Desconectar";
            this.BtnUnconnect.UseSelectable = true;
            this.BtnUnconnect.Click += new System.EventHandler(this.BtnUnconnect_Click);
            // 
            // BtnConnect
            // 
            this.BtnConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnConnect.Location = new System.Drawing.Point(368, 86);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(129, 21);
            this.BtnConnect.TabIndex = 3;
            this.BtnConnect.Text = "&Conectar";
            this.BtnConnect.UseSelectable = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // TxtConnectionString
            // 
            this.TxtConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtConnectionString.CustomButton.Image = global::SysWork.EntityManager.Properties.Resources.Configuracion24dp;
            this.TxtConnectionString.CustomButton.Location = new System.Drawing.Point(800, 2);
            this.TxtConnectionString.CustomButton.Name = "";
            this.TxtConnectionString.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.TxtConnectionString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtConnectionString.CustomButton.TabIndex = 1;
            this.TxtConnectionString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtConnectionString.CustomButton.UseSelectable = true;
            this.TxtConnectionString.Lines = new string[0];
            this.TxtConnectionString.Location = new System.Drawing.Point(124, 49);
            this.TxtConnectionString.MaxLength = 32767;
            this.TxtConnectionString.Name = "TxtConnectionString";
            this.TxtConnectionString.PasswordChar = '\0';
            this.TxtConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtConnectionString.SelectedText = "";
            this.TxtConnectionString.SelectionLength = 0;
            this.TxtConnectionString.SelectionStart = 0;
            this.TxtConnectionString.ShortcutsEnabled = true;
            this.TxtConnectionString.ShowButton = true;
            this.TxtConnectionString.Size = new System.Drawing.Size(820, 22);
            this.TxtConnectionString.TabIndex = 2;
            this.TxtConnectionString.UseSelectable = true;
            this.TxtConnectionString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtConnectionString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtConnectionString.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.TxtConnectionString_ButtonClick);
            this.TxtConnectionString.Click += new System.EventHandler(this.TxtConnectionString_Click);
            this.TxtConnectionString.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConnectionString_Validating);
            // 
            // CmbDataBaseEngine
            // 
            this.CmbDataBaseEngine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbDataBaseEngine.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CmbDataBaseEngine.FormattingEnabled = true;
            this.CmbDataBaseEngine.ItemHeight = 19;
            this.CmbDataBaseEngine.Location = new System.Drawing.Point(124, 19);
            this.CmbDataBaseEngine.Name = "CmbDataBaseEngine";
            this.CmbDataBaseEngine.Size = new System.Drawing.Size(820, 25);
            this.CmbDataBaseEngine.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.CmbDataBaseEngine, "Motor de la base de datos");
            this.CmbDataBaseEngine.UseSelectable = true;
            this.CmbDataBaseEngine.SelectedValueChanged += new System.EventHandler(this.CmbDataBaseEngine_SelectedValueChanged);
            this.CmbDataBaseEngine.Validating += new System.ComponentModel.CancelEventHandler(this.CmbDataBaseEngine_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label3.Location = new System.Drawing.Point(8, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ConnectionString";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Base Engine";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // GrpProfiles
            // 
            this.GrpProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpProfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrpProfiles.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Full;
            this.GrpProfiles.Controls.Add(this.MetroToolbarCRUDSmall1);
            this.GrpProfiles.Controls.Add(this.metroLabel1);
            this.GrpProfiles.Controls.Add(this.CmbProfiles);
            this.GrpProfiles.DrawBottomLine = false;
            this.GrpProfiles.DrawShadows = false;
            this.GrpProfiles.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrpProfiles.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.GrpProfiles.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.GrpProfiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GrpProfiles.Location = new System.Drawing.Point(7, 63);
            this.GrpProfiles.Name = "GrpProfiles";
            this.GrpProfiles.PaintDefault = false;
            this.GrpProfiles.Size = new System.Drawing.Size(974, 52);
            this.GrpProfiles.Style = MetroFramework.MetroColorStyle.Blue;
            this.GrpProfiles.StyleManager = this.MetroStyleManager1;
            this.GrpProfiles.TabIndex = 94;
            this.GrpProfiles.TabStop = false;
            this.GrpProfiles.Text = "Perfil";
            this.GrpProfiles.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GrpProfiles.UseStyleColors = false;
            // 
            // MetroToolbarCRUDSmall1
            // 
            this.MetroToolbarCRUDSmall1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MetroToolbarCRUDSmall1.BackColor = System.Drawing.Color.White;
            this.MetroToolbarCRUDSmall1.DeleteEnabled = true;
            this.MetroToolbarCRUDSmall1.DeleteToolTipText = "Eliminar";
            this.MetroToolbarCRUDSmall1.DeleteVisible = true;
            this.MetroToolbarCRUDSmall1.ExitEnabled = true;
            this.MetroToolbarCRUDSmall1.ExitToolTipText = "Salir (ESC)";
            this.MetroToolbarCRUDSmall1.ExitVisible = false;
            this.MetroToolbarCRUDSmall1.ImportExportEnabled = true;
            this.MetroToolbarCRUDSmall1.ImportExportToolTipText = "Importar / Exportar";
            this.MetroToolbarCRUDSmall1.ImportExportVisible = false;
            this.MetroToolbarCRUDSmall1.InitializeEnabled = true;
            this.MetroToolbarCRUDSmall1.InitializeToolTipText = "Inicializar Formulario (ESC)";
            this.MetroToolbarCRUDSmall1.InitializeVisible = false;
            this.MetroToolbarCRUDSmall1.Location = new System.Drawing.Point(890, 17);
            this.MetroToolbarCRUDSmall1.Margin = new System.Windows.Forms.Padding(0);
            this.MetroToolbarCRUDSmall1.Name = "MetroToolbarCRUDSmall1";
            this.MetroToolbarCRUDSmall1.NewEnabled = true;
            this.MetroToolbarCRUDSmall1.NewToolTipText = "Nuevo (F3)";
            this.MetroToolbarCRUDSmall1.NewVisible = false;
            this.MetroToolbarCRUDSmall1.RefreshEnabled = true;
            this.MetroToolbarCRUDSmall1.RefreshToolTipText = "Refresh";
            this.MetroToolbarCRUDSmall1.RefreshVisible = true;
            this.MetroToolbarCRUDSmall1.ReportEnabled = true;
            this.MetroToolbarCRUDSmall1.ReportToolTipText = "Reporte (F4)";
            this.MetroToolbarCRUDSmall1.ReportVisible = false;
            this.MetroToolbarCRUDSmall1.SaveEnabled = true;
            this.MetroToolbarCRUDSmall1.SaveToolTipText = "Grabar";
            this.MetroToolbarCRUDSmall1.SaveVisible = true;
            this.MetroToolbarCRUDSmall1.SearchEnabled = true;
            this.MetroToolbarCRUDSmall1.SearchToolTipText = "Buscar (F5)";
            this.MetroToolbarCRUDSmall1.SearchVisible = false;
            this.MetroToolbarCRUDSmall1.Size = new System.Drawing.Size(75, 22);
            this.MetroToolbarCRUDSmall1.TabIndex = 8;
            this.MetroToolbarCRUDSmall1.Theme = SysWork.MetroControls.MetroToolbars.DisplaySettingsTheme.Light;
            this.MetroToolbarCRUDSmall1.ActionSelected += new SysWork.MetroControls.MetroToolbars.MetroToolbarCRUDSmall.MetroToolbarCRUDClickEventHandler(this.MetroToolbarCRUDSmall_ActionSelected);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(11, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 15);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Nombre Perfil";
            // 
            // CmbProfiles
            // 
            this.CmbProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.CmbProfiles.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CmbProfiles.FormattingEnabled = true;
            this.CmbProfiles.ItemHeight = 19;
            this.CmbProfiles.Location = new System.Drawing.Point(124, 19);
            this.CmbProfiles.Name = "CmbProfiles";
            this.CmbProfiles.PromptText = "Introduzca un nombre de perfil existente para consultarlo, o uno nuevo para crear" +
    "lo";
            this.CmbProfiles.Size = new System.Drawing.Size(739, 25);
            this.CmbProfiles.TabIndex = 0;
            this.CmbProfiles.UseSelectable = true;
            this.CmbProfiles.SelectedValueChanged += new System.EventHandler(this.CmbProfile_SelectedValueChanged);
            this.CmbProfiles.Validating += new System.ComponentModel.CancelEventHandler(this.CmbProfiles_Validating);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // MetroRendererManager1
            // 
            this.MetroRendererManager1.Renderers = MetroFramework.Components.Renderer.MetroRenderer;
            this.MetroRendererManager1.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroRendererManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "Selección de nuevo elemento";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(301, 4);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(304, 27);
            this.miniToolStrip.Stretch = true;
            this.miniToolStrip.TabIndex = 44;
            // 
            // metroToolbarDisplaySettings1
            // 
            this.metroToolbarDisplaySettings1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroToolbarDisplaySettings1.AutoSize = true;
            this.metroToolbarDisplaySettings1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroToolbarDisplaySettings1.BackColor = System.Drawing.Color.White;
            this.metroToolbarDisplaySettings1.ChangeStyleEnabled = true;
            this.metroToolbarDisplaySettings1.ChangeStyleVisible = true;
            this.metroToolbarDisplaySettings1.ChangeThemeEnabled = true;
            this.metroToolbarDisplaySettings1.ChangeThemeVisible = true;
            this.metroToolbarDisplaySettings1.Location = new System.Drawing.Point(922, 31);
            this.metroToolbarDisplaySettings1.Margin = new System.Windows.Forms.Padding(0);
            this.metroToolbarDisplaySettings1.Name = "metroToolbarDisplaySettings1";
            this.metroToolbarDisplaySettings1.Size = new System.Drawing.Size(58, 29);
            this.metroToolbarDisplaySettings1.Style = SysWork.MetroControls.MetroToolbars.DisplaySettingsStyle.Black;
            this.metroToolbarDisplaySettings1.TabIndex = 95;
            this.metroToolbarDisplaySettings1.Theme = SysWork.MetroControls.MetroToolbars.DisplaySettingsTheme.Light;
            this.metroToolbarDisplaySettings1.SettingsChanged += new SysWork.MetroControls.MetroToolbars.MetroToolbarDisplaySettings.MetroToolbarDisplaySettingsChangeEventHandler(this.MetroToolbarDisplaySettings_SettingsChanged);
            // 
            // FrmEntityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 782);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroToolbarDisplaySettings1);
            this.Controls.Add(this.GrpProfiles);
            this.Controls.Add(this.GrpDBParameters);
            this.Controls.Add(this.GrpDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEntityManager";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "SYSWORK  Entity Manager V 3.0 ";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.FrmEntityManager_Load);
            this.Shown += new System.EventHandler(this.FrmEntityManager_Shown);
            this.GrpDetails.ResumeLayout(false);
            this.GrpDetails.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ToolStripSelectUnselect.ResumeLayout(false);
            this.ToolStripSelectUnselect.PerformLayout();
            this.GrpDataManagerStyle.ResumeLayout(false);
            this.GrpDataManagerStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroStyleManager1)).EndInit();
            this.GrpSingularizator.ResumeLayout(false);
            this.GrpSingularizator.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.GrpDBParameters.ResumeLayout(false);
            this.GrpDBParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.GrpProfiles.ResumeLayout(false);
            this.GrpProfiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGroupBox GrpDetails;
        private MetroFramework.Controls.MetroButton BtnCopyClipboard;
        private MetroFramework.Controls.MetroButton BtnCreateFiles;
        private MetroFramework.Controls.MetroTextBox TxtNamespace;
        private MetroFramework.Controls.MetroLabel Namespace;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroCheckBox ChkCreateRepository;
        private MetroFramework.Controls.MetroCheckBox ChkCreateEntity;
        private MetroFramework.Controls.MetroGroupBox GrpDBParameters;
        private MetroFramework.Controls.MetroButton BtnUnconnect;
        private MetroFramework.Controls.MetroButton BtnConnect;
        private MetroFramework.Controls.MetroTextBox TxtConnectionString;
        private MetroFramework.Controls.MetroComboBox CmbDataBaseEngine;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroFramework.Controls.MetroCheckBox ChkViews;
        private MetroFramework.Controls.MetroCheckBox ChkTables;
        private MetroFramework.Controls.MetroTextBox TxtEntitiesDirectory;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroTextBox TxtSearch;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroGroupBox GrpProfiles;
        private MetroFramework.Controls.MetroComboBox CmbProfiles;
        private MetroFramework.Controls.MetroCheckBox ChkCreateDataManager;
        private MetroFramework.Controls.MetroGroupBox GrpSingularizator;
        private MetroFramework.Controls.MetroRadioButton RbtnSingularizatorHumanizer;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroRadioButton RbtnSingularizatorInternal;
        private MetroFramework.Controls.MetroGroupBox GrpDataManagerStyle;
        private MetroFramework.Controls.MetroRadioButton RbtnInstantiable;
        private MetroFramework.Controls.MetroCheckBox ChkUseLazyLoad;
        private MetroFramework.Controls.MetroRadioButton RbtnSingleton;
        private MetroFramework.Controls.MetroRadioButton RbtnSingletonPublicProperties;
        private MetroFramework.Controls.MetroButton BtnRefreshSingularizator;
        private MetroFramework.Controls.MetroLabel lblObChecked;
        private MetroFramework.Controls.MetroCheckBox ChkExcludeSysObjects;
        private MetroFramework.Controls.MetroCheckBox ChkCreatePartialClass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroProgressBar MetroProgressbarObj;
        private MetroControls.MetroToolbars.MetroToolbarDisplaySettings metroToolbarDisplaySettings1;
        private MetroFramework.Components.MetroRendererManager MetroRendererManager1;
        private MetroFramework.Components.MetroStyleManager MetroStyleManager1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView LstObjects;
        private System.Windows.Forms.ColumnHeader ColType;
        private System.Windows.Forms.ColumnHeader ColObjectName;
        private System.Windows.Forms.ColumnHeader ColEntityName;
        private System.Windows.Forms.ColumnHeader ColPublicPropertyName;
        private MetroFramework.Controls.MetroScrollBar metroScrollBar1;
        private MetroFramework.Controls.MetroToolStrip miniToolStrip;
        private MetroFramework.Controls.MetroRadioButton RbtnSingularizatorNone;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtDataManagerDirectory;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TxtRepositoriesDirectory;
        private MetroControls.MetroToolbars.MetroToolbarCRUDSmall MetroToolbarCRUDSmall1;
        private MetroFramework.Controls.MetroCheckBox MFChkOverrideFiles;
        private MetroFramework.Controls.MetroProgressBar MFPrgbarFileCreation;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.ToolStrip ToolStripSelectUnselect;
        private System.Windows.Forms.ToolStripButton ToolStripBtnSelectAll;
        private System.Windows.Forms.ToolStripSplitButton ToolStripBtnSelectAll_DD;
        private System.Windows.Forms.ToolStripMenuItem SelectTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectViewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton ToolStripBtnUnselectAll;
        private System.Windows.Forms.ToolStripSplitButton ToolStripBtnUnselectAll_DD;
        private System.Windows.Forms.ToolStripMenuItem UnselectTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnselectViewsToolStripMenuItem;
        private MetroFramework.Controls.MetroRadioButton RbtnDbContext;
    }
}

