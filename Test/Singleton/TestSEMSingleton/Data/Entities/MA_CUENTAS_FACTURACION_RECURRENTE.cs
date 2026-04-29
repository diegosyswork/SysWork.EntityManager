using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CUENTAS_FACTURACION_RECURRENTE")]
	public partial class MA_CUENTAS_FACTURACION_RECURRENTE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string IDTAREA { get; set; }
		[Column()]
		public string OBSERVACIONES_OC { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
	}
}
