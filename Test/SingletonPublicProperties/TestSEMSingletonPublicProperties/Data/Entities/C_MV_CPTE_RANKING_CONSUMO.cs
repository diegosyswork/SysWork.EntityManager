using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "C_MV_CPTE_RANKING_CONSUMO")]
	public partial class C_MV_CPTE_RANKING_CONSUMO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
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
		public string COMENTARIOS { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public string TCORIGEN { get; set; }
		[Column()]
		public string COMPROBANTEORIGEN { get; set; }
		[Column()]
		public long? COMPLEMENTOORIGEN { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public string IDMOTIVOCPRAVTA { get; set; }
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
		public bool ExentoIVAServicios { get; set; }
		[Column()]
		public bool ExentoIVAArticulos { get; set; }
		[Column()]
		public bool ExentoIVAOtros { get; set; }
		[Column()]
		public string IdLista { get; set; }
		[Column()]
		public long? ClasePrecio { get; set; }
		[Column()]
		public double? PorcDescuento1 { get; set; }
		[Column()]
		public double? PorcDescuento2 { get; set; }
		[Column()]
		public double? PorcDescuento3 { get; set; }
		[Column()]
		public double? PorcDescuento4 { get; set; }
		[Column()]
		public double? PorcDescuento5 { get; set; }
		[Column()]
		public decimal? ImpDescuento1 { get; set; }
		[Column()]
		public decimal? ImpDescuento2 { get; set; }
		[Column()]
		public decimal? ImpDescuento3 { get; set; }
		[Column()]
		public decimal? ImpDescuento4 { get; set; }
		[Column()]
		public decimal? ImpDescuento5 { get; set; }
		[Column()]
		public decimal? ImporteIva2 { get; set; }
		[Column()]
		public double? AlicIva { get; set; }
		[Column()]
		public double? AlicIvaRec { get; set; }
		[Column()]
		public double? AlicIva2 { get; set; }
		[Column()]
		public DateTime? FechaSubdiario { get; set; }
		[Column()]
		public bool Garantia { get; set; }
		[Column()]
		public bool Aprobado { get; set; }
		[Column()]
		public bool Core { get; set; }
		[Column()]
		public bool Finalizado { get; set; }
		[Column()]
		public DateTime? FechaEntrega { get; set; }
		[Column()]
		public double? AlicIva3 { get; set; }
		[Column()]
		public double? AlicIva4 { get; set; }
		[Column()]
		public decimal? ImpIva3 { get; set; }
		[Column()]
		public decimal? ImpIva4 { get; set; }
		[Column()]
		public string USUARIO_LOGUEADO { get; set; }
		[Column()]
		public string RETGAN_IdRetencion { get; set; }
		[Column()]
		public string RETIBR_IdRetencion { get; set; }
		[Column()]
		public string RETIVA_IdRetencion { get; set; }
		[Column()]
		public decimal? RETGAN_BaseImponible { get; set; }
		[Column()]
		public decimal? RETIBR_BaseImponible { get; set; }
		[Column()]
		public decimal? RETIVA_BaseImponible { get; set; }
		[Column()]
		public decimal? RETGAN_Importe { get; set; }
		[Column()]
		public decimal? RETIBR_Importe { get; set; }
		[Column()]
		public decimal? RETIVA_Importe { get; set; }
		[Column()]
		public string IDCENTRODECOSTO { get; set; }
		[Column()]
		public string IDDEPOSITO { get; set; }
		[Column()]
		public string IDSUCURSAL { get; set; }
		[Column()]
		public string COMENTARIOS_OC { get; set; }
		[Column()]
		public string MONEDA { get; set; }
		[Column()]
		public long? ID_COTIZ { get; set; }
		[Column()]
		public decimal? COTIZACION { get; set; }
		[Column()]
		public long? RETGAN_Nro { get; set; }
		[Column()]
		public long? RETIBR_Nro { get; set; }
		[Column()]
		public long? RETIVA_Nro { get; set; }
		[Column()]
		public DateTime? fechahora_grabacion { get; set; }
		[Column()]
		public string OC_MonedaPrecios { get; set; }
		[Column()]
		public string OC_FormaDePago { get; set; }
		[Column()]
		public string OC_FechaDeEntrega { get; set; }
		[Column()]
		public string OC_LugarEntrega { get; set; }
		[Column()]
		public string OC_ComentariosAdic { get; set; }
		[Column()]
		public string OC_Revision { get; set; }
		[Column()]
		public string RETIBR_IdRetencion2 { get; set; }
		[Column()]
		public decimal? RETIBR_BaseImponible2 { get; set; }
		[Column()]
		public decimal? RETIBR_Importe2 { get; set; }
		[Column()]
		public long? RETIBR_Nro2 { get; set; }
	}
}
