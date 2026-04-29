using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Common;
using SysWork.Data.GenericRepository;
using SysWork.Data.Mapping;
using SysWork.Data.Common.ValueObjects;
using Test.Entities;
namespace Test.Repositories
{
	/// <summary>
	/// ********************************************************
	/// **        WARNING DO NOT EDIT THIS CLASS              **
	/// ********************************************************
	/// This class was created automatically with the SysWork Entity Manager,
	/// and will be regenerated the next time the SysWork Entity Manager is used.
	/// 
	/// Inherited from GenericRepository which allows you to perform the following actions: 
	/// Add, AddAsync, AddRange, AddRangeAsync, DeleteAll, DeleteAllAsync, DeleteByGenericWhereFilter, 
	/// DeleteByGenericWhereFilterAsync, DeleteById, DeleteByIdAsync, DeleteByIdsIN, DeleteByIdsNotIN, 
	/// DeleteByLambdaExpressionFilter, DeleteByLambdaExpressionFilterAsync, Exists, 
	/// ExistsAsync, Find, FindAsync, GetAll, GetAllAsync, GetByGenericWhereFilter, GetByGenericWhereFilterAsync, 
	/// GetById, GetByIdAsync, GetByLambdaExpressionFilter, GetByLambdaExpressionFilterAsync, 
	/// GetDataTableByGenericWhereFilter, GetDataTableByGenericWhereFilterAsync, GetDataTableByLambdaExpressionFilter, 
	/// GetDataTableByLambdaExpressionFilterAsync, GetListByGenericWhereFilter, GetListByGenericWhereFilterAsync, 
	/// GetListByLambdaExpressionFilter, GetListByLambdaExpressionFilterAsync, RecordCount, RecordCountAsync, 
	/// Update, UpdateAsync, UpdateRange, UpdateRangeAsync, 
	/// 
	/// Additionally, methods were also created for the unique keys.
	/// </summary>

	public partial class P_MV_BusquedasRepository : BaseRepository<P_MV_Busquedas>
	{
		public P_MV_BusquedasRepository (string connectionString, EDatabaseEngine databaseEngine) : base(connectionString,databaseEngine)
		{
		
		}

		public P_MV_Busquedas GetByIdBusquedaIdPostulante (long IdBusqueda,long IdPostulante)
		{
			 return GetByLambdaExpressionFilter(entity =>  (entity.IdBusqueda == IdBusqueda) && (entity.IdPostulante == IdPostulante));
		}

	}
}
