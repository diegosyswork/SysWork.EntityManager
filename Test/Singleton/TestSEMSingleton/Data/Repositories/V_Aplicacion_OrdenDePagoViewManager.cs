using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Common;
using SysWork.Data.GenericViewManager;
using SysWork.Data.Mapping;
using SysWork.Data.Common.ValueObjects;
using SysWork.SWCG.Test.Entities.Entities;
namespace SysWork.SWCG.Test.Entities.ViewManagers
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

	public partial class V_Aplicacion_OrdenDePagoViewManager : BaseViewManager<V_Aplicacion_OrdenDePago>
	{
		public V_Aplicacion_OrdenDePagoViewManager (string connectionString, EDatabaseEngine databaseEngine) : base(connectionString,databaseEngine)
		{
		
		}

	}
}
