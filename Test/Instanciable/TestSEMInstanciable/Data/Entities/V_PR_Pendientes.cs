using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "V_PR_Pendientes")]
	public partial class V_PR_Pendientes
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
		public long? IDCOMPLEMENTO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public DateTime? FECHAESTINICIO { get; set; }
		[Column()]
		public DateTime? FECHAESTFIN { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string MATRICULA { get; set; }
		[Column()]
		public string MODELO { get; set; }
		[Column()]
		public string SERIE { get; set; }
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
		public long? CLASEPRECIO { get; set; }
		[Column()]
		public string COMENTARIOS { get; set; }
		[Column()]
		public string IDTECNICO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public string SOLICITANTE { get; set; }
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
		public bool FINALIZADA { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public bool APROBADO { get; set; }
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
		public string IdLista { get; set; }
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
		public DateTime? FechaFinalizacion { get; set; }
		[Column()]
		public bool Complementario { get; set; }
		[Column()]
		public bool Impreso { get; set; }
		[Column()]
		public double? Devoluciones { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IdMotivoStock { get; set; }
		[Column()]
		public long? ID { get; set; }
	}
}
