using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CUENTASADIC")]
	public partial class MA_CUENTASADIC
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string CONTACTO { get; set; }
		[Column()]
		public string CALLE { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string PISO { get; set; }
		[Column()]
		public string DEPARTAMENTO { get; set; }
		[Column()]
		public string CPOSTAL { get; set; }
		[Column()]
		public string LOCALIDAD { get; set; }
		[Column()]
		public string PROVINCIA { get; set; }
		[Column()]
		public string PAIS { get; set; }
		[Column()]
		public string TELEFONO { get; set; }
		[Column()]
		public string FAX { get; set; }
		[Column()]
		public string MAIL { get; set; }
		[Column()]
		public string DOCUMENTO_TIPO { get; set; }
		[Column()]
		public string NUMERO_DOCUMENTO { get; set; }
		[Column()]
		public string IVA { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public decimal? Limite_Credito { get; set; }
		[Column()]
		public string idCond_Cpra_Vta { get; set; }
		[Column()]
		public string IDCategoria { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public string IdLista { get; set; }
		[Column()]
		public Int16? Clase { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string IdMotivoVta { get; set; }
		[Column()]
		public string IdMotivoCpra { get; set; }
		[Column()]
		public bool ExentoIvaServicios { get; set; }
		[Column()]
		public bool ExentoIvaArticulos { get; set; }
		[Column()]
		public bool ExentoIVAOtros { get; set; }
		[Column()]
		public double? Descuento { get; set; }
		[Column()]
		public string RETIVA_IdRetencion { get; set; }
		[Column()]
		public string RETIBR_IdRetencion { get; set; }
		[Column()]
		public string RETGAN_IdRetencion { get; set; }
		[Column()]
		public string LugarEntrega { get; set; }
		[Column()]
		public string CALLE_FIS { get; set; }
		[Column()]
		public string NUMERO_FIS { get; set; }
		[Column()]
		public string PISO_FIS { get; set; }
		[Column()]
		public string DEPARTAMENTO_FIS { get; set; }
		[Column()]
		public string CPOSTAL_FIS { get; set; }
		[Column()]
		public string LOCALIDAD_FIS { get; set; }
		[Column()]
		public string PROVINCIA_FIS { get; set; }
		[Column()]
		public string PAIS_FIS { get; set; }
		[Column()]
		public string TELEFONO_FIS { get; set; }
		[Column()]
		public string FAX_FIS { get; set; }
		[Column()]
		public string IDZONA { get; set; }
		[Column()]
		public long? RUTEO { get; set; }
		[Column()]
		public string web { get; set; }
		[Column()]
		public string CODIGOOPCIONAL { get; set; }
		[Column()]
		public string COMPROBANTEPREDETERMINADO_COMPRAS { get; set; }
		[Column()]
		public string COMPROBANTEPREDETERMINADO_VENTAS { get; set; }
		[Column()]
		public DateTime? FECHA_NACIMIENTO { get; set; }
		[Column()]
		public string HABILITACION_BEB_ALC { get; set; }
		[Column()]
		public bool HABILITADO_MODULO_WEB { get; set; }
		[Column()]
		public string USUARIO_WEB { get; set; }
		[Column()]
		public string PASS_WEB { get; set; }
		[Column()]
		public bool WEB_CONSULTA_SALDO { get; set; }
		[Column()]
		public bool WEB_CONSULTA_PRECIOS { get; set; }
		[Column()]
		public bool WEB_REALIZA_PEDIDOS { get; set; }
		[Column()]
		public bool WEB_CONSULTA_ESTADOS { get; set; }
		[Column()]
		public DateTime? FECHA_ALTA { get; set; }
		[Column()]
		public DateTime? FECHA_BAJA { get; set; }
		[Column()]
		public string IDMOTIVOBAJA { get; set; }
		[Column()]
		public decimal? MontoMinimoClasePrecio { get; set; }
		[Column()]
		public bool GM_CLIENTECOMPARTIDO { get; set; }
		[Column()]
		public bool PARTICIPA_EN_FIDELIZACION { get; set; }
		[Column()]
		public string NRO_TJ_FIDELIZACION { get; set; }
		[Column()]
		public string SIAP_IVA_REG_RET_PERC { get; set; }
		[Column()]
		public bool EXENTO_PERCEPCION_IIBB { get; set; }
		[Column()]
		public string CERT_EXCENCION_IIBB { get; set; }
		[Column()]
		public string CALIFICACION { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO_CALIFICACION { get; set; }
		[Column()]
		public bool ISO { get; set; }
		[Column()]
		public string APELLIDO { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string SEXO { get; set; }
		[Column()]
		public string LUGARNACIMIENTO { get; set; }
		[Column()]
		public string IDESTADOCIVIL { get; set; }
		[Column()]
		public string APELLIDOCONY { get; set; }
		[Column()]
		public string NOMBRECONY { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
		[Column()]
		public string ENTRE_CALLES { get; set; }
		[Column()]
		public DateTime? FECHA_ACT_DP { get; set; }
		[Column()]
		public string CM_NUMERO { get; set; }
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
		public bool INFORMAR_SALDO_EN_CARGA_CPTE { get; set; }
		[Column()]
		public DateTime? FACT_REC_DESDE { get; set; }
		[Column()]
		public DateTime? FACT_REC_HASTA { get; set; }
		[Column()]
		public string FACT_REC_SUCURSAL { get; set; }
		[Column()]
		public string IDCLASIFICACIONCREDITICIA { get; set; }
		[Column()]
		public string IDEXPRESO { get; set; }
		[Column()]
		public string MAIL_ENVIO_FACT_ELECTRONICA { get; set; }
		[Column()]
		public string IDPERCEPCION { get; set; }
		[Column()]
		public string RETIBR_IdRetencion2 { get; set; }
	}
}
