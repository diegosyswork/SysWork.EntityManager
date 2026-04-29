using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "V_AsientosCCosto")]
	public partial class V_AsientosCCosto
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CCOSTO { get; set; }
		[Column()]
		public string PERIODO { get; set; }
		[Column()]
		public long MES_OPERATIVO { get; set; }
		[Column( Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public long SECUENCIA { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public double? PORCENTAJE { get; set; }
		[Column()]
		public string Tipo_Reg { get; set; }
		[Column()]
		public decimal Importe { get; set; }
		[Column()]
		public DateTime? Fecha { get; set; }
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
		[Column()]
		public string MONEDA { get; set; }
		[Column()]
		public decimal? COTIZACION { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
		[Column()]
		public bool EsResumen { get; set; }
		[Column()]
		public bool ES_SALDO_APERTURA { get; set; }
		[Column()]
		public string IdBanco { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public long? Clearing { get; set; }
		[Column()]
		public string OrdenDeCompra { get; set; }
		[Column()]
		public bool ChPropio { get; set; }
		[Column()]
		public string CuentaOrigen { get; set; }
		[Column()]
		public DateTime? FechaSubdiario { get; set; }
		[Column()]
		public string NroComprobanteBancario { get; set; }
		[Column()]
		public double? TJ_Liquidacion { get; set; }
		[Column()]
		public long? ID_COTIZ { get; set; }
	}
}
