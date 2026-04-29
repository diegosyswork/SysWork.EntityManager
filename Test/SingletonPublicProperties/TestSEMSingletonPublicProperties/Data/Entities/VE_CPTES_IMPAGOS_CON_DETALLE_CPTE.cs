using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VE_CPTES_IMPAGOS_CON_DETALLE_CPTE")]
	public partial class VE_CPTES_IMPAGOS_CON_DETALLE_CPTE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
		[Column()]
		public decimal PAGO { get; set; }
		[Column()]
		public decimal? SALDO { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string IDZONA { get; set; }
		[Column()]
		public string CODIGOOPCIONAL { get; set; }
		[Column()]
		public string IDCHOFER { get; set; }
		[Column()]
		public string IDVEHICULO { get; set; }
		[Column()]
		public string RAZON_SOCIAL { get; set; }
		[Column()]
		public string Expr1 { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public bool APROBADO { get; set; }
	}
}
