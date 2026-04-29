using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "GM_V_MV_PLANILLA_CAB")]
	public partial class GM_V_MV_PLANILLA_CAB
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column()]
		public string ID_PLANILLA { get; set; }
		[Column()]
		public DateTime FECHA_PLANILLA { get; set; }
		[Column()]
		public string IDVENDEDOR { get; set; }
		[Column()]
		public DateTime FECHA { get; set; }
		[Column()]
		public DateTime? FECHA_ENTREGA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long? CLASEPRECIO { get; set; }
		[Column()]
		public double? DESCUENTO { get; set; }
		[Column()]
		public string IDCLIENTE { get; set; }
		[Column()]
		public long? ITEMS { get; set; }
		[Column()]
		public decimal IMPORTE_S_IVA { get; set; }
		[Column()]
		public decimal? IMPORTE_TOTAL { get; set; }
		[Column()]
		public bool CONTROLADO { get; set; }
	}
}
