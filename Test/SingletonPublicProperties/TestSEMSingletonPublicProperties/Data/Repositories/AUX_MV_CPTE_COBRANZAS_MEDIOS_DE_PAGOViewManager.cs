using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Common;
using SysWork.Data.GenericViewManager;
using SysWork.Data.Mapping;
using SysWork.Data.Common.ValueObjects;
using SysWork.SWCG.Test.Entities;
namespace SysWork.SWCG.Test.ViewManagers
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

	public partial class AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager : BaseViewManager<AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGO>
	{
		public AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGOViewManager (string connectionString, EDatabaseEngine databaseEngine) : base(connectionString,databaseEngine)
		{
		
		}

	}
}
