using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VT_CO_CPTE_Diferido")]
	public partial class VT_CO_CPTE_Diferido
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
		public string Sucursal { get; set; }
		[Column()]
		public string Numero { get; set; }
		[Column()]
		public string Letra { get; set; }
		[Column()]
		public long idcomplemento { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string CUENTA { get; set; }
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
		public bool Finalizado { get; set; }
		[Column()]
		public double? AlicIva3 { get; set; }
		[Column()]
		public double? AlicIva4 { get; set; }
		[Column()]
		public decimal? ImpIva3 { get; set; }
		[Column()]
		public decimal? ImpIva4 { get; set; }
		[Column()]
		public DateTime? FechaEntrega { get; set; }
	}
}
