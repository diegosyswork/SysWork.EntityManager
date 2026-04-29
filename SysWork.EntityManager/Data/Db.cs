using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using SysWork.Data.Common.DataObjectProvider;
using SysWork.Data.Common.ValueObjects;
using SysWork.Data.GenericRepository;
using SysWork.Data.Mapping;
using SysWork.Data.Utilities;

namespace SysWork.EntityManager.Data
{
    public class Db
    {
        private readonly string _dbPath = Path.Combine(Directory.GetCurrentDirectory(), "profiles.db3");
        private readonly string _sqlConnectionStringBuilder = "Data Source = {0}; Version = 3; New ={1}; Compress = True;PRAGMA jounal_mode=WAL;PRAGMA read_uncommitted = 1;";

        private readonly ProfileRepository _profiles;
        private readonly ProfileSelectedObjectRepository _profilesSelectedObjects;
        private readonly ConfigurationRepository _configurationRepository;

        private readonly DbUtil _dbUtil;

        public Db()
        {
            _dbUtil = new DbUtil(EDatabaseEngine.SqLite,string.Format(_sqlConnectionStringBuilder, _dbPath, false));

            VerifyDb();

            _profiles = new ProfileRepository(string.Format(_sqlConnectionStringBuilder, _dbPath, false));
            _profilesSelectedObjects = new ProfileSelectedObjectRepository(string.Format(_sqlConnectionStringBuilder, _dbPath, false));
            _configurationRepository = new ConfigurationRepository(string.Format(_sqlConnectionStringBuilder, _dbPath, false));
        }

        private void VerifyDb()
        {
            var db = StaticDbObjectProvider.GetDbConnection(EDatabaseEngine.SqLite, string.Format(_sqlConnectionStringBuilder, _dbPath, !File.Exists(_dbPath)));
            try
            {
                db.Open();

                if (!_dbUtil.ExistsTable(db,"Profiles"))
                    CreateTableProfiles(db);

                if (!_dbUtil.ExistsTable(db, "ProfilesSelectedObjects"))
                    CreateTableProfilesSelectedObjects(db);
                
                if (!_dbUtil.ExistsTable(db, "Configuration"))
                    CreateTableConfiguration(db);

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (db.State == System.Data.ConnectionState.Open)
                    db.Close();

                db.Dispose();
            }
        }

        private void CreateTableConfiguration(DbConnection db)
        {
            try
            {
                _dbUtil.ExecuteBatchNonQuery(db, "CREATE TABLE [Configuration](" + Environment.NewLine +
                                  "[IdConfiguration] INTEGER," + Environment.NewLine +
                                  "[Key] TEXT NOT NULL UNIQUE," + Environment.NewLine +
                                  "[Value] TEXT NULL, " + Environment.NewLine +
                                  "PRIMARY KEY([IdConfiguration] AUTOINCREMENT));"
                            );
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CreateTableProfiles(DbConnection db)
        {
            try
            {
                _dbUtil.ExecuteBatchNonQuery(
                              db, "CREATE TABLE [Profiles](" + Environment.NewLine +
                                  "[IdProfile] INTEGER," + Environment.NewLine +
                                  "[ProfileName] TEXT NOT NULL UNIQUE," + Environment.NewLine +
                                  "[DatabaseEngine] TEXT NOT NULL," + Environment.NewLine +
                                  "[ConnectionString] TEXT NOT NULL," + Environment.NewLine +
                                  "[CreateEntity] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[CreateRepository] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[CreateDatamanager] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[DatamanagerStyle] TEXT," + Environment.NewLine +
                                  "[UseLazyLoad] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[NameSpace] TEXT," + Environment.NewLine +
                                  "[FillTables] INTEGER DEFAULT 0, " + Environment.NewLine +
                                  "[FillViews] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[Singularizator] TEXT ," + Environment.NewLine +
                                  "[EntitiesDirectory] TEXT," + Environment.NewLine +
                                  "[RepositoriesDirectory] TEXT," + Environment.NewLine +
                                  "[DataManagerDirectory] TEXT," + Environment.NewLine +
                                  "[SortColumn] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[SortOrder] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "[CreatePartialClass] INTEGER DEFAULT 0," + Environment.NewLine +
                                  "PRIMARY KEY([IdProfile] AUTOINCREMENT));"
                            );
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CreateTableProfilesSelectedObjects(DbConnection db)
        {
            try
            {
                _dbUtil.ExecuteBatchNonQuery(db, "CREATE TABLE[ProfilesSelectedObjects] (" +
                                   "[IdProfileSelectedObject]	INTEGER NOT NULL," +
                                   "[IdProfile]	INTEGER NOT NULL," +
                                   "[ObjectType]	TEXT NOT NULL," +
                                   "[ObjectName]	TEXT NOT NULL," +
                                   "[EntityName]	TEXT," +
                                   "[PublicPropertyDataManager]	TEXT," +
                                   "PRIMARY KEY([IdProfileSelectedObject]));");
                
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Profile> GetProfilesWithSelectedObjects()
        {
            var result =  _profiles.GetAll().OrderBy(p => p.ProfileName).ToList();
            foreach (var item in result)
                item.ProfileSelectedObjects.AddRange(_profilesSelectedObjects.GetByIdProfile(item.IdProfile));
            
            return result;
        }

        public Profile AddProfile(Profile profile)
        {
            DbTransaction dbTransaction = null;
            Profile result = null;

            try
            {
                using (var db = StaticDbObjectProvider.GetDbConnection(EDatabaseEngine.SqLite, string.Format(_sqlConnectionStringBuilder, _dbPath, false)))
                {
                    db.Open();
                    dbTransaction = db.BeginTransaction();
                    
                    var idProfile = _profiles.Add(profile,dbTransaction);
                    
                    profile.ProfileSelectedObjects.ForEach(p => p.IdProfile = idProfile);
                    
                    _profilesSelectedObjects.AddRange(profile.ProfileSelectedObjects,dbTransaction);
                    
                    dbTransaction.Commit();
                    db.Close();

                    result = _profiles.GetByIdWithSelectedObjects(idProfile);
                }

                return result;
            }
            catch (Exception e)
            {
                if (dbTransaction != null)
                    dbTransaction.Rollback();

                throw e;
            }
        }

        public bool UpdateProfile(Profile profile)
        {
            DbTransaction dbTransaction = null;
            try
            {
                using (var db = StaticDbObjectProvider.GetDbConnection(EDatabaseEngine.SqLite, string.Format(_sqlConnectionStringBuilder, _dbPath, false)))
                {
                    db.Open();
                    dbTransaction = db.BeginTransaction();

                    IEnumerable<object> toDelete = profile.ProfileSelectedObjects.Where(p => p.IdProfileSelectedObject > 0).ToList().Select(t=>(object) t.IdProfileSelectedObject).AsEnumerable<object>();
                        _profilesSelectedObjects.DeleteByIdsNotIN(toDelete, dbTransaction);

                    var toAdd = profile.ProfileSelectedObjects.Where(p => p.IdProfileSelectedObject == -1).ToList();
                    if (toAdd!=null)
                        _profilesSelectedObjects.AddRange(toAdd, dbTransaction);

                    var toUpdate = profile.ProfileSelectedObjects.Where(p => p.IdProfileSelectedObject > 0).ToList();
                    if(toUpdate!=null)
                        _profilesSelectedObjects.UpdateRange(toUpdate, dbTransaction);
                    
                    _profiles.Update(profile, dbTransaction);
                    
                    dbTransaction.Commit();
                    db.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DeleteProfile(Profile profile)
        {
            DbTransaction dbTransaction=null;

            try
            {
                using (var db = StaticDbObjectProvider.GetDbConnection(EDatabaseEngine.SqLite, string.Format(_sqlConnectionStringBuilder, _dbPath, false)))
                {
                    db.Open();
                    dbTransaction = db.BeginTransaction();
                    
                    _profilesSelectedObjects.DeleteByIdProfile(profile.IdProfile, dbTransaction);
                    _profiles.DeleteById(profile.IdProfile, dbTransaction);

                    dbTransaction.Commit();
                    
                    db.Close();
                }
                return true; 
            }
            catch (Exception)
            {
                if (dbTransaction!=null)
                    dbTransaction.Rollback();

                throw;
            }
        }
        public bool ExistsProfileByName(string profileName)
        {
            try
            {
                return _profiles.Table().Any(p => p.ProfileName.Trim() == profileName.Trim());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetConfiguration(string key, string defaultValue)
        {
            var result = _configurationRepository.GetConfigurationByKey(key);
            var returnValue = defaultValue;
            if (result != null)
                returnValue = result.Value.ToString();
            return returnValue;
        }
        public void SaveConfiguration(string key, string @value)
        {
            var result = _configurationRepository.GetConfigurationByKey(key);
            var insert = (result == null);

            var config = new Configuration
            {
                Key = key,
                Value = @value
            };

            if (insert)
            {
                _configurationRepository.Add(config);
            }
            else 
            {   config.IdConfiguration = result.IdConfiguration;
                _configurationRepository.Update(config);
            }
        }

        private class ProfileRepository : BaseRepository<Profile>
        {
            readonly ProfileSelectedObjectRepository _profilesSelectedObjects;
            public ProfileRepository(string connectionString) : base(connectionString, EDatabaseEngine.SqLite)
            {
                _profilesSelectedObjects = new ProfileSelectedObjectRepository(connectionString);
            }

            public Profile GetByIdWithSelectedObjects(long idProfile)
            {
                try
                {
                    Profile result = GetById(idProfile);
                    result.ProfileSelectedObjects.AddRange(_profilesSelectedObjects.GetByIdProfile(idProfile));
                    
                    return result;
                }
                catch (Exception e)
                {

                    throw e;
                }
            }
        }
                                                                       
        private class ProfileSelectedObjectRepository : BaseRepository<ProfileSelectedObject>
        {
            public ProfileSelectedObjectRepository(string connectionString) : base(connectionString, EDatabaseEngine.SqLite)
            {

            }

            public void DeleteByIdProfile(long idProfile, DbTransaction dbTransaction)
            {
                DeleteWhere(p=>p.IdProfile == idProfile,dbTransaction);
            }

            public List<ProfileSelectedObject> GetByIdProfile(long idProfile)
            {
                return GetListWhere(p=>p.IdProfile == idProfile).ToList();
            }
        }
        private class ConfigurationRepository : BaseRepository<Configuration>
        {
            public ConfigurationRepository(string connectionString) : base(connectionString, EDatabaseEngine.SqLite)
            {

            }

            public Configuration GetConfigurationByKey(string Key) 
            {
                return GetWhere(p=>p.Key == Key); 
            }
        }

    }

    [Table(Name = "Profiles")]
    public class Profile
    {
        [Column(IsIdentity = true, IsPrimaryKey =true)]
        public long IdProfile { get; set; } = -1;

        [Column]
        public string ProfileName { get; set; }

        [Column]
        public string DatabaseEngine { get; set; }

        [Column]
        public string ConnectionString { get; set; }

        [Column]
        public bool CreateEntity { get; set; }

        [Column]
        public bool CreateRepository { get; set; }

        [Column]
        public bool CreateDataManager { get; set; }

        [Column]
        public string DatamanagerStyle { get; set; }

        [Column]
        public bool UseLazyLoad { get; set; }

        [Column]
        public string Namespace { get; set; }

        [Column]
        public bool FillTables { get; set; }

        [Column]
        public bool FillViews { get; set; }

        [Column]
        public string Singularizator { get; set; }

        [Column]
        public string EntitiesDirectory { get; set; }
        [Column]
        public string RepositoriesDirectory { get; set; }
        [Column]
        public string DataManagerDirectory { get; set; }
        [Column]
        public int SortColumn { get; set; }
        [Column]
        public int SortOrder { get; set; }
        [Column]
        public bool CreatePartialClass { get; set; }

        public List<ProfileSelectedObject> ProfileSelectedObjects { get; set; }

        public Profile() 
        {
            ProfileSelectedObjects = new List<ProfileSelectedObject> ();
        }
    }

    [Table(Name = "ProfilesSelectedObjects")]
    public class ProfileSelectedObject
    {
        [Column(IsIdentity = true,IsPrimaryKey =true)]
        public long IdProfileSelectedObject { get; set; }
        [Column]
        public long IdProfile { get; set; }
        [Column]
        public string ObjectType { get; set; }
        [Column]
        public string ObjectName { get; set; }
        [Column]
        public string EntityName { get; set; }
        [Column]
        public string PublicPropertyDataManager { get; set; }

        public ProfileSelectedObject()
        {

        }
        public ProfileSelectedObject(long idProfile, string objectType, string objectName, string entityName, string publicPropertyDataManager,long idProfileSelectedObject = 0)
        {
            IdProfile = idProfile;
            ObjectType = objectType;
            ObjectName = objectName;
            EntityName = entityName;
            PublicPropertyDataManager = publicPropertyDataManager;
            IdProfileSelectedObject = idProfileSelectedObject;
        }
    }

    [Table(Name = "Configuration")]
    public class Configuration
    {
        [Column(IsIdentity = true, IsPrimaryKey = true)]
        public long IdConfiguration{ get; set; }
        [Column]
        public string Key { get; set; }
        [Column]
        public string Value { get; set; }

        public Configuration()
        {

        }
        public Configuration(string key, string @value, long IdConfiguration = 0)
        {
            this.Key = key ;
            this.Value = @value; 
            this.IdConfiguration = IdConfiguration;
        }
    }

}
