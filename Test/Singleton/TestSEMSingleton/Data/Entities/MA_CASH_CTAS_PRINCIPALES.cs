using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CASH_CTAS_PRINCIPALES")]
	public partial class MA_CASH_CTAS_PRINCIPALES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO_CASH { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
	}
}
