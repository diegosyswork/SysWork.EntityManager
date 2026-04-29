using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VE_CPTES_CREDITOS_PENDIENTES_SINREMITOS")]
	public partial class VE_CPTES_CREDITOS_PENDIENTES_SINREMITOS
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
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? APLICADO { get; set; }
		[Column()]
		public decimal? SALDO { get; set; }
		[Column( Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
	}
}
