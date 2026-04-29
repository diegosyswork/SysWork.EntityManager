using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "V_RemitosPendientes")]
	public partial class V_RemitosPendientes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string TC_Facturado { get; set; }
		[Column()]
		public string IdComprobante_Facturado { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string DOMICILIO { get; set; }
		[Column()]
		public string TELEFONO { get; set; }
		[Column()]
		public string LOCALIDAD { get; set; }
		[Column()]
		public string IDPROVINCIA { get; set; }
		[Column()]
		public string CODIGOPOSTAL { get; set; }
		[Column()]
		public string DOCUMENTOTIPO { get; set; }
		[Column()]
		public string DOCUMENTONUMERO { get; set; }
		[Column()]
		public string CONDICIONIVA { get; set; }
		[Column()]
		public string IDCOND_CPRA_VTA { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public string IDMOTIVOCPRAVTA { get; set; }
		[Column()]
		public double? PorcDescuento1 { get; set; }
		[Column()]
		public decimal? ImpDescuento1 { get; set; }
		[Column()]
		public double? PorcDescuento2 { get; set; }
		[Column()]
		public decimal? ImpDescuento2 { get; set; }
		[Column()]
		public double? PorcDescuento3 { get; set; }
		[Column()]
		public decimal? ImpDescuento3 { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public decimal? ImporteInsumos { get; set; }
		[Column()]
		public decimal? ImporteServicios { get; set; }
		[Column()]
		public decimal? ImporteOtrosConceptos { get; set; }
		[Column()]
		public decimal? ImporteIva { get; set; }
		[Column()]
		public decimal? ImporteIvaRec { get; set; }
		[Column()]
		public decimal? ImporteImpuestosInternos { get; set; }
		[Column()]
		public decimal? NetoGravado { get; set; }
		[Column()]
		public decimal? NetoNoGravado { get; set; }
		[Column()]
		public double? Devoluciones { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IdMotivoStock { get; set; }
		[Column()]
		public decimal? ImporteIva2 { get; set; }
		[Column()]
		public double? AlicIva { get; set; }
		[Column()]
		public double? AlicIvaRec { get; set; }
		[Column()]
		public string SucursalRemito { get; set; }
		[Column()]
		public long? ID { get; set; }
		[Column()]
		public string IDZONA { get; set; }
		[Column()]
		public string IDCHOFER { get; set; }
		[Column()]
		public string IDVEHICULO { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public bool APROBADO { get; set; }
	}
}
