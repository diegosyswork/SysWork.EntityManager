using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VE_CPTES_IMPAGOS")]
	public partial class VE_CPTES_IMPAGOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
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
		public DateTime? VENCIMIENTO { get; set; }
		[Column()]
		public string CABNOMBRE { get; set; }
		[Column()]
		public string TipoVista { get; set; }
		[Column()]
		public string CuentaPrincipal { get; set; }
		[Column()]
		public decimal PAGO { get; set; }
		[Column()]
		public decimal? SALDO { get; set; }
		[Column()]
		public bool EsResumen { get; set; }
		[Column()]
		public bool EsCierre { get; set; }
		[Column()]
		public bool ES_SALDO_APERTURA { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long ID { get; set; }
	}
}
