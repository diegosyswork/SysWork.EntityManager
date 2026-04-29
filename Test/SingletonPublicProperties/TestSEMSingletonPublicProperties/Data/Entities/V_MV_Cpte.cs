using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MV_Cpte")]
	public partial class V_MV_Cpte
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDCOMPROBANTE { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IDCOMPLEMENTO { get; set; }
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
		public decimal? ImporteIva2 { get; set; }
		[Column()]
		public double? AlicIva { get; set; }
		[Column()]
		public double? AlicIvaRec { get; set; }
		[Column()]
		public double? AlicIva2 { get; set; }
		[Column()]
		public long? PorcRecargo { get; set; }
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
		public double? PorcDescuento4 { get; set; }
		[Column()]
		public decimal? ImpDescuento4 { get; set; }
		[Column()]
		public double? AlicIVA3 { get; set; }
		[Column()]
		public decimal? ImpIVA3 { get; set; }
		[Column()]
		public double? AlicIVA4 { get; set; }
		[Column()]
		public decimal? ImpIVA4 { get; set; }
		[Column()]
		public string NroComprobanteAsociado { get; set; }
		[Column()]
		public long? Anticipo { get; set; }
		[Column()]
		public decimal? ImpAnticipo { get; set; }
		[Column()]
		public string NroAnticipo { get; set; }
		[Column()]
		public DateTime? fechahora_grabacion { get; set; }
		[Column()]
		public DateTime? fechahora_modificacion { get; set; }
		[Column()]
		public string IDZONA { get; set; }
		[Column()]
		public string IDCHOFER { get; set; }
		[Column()]
		public string IDVEHICULO { get; set; }
		[Column()]
		public string USUARIO_LOGUEADO { get; set; }
		[Column()]
		public string IDMOTIVOANULACION { get; set; }
		[Column()]
		public string MONEDA { get; set; }
		[Column()]
		public string LUGAR_ENTREGA { get; set; }
		[Column()]
		public string TRANSPORTE { get; set; }
		[Column()]
		public DateTime? HORARIO_SALIDA { get; set; }
		[Column()]
		public DateTime? HORARIO_LLEGADA { get; set; }
		[Column()]
		public string CERTIFICADO_SANITARIO { get; set; }
		[Column()]
		public string DESC_NROS_SERIE_LOTE { get; set; }
		[Column()]
		public long? IdPlanillaMovil { get; set; }
		[Column()]
		public DateTime? FechaPlanillaMovil { get; set; }
		[Column()]
		public string TC_A_GENERAR { get; set; }
		[Column()]
		public string DESC_IDGARANTIAS { get; set; }
		[Column()]
		public long? ID_COTIZ { get; set; }
		[Column()]
		public decimal? COTIZACION { get; set; }
		[Column()]
		public bool REQUIERE_PREPARACION { get; set; }
		[Column()]
		public DateTime? PREPARACION_FECHA_HORA { get; set; }
		[Column()]
		public string PREPARACION_OBSERVACIONES { get; set; }
		[Column()]
		public bool PREPARACION_ENTREGA_DOMICILIO { get; set; }
		[Column()]
		public long? PREPARACION_PRIORIDAD { get; set; }
		[Column()]
		public DateTime? PREPARACION_FH_FIN { get; set; }
		[Column()]
		public string PREPARACION_PREPARADO_POR_VDOR { get; set; }
		[Column()]
		public string PREPARACION_PREPARADO_POR_USR { get; set; }
		[Column()]
		public bool REQUIERE_ARMADO { get; set; }
		[Column()]
		public DateTime? ARMADO_FECHA_HORA { get; set; }
		[Column()]
		public string ARMADO_OBSERVACIONES { get; set; }
		[Column()]
		public long? ARMADO_PRIORIDAD { get; set; }
		[Column()]
		public DateTime? ARMADO_FH_FIN { get; set; }
		[Column()]
		public string ARMADO_POR_VDOR { get; set; }
		[Column()]
		public string ARMADO_POR_USR { get; set; }
		[Column()]
		public DateTime? ENTREGA_DOM_FECHA { get; set; }
		[Column()]
		public string ENTREGA_DOM_RANGOHORARIO { get; set; }
		[Column()]
		public long? ENTREGA_DOM_PRIORIDAD { get; set; }
		[Column()]
		public string ENTREGA_DOM_OBSERVACIONES { get; set; }
		[Column()]
		public string NEXTEL_NroCliente { get; set; }
		[Column()]
		public string NEXTEL_CodigoAutorizacion { get; set; }
		[Column()]
		public string NEXTEL_TipoDeMovimiento { get; set; }
		[Column()]
		public string NEXTEL_PinMaestro { get; set; }
		[Column()]
		public double? PORCMDESCUENTO1 { get; set; }
		[Column()]
		public double? PORCMDESCUENTO2 { get; set; }
		[Column()]
		public double? PORCMDESCUENTO3 { get; set; }
		[Column()]
		public double? PORCMDESCUENTO4 { get; set; }
		[Column()]
		public double? PORCMDESCUENTO5 { get; set; }
		[Column()]
		public decimal? IMPORTEMDESCUENTO1 { get; set; }
		[Column()]
		public decimal? IMPORTEMDESCUENTO2 { get; set; }
		[Column()]
		public decimal? IMPORTEMDESCUENTO3 { get; set; }
		[Column()]
		public decimal? IMPORTEMDESCUENTO4 { get; set; }
		[Column()]
		public decimal? IMPORTEMDESCUENTO5 { get; set; }
		[Column()]
		public long? SUCURSALCUENTA { get; set; }
		[Column()]
		public double? PESO_COMPROBANTE { get; set; }
		[Column()]
		public string IDESTADO_CRM { get; set; }
		[Column()]
		public string ENTREGA_DOM_DIRECCION_ENTREGA { get; set; }
		[Column()]
		public string ENTREGA_DOM_LOCALIDAD_ENTREGA { get; set; }
		[Column()]
		public decimal? ENTREGA_DOM_COSTO_FLETE { get; set; }
		[Column()]
		public string ENTREGA_DOM_COSTO_FLETE_OBSERVACIONES { get; set; }
		[Column()]
		public string ENTREGA_DOM_CONTACTO { get; set; }
		[Column()]
		public string ENTREGA_DOM_TELEFONOS_CONTACTO { get; set; }
		[Column()]
		public string ENTREGA_DOM_USR { get; set; }
		[Column()]
		public string IDEXPRESO { get; set; }
		[Column()]
		public string CAE { get; set; }
		[Column()]
		public string CAE_VTO { get; set; }
		[Column()]
		public string COD_BARRA_FACT_ELECTRONICA { get; set; }
		[Column()]
		public decimal? PERCEPCION_ELEGIBLE_Importe { get; set; }
		[Column()]
		public string CBU_EMISOR { get; set; }
		[Column()]
		public string CBU_ALIAS_EMISOR { get; set; }
		[Column()]
		public string SISTEMA_TRANSMISION_MIPYME { get; set; }
	}
}
