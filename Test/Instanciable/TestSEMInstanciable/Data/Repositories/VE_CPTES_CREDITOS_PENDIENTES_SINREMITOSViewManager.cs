using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Common;
using SysWork.Data.GenericViewManager;
using SysWork.Data.Mapping;
using SysWork.Data.Common.ValueObjects;
using Test.Entities;
namespace Test.ViewManagers
{
	/// <summary>
	/// This class was created automatically with the SysWork.EntityManager.
	/// Inherited from GenericRepository which allows you to perform the following actions: 
	/// GetAll, 
	/// GetAllAsyc, 
	/// GetListByLambdaExpressionFilter, 
	/// GetListByLambdaExpressionFilterAsync, 
	/// GetListByGenericWhereFilter, 
	/// GetListByGenericWhereFilterAsync, 
	/// </summary>

	public partial class VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager : BaseViewManager<VE_CPTES_CREDITOS_PENDIENTES_SINREMITOS>
	{
		public VE_CPTES_CREDITOS_PENDIENTES_SINREMITOSViewManager (string connectionString, EDatabaseEngine databaseEngine) : base(connectionString,databaseEngine)
		{
		
		}

	}
}
