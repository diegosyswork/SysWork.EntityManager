# Lightweight and independent framework for database management. 

Supports MSSqlServer, SQLite, OleDb, MySql. 
Implement the repository pattern. 
Fast and easy to use. 
Compatible with .NetFramework4.8 and .NetCore3.1

Inheriting from GenericRepository the following methods can be used:

Add, AddAsync, AddRange, AddRangeAsync, DeleteAll, DeleteAllAsync, DeleteByGenericWhereFilter,
DeleteByGenericWhereFilterAsync, DeleteById, DeleteByIdAsync, DeleteByIdsIN, DeleteByIdsNotIN,
DeleteByLambdaExpressionFilter, DeleteByLambdaExpressionFilterAsync, Exists, ExistsAsync, Find,
FindAsync, GetAll, GetAllAsync, GetByGenericWhereFilter, GetByGenericWhereFilterAsync, GetById,
GetByIdAsync, GetByLambdaExpressionFilter, GetByLambdaExpressionFilterAsync, GetDataTableByGenericWhereFilter,
GetDataTableByGenericWhereFilterAsync, GetDataTableByLambdaExpressionFilter, GetDataTableByLambdaExpressionFilterAsync,
GetListByGenericWhereFilter, GetListByGenericWhereFilterAsync, GetListByLambdaExpressionFilter,
GetListByLambdaExpressionFilterAsync, RecordCount, RecordCountAsync, Update,
UpdateAsync, UpdateRange, UpdateRangeAsync.

***************
 Usage Example
***************
```
[Table(Name = "Persons")]
public class Person
{
	[Column(IsIdentity = true, IsPrimaryKey = true)]
	public long IdPerson { get; set; }

	[Column()]
	public string FirstName { get; set; }

	[Column()]
	public string LastName { get; set; }

	[Column()]
	public string Passport { get; set; }

	[Column()]
	public string Address { get; set; }

	[Column()]
	public long? IdState { get; set; }

	[Column()]
	public DateTime? BirthDate { get; set; }

	[Column(Name = "Long Name Field")]
	public string LongNameField { get; set; }

	[Column()]
	public bool Active { get; set; }
}

public class PersonRepository: BaseRepository<Person>
{
	public PersonRepository(string connectionString, EDatabaseEngine databaseEngine) : base(connectionString, databaseEngine)
	{
	
	}
	public Person GetByPassport(string passport)
	{
		return GetByLambdaExpressionFilter(entity => (entity.Passport == passport));
	}
	public DbExecutor GetDbExecutor()
	{
		return BaseDbExecutor();
	}
	public DbConnection GetDbConnection()
	{
		return BaseDbConnection();
	}

	// You can add custom methods..
}

public class Sample
{
	static static void Main()
	{
		var connectionString = "Data Source=.;Initial Catalog=DB;User ID=MyUser;Password=MyPass";
		var databaseEngine = EDatabaseEngine.MSSqlServer;

		var personRepository = new PersonRepository(connectionString, databaseEngine);

		// Add a Person
		var p = new Person();
		p.FirstName = "Diego";
		p.LastName = "Martinez";
		p.Passport = "AR00127296";
		p.LongNameField = "Field With Long Name";
		p.Address = "Address";
		p.BirthDate = new DateTime(1980,5,24);
		p.Active = true;

		try
		{
		 long id = personRepository.Add(p);
		 Console.WriteLine($"The generated id is{id}");
		}
		catch (RepositoryException ex)
		{
		 Console.WriteLine($"The following error has occurred{ex.Message}");
		}

		// Get a Person
		var person = personRepository.GetByLambdaExpressionFilter(p=>p.Passport.Trim() == "AR00127926")
		Console.WriteLine($"Person with passport is {person.FirstName} {Person.LastName}");
	}
}
```
************************************************************************************
You could give your repositories a context and use a DataManager. SysWork.Data has a
BaseInstantiableDataManager class. Inheriting from it you could order your code as 
follows:
************************************************************************************
```
using System;
using SysWork.Data.GenericDataManager;
using SysWork.Data.Common.ValueObjects;
using Test.SysWork.EntityManager.NetCore31.Data.Repositories;
using Test.SysWork.EntityManager.NetCore31.Data.ViewManagers;

namespace Test.SysWork.EntityManager.NetCore31.Data
{
	public partial class DbContext : BaseInstantiableDataManager
	{
		//Repositories
		private Lazy<PersonRepository> _personRepository;
		public PersonRepository Persons {get => _personRepository.Value;}

		private Lazy<StateRepository> _stateRepository;
		public StateRepository States {get => _stateRepository.Value;}


		//ViewManagers
		private Lazy<VIEWPersonsWithStatesViewManager> _viewPersonsWithStatesViewManager;
		public VIEWPersonsWithStatesViewManager VIEW_PersonsWithStates {get => _viewPersonsWithStatesViewManager.Value;}


		public DbContext(EDatabaseEngine databaseEngine, string connectionString) : base(databaseEngine, connectionString)
		{
			InitDataObjects();		
		}

		public override void InitDataObjects()
		{
			//Repositories
			_personRepository= new Lazy<PersonRepository>(()=>new PersonRepository(ConnectionString,DatabaseEngine));
			_stateRepository  = new Lazy<StateRepository>(()=>new StateRepository(ConnectionString,DatabaseEngine));

			//ViewManagers
			_viewPersonsWithStatesViewManager  = new Lazy<VIEWPersonsWithStatesViewManager>(()=>new VIEWPersonsWithStatesViewManager(ConnectionString,DatabaseEngine));
		}
	}
}
```

************************************************************************************
It also has Utilities such as a DbExecutor, which facilitates SQL executions.
************************************************************************************
```
public class Sample2
{
	static static void Main()
	{
		var connectionString = "Data Source=.;Initial Catalog=DB;User ID=MyUser;Password=MyPass";
		var databaseEngine = EDatabaseEngine.MSSqlServer;

		var recordsAffected = new DbExecutor(connectionString,databaseEngine)
			.Query("UPDATE Products SET Cost = @pCost WHERE IdProduct = @pIdProduct AND IdCategory = @pIdCategory")
			.AddParameter("@pCost",155.4)
			.AddParameter("@pIdProduct",77978788)
			.AddParameter("@pIdCategory",5)
		.ExecuteNonQuery();

		var id = new DbExecutor(connectionString,databaseEngine)
			 .InsertQuery("Products")
			 .AddFieldWithValue("IdProduct",77978788)
			 .AddFieldWithValue("Description","Product Description")
			 .AddFieldWithValue("IdCategory",5)
			 .AddFieldWithValue("Cost",155.4)
		.ExecuteScalar();

		new DbExecutor(connectionString,databaseEngine)
			 .UpdateQuery("Products"," WHERE IdCategory = @pIdCategory AND active = 0")
			 .AddFieldWithValue("Cost", 0)
			 .AddFieldWithValue("Price", 0)
			 .AddParameter("IdCategory",5)
		.ExecuteNonQuery();

		var reader = new DbExecutor(connectionString,databaseEngine)
			 .Query("SELECT Products WHERE IdCategory = @pIdCategory")
			 .AddParameter("@pIdCategory",5)
			.ExecuteReader();
		while(reader.Read())
		{
		   // do something.
		}

		var resul = new DbExecutor(connectionString,databaseEngine)
			 .Query("SELECT COUNT(*) as qty FROM Products WHERE IdCategory = @pIdCategory")
			 .AddParameter("@pIdCategory",5)
		.ExecuteScalar();
		var productCount = result; 
	 }
}
```
************************************************************************************
Utility to be able to filter, useful in the case of reports, or complex queries 
where the parameters can be informed or not.
************************************************************************************
```
public class Sample3
{
	static static void Main()
	{
		var whereFilterSelect = new GenericWhereFilter(EDatabaseEngine.MSSqlServer);

		// Sets the columns for select
		whereFilterSelect.SetColumnsForSelect<TEntity>();

		// Sets the table name (using an Generic Type)
		whereFilterSelect.SetTableOrViewName<TEntity>();

		string where = "  (BirthDate >= @pBirthDate) AND Active = @pActive";

		whereFilterSelect.SetWhere(textFilter)
		.AddParameter("@pBirthDate", new DateTime(2014, 1, 1), DbType.DateTime)
		.AddParameter("@pActive", 1, DbType.Boolean);

		var selectQueryString = whereFilterSelect.SelectQueryString;
	}
}
```

************************************************************************************
Utility to verify the existence of tables, views, columns, ConnectionStrings, etc.
************************************************************************************
```
public class Sample4
{
	 static static void Main()
	 {
		var connectionString = "Data Source=.;Initial Catalog=DB;User ID=MyUser;Password=MyPass";
		var databaseEngine = EDatabaseEngine.MSSqlServer;

		var dbUtil = new DbUtil(databaseEngin,connectionString);
		var existsPersona = dbUtil.ExistsTable("Personas");
		var existsColumn = dbUtil.ExistsColumn("Persons","Passport");		
	 }
}
```
************************************************************************************
Logging:It has its own utility for Log: DbLogger, it creates a table where it stores:

					"DateTime", "Tag", "Summary", "Details", "Method", 
                    "Class", "SQLStatement", "Parameters", "Exception", 
                    "Result", "DbUser", "OsUser", "SysUser", "Terminal", 
                    "OsVersion" 

************************************************************************************
```
public class Program
{
	static void Sample5()
	{
		// Set connectionString for logging. DbLogger is a Singleton Object.-
		DbLogger.ConnectionString = @"data source=C:\Log\log.sqlite;version=3;new=False;compress=True;pragma jounal_mode=WAL";
		DbLogger.DatabaseEngine = EDatabaseEngine.SqLite;
		DbLogger.AppUserName = "Diego Martinez";


		DbLogger.LogError(EDbErrorTag.Error, "An error has occurred");
		DbLogger.LogInfo(EDbInfoTag.Info , "something happened");
	}
}
```
