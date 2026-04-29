using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGO")]
	public partial class AUX_MV_CPTE_COBRANZAS_MEDIOS_DE_PAGO
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
		public string MedioDePago { get; set; }
		[Column()]
		public string NroCompronbanteBancario { get; set; }
		[Column()]
		public string DescripcionBanco { get; set; }
		[Column()]
		public string Vencimiento { get; set; }
		[Column()]
		public decimal? Importe { get; set; }
	}
}
