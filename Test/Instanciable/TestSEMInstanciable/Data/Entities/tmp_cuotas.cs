using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "tmp_cuotas")]
	public partial class tmp_cuotas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TC_ORIGEN { get; set; }
		[Column()]
		public string IDCOMPROBANTE_ORIGEN { get; set; }
		[Column()]
		public long NRO_CUOTA { get; set; }
		[Column()]
		public decimal IMPORTE_CUOTA { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string TC_PAGO { get; set; }
		[Column()]
		public string IDCOMPROBANTE_PAGO { get; set; }
		[Column()]
		public decimal? IMPORTE_PAGADO { get; set; }
	}
}
