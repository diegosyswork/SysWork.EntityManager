using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VT_MV_CUOTAS_IMPAGAS")]
	public partial class VT_MV_CUOTAS_IMPAGAS
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
		public string TC_ORIGEN { get; set; }
		[Column()]
		public string IDCOMPROBANTE_ORIGEN { get; set; }
		[Column()]
		public long NRO_CUOTA { get; set; }
		[Column()]
		public DateTime FECHA_VTO_CUOTA { get; set; }
		[Column()]
		public decimal IMPORTE_CUOTA { get; set; }
		[Column()]
		public string TC_PAGO { get; set; }
		[Column()]
		public string IDCOMPROBANTE_PAGO { get; set; }
		[Column()]
		public decimal? IMPORTE_PAGADO { get; set; }
		[Column()]
		public DateTime? FechaDePago { get; set; }
		[Column()]
		public long IDCUOTA { get; set; }
	}
}
