using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MV_CUOTAS")]
	public partial class V_MV_CUOTAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long IDCUOTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC_ORIGEN { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDCOMPROBANTE_ORIGEN { get; set; }
		[Column( IsPrimaryKey = true)]
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
	}
}
