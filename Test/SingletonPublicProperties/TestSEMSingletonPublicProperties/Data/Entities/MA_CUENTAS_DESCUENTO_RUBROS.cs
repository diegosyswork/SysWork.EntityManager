using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_CUENTAS_DESCUENTO_RUBROS")]
	public partial class MA_CUENTAS_DESCUENTO_RUBROS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDRUBRO { get; set; }
		[Column()]
		public double? PORC_DTO { get; set; }
	}
}
