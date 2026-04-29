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

	public partial class VT_CO_CPTE_DiferidoViewManager : BaseViewManager<VT_CO_CPTE_Diferido>
	{
		public VT_CO_CPTE_DiferidoViewManager (string connectionString, EDatabaseEngine databaseEngine) : base(connectionString,databaseEngine)
		{
		
		}

	}
}
