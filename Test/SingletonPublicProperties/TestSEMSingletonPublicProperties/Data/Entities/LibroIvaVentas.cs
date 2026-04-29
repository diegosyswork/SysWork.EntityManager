using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "LibroIvaVentas")]
	public partial class LibroIvaVentas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? Fecha_Subdiario { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public long SECUENCIA { get; set; }
		[Column()]
		public long MES_OPERATIVO { get; set; }
		[Column( Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string DETALLE { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string MONEDA { get; set; }
		[Column()]
		public decimal? COTIZACION { get; set; }
		[Column()]
		public long? ID_COTIZ { get; set; }
		[Column()]
		public string NroComprobanteBancario { get; set; }
		[Column()]
		public string PERIODO { get; set; }
		[Column()]
		public decimal CABIMPORTE { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
		[Column()]
		public string TIPO_REG { get; set; }
		[Column()]
		public long? CONTABILIZADO { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public bool EsResumen { get; set; }
		[Column()]
		public bool ES_SALDO_APERTURA { get; set; }
		[Column()]
		public string CABCUENTA { get; set; }
		[Column()]
		public string CABNOMBRE { get; set; }
		[Column()]
		public string CABCUIT { get; set; }
		[Column()]
		public string CABCONDIVA { get; set; }
		[Column()]
		public string LIVA_TIPO { get; set; }
		[Column()]
		public decimal? LIVA_ImpNetoGrav { get; set; }
		[Column()]
		public decimal? LIVA_ImpNetoNGrav { get; set; }
		[Column()]
		public decimal? LIVA_EXENTO { get; set; }
		[Column()]
		public decimal? LIVA_AlicIVA { get; set; }
		[Column()]
		public decimal? LIVA_AlicIVAREC { get; set; }
		[Column()]
		public decimal? LIVA_ImpIVA { get; set; }
		[Column()]
		public decimal? LIVA_ImpIVARec { get; set; }
		[Column()]
		public decimal? LIVA_Ret_Perc { get; set; }
		[Column()]
		public decimal? LIVA_Ret_IBtos { get; set; }
		[Column()]
		public decimal? LIVA_Ret_Ganancias { get; set; }
		[Column()]
		public decimal? LIVA_TOTAL { get; set; }
		[Column()]
		public bool EsAjuste { get; set; }
		[Column()]
		public string Ajuste_Hasta { get; set; }
		[Column()]
		public long? Nro_Transmision { get; set; }
		[Column()]
		public string OrdenDeCompra { get; set; }
		[Column()]
		public long? Clearing { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string IdBanco { get; set; }
		[Column()]
		public bool ChPropio { get; set; }
		[Column()]
		public string TJ_NroSocio { get; set; }
		[Column()]
		public string TJ_NroCupon { get; set; }
		[Column()]
		public long? TJ_Cuotas { get; set; }
		[Column()]
		public string TJ_Autorizo { get; set; }
		[Column()]
		public string TJ_Observaciones { get; set; }
		[Column()]
		public string CuentaOrigen { get; set; }
		[Column()]
		public string CuentaDestino { get; set; }
		[Column()]
		public double LIVA_AlicIva2 { get; set; }
		[Column()]
		public decimal LIVA_ImpIva2 { get; set; }
		[Column()]
		public double LIVA_AlicIVA3 { get; set; }
		[Column()]
		public decimal LIVA_ImpIVA3 { get; set; }
		[Column()]
		public double LIVA_AlicIVA4 { get; set; }
		[Column()]
		public decimal LIVA_ImpIVA4 { get; set; }
		[Column()]
		public string USUARIO_LOGEADO { get; set; }
		[Column()]
		public bool EsCierre { get; set; }
		[Column()]
		public decimal? LIVA_PERC_IBtos { get; set; }
		[Column()]
		public string CERT_RETENCION_GANANCIAS { get; set; }
		[Column()]
		public string CERT_RETENCION_IIBB { get; set; }
		[Column()]
		public string CERT_RETENCION_IVA { get; set; }
		[Column()]
		public string CERT_RETENCION_IIBB2 { get; set; }
		[Column()]
		public decimal? LIVA_Ret_IBtos2 { get; set; }
		[Column()]
		public decimal? LIVA_PERC_IBTOSElegible { get; set; }
	}
}
