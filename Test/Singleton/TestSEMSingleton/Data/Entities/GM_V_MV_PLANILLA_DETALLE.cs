using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "GM_V_MV_PLANILLA_DETALLE")]
	public partial class GM_V_MV_PLANILLA_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long ITEM { get; set; }
		[Column()]
		public string IDCLIENTE { get; set; }
		[Column()]
		public DateTime FECHA { get; set; }
		[Column()]
		public DateTime FECHA_ENTREGA { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string IDTAREA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public double? DESCUENTO { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
		[Column()]
		public long? HORAS { get; set; }
		[Column()]
		public decimal? PRECIO { get; set; }
		[Column()]
		public decimal? PRECIO_S_IVA { get; set; }
		[Column()]
		public decimal? IMPORTE_IVA { get; set; }
		[Column()]
		public decimal? IMPORTE_IMP_INT { get; set; }
		[Column()]
		public decimal? TOTAL { get; set; }
		[Column()]
		public string DESCRIPCION_ADIC { get; set; }
		[Column()]
		public bool CONTROLADO { get; set; }
	}
}
