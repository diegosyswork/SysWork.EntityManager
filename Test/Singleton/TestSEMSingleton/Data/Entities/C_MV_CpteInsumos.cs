using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "C_MV_CpteInsumos")]
	public partial class C_MV_CpteInsumos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public double? CANTIDADUD { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
		[Column()]
		public decimal? COSTO { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public decimal? IMPUESTOS { get; set; }
		[Column()]
		public decimal? TOTAL { get; set; }
		[Column()]
		public bool EXENTO { get; set; }
		[Column()]
		public string NRO_SERIE { get; set; }
		[Column()]
		public string NRO_LOTE { get; set; }
		[Column()]
		public DateTime? FECHA_DMR { get; set; }
		[Column()]
		public string NROFORM_DMR { get; set; }
		[Column()]
		public string OBSERVACIONES_DMR { get; set; }
		[Column()]
		public bool EXCHANGE { get; set; }
		[Column()]
		public string IDDEPOSITO { get; set; }
		[Column()]
		public bool NO_ACTUALIZAR_COSTO { get; set; }
		[Column()]
		public decimal? PRECIOREFERENCIA { get; set; }
		[Column()]
		public string OBSERVACIONES_PRECIO_REFERENCIA { get; set; }
		[Column()]
		public double? PESO { get; set; }
		[Column()]
		public string NRO_TROPA { get; set; }
	}
}
