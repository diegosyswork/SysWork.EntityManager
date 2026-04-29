using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "AUX_MV_CPTE_COBRANZAS_COMPROBANTES")]
	public partial class AUX_MV_CPTE_COBRANZAS_COMPROBANTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TC { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string TIPO { get; set; }
		[Column()]
		public string Seccion { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string Fecha { get; set; }
		[Column()]
		public string NroComprobante { get; set; }
		[Column()]
		public decimal? Importe { get; set; }
		[Column()]
		public decimal? Aplicado { get; set; }
		[Column()]
		public decimal? Saldo { get; set; }
	}
}
