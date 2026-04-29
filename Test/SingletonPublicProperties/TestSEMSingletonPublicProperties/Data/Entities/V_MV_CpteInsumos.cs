using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MV_CpteInsumos")]
	public partial class V_MV_CpteInsumos
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
		public long IDCOMPLEMENTO { get; set; }
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
		public string IdLista { get; set; }
		[Column()]
		public Int16? CLASEPRECIO { get; set; }
		[Column()]
		public string NRO_SERIE { get; set; }
		[Column()]
		public string NRO_LOTE { get; set; }
		[Column()]
		public string TipoLista { get; set; }
		[Column()]
		public double? PorcDto { get; set; }
		[Column()]
		public decimal? ImporteDto { get; set; }
		[Column()]
		public string IdCaja { get; set; }
		[Column()]
		public double? AlicIva { get; set; }
		[Column()]
		public decimal? IMPORTE_C_IVA { get; set; }
		[Column()]
		public string IDDEPOSITO { get; set; }
		[Column()]
		public string COMENTARIOS { get; set; }
		[Column()]
		public string CATEGORIA { get; set; }
		[Column()]
		public string TROPA { get; set; }
		[Column()]
		public string GARRON { get; set; }
		[Column()]
		public string CANTIDADUMAux { get; set; }
		[Column()]
		public string IDMONEDA { get; set; }
		[Column()]
		public string IDMOTIVORMA { get; set; }
		[Column()]
		public string IDCOMPROBANTEORIGEN { get; set; }
		[Column()]
		public DateTime? FECHA_ESTADO_RMA { get; set; }
		[Column()]
		public string IDESTADORMA { get; set; }
		[Column()]
		public string IDGARANTIA { get; set; }
		[Column()]
		public string DescripcionAdicional { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA_MONEDA1 { get; set; }
		[Column()]
		public string RMA_PROVEEDOR_ASIGNADO { get; set; }
		[Column()]
		public double? PESO { get; set; }
		[Column()]
		public string NRO_TROPA { get; set; }
	}
}
