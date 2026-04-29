using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "AUX_MV_CPTE_COBRANZAS")]
	public partial class AUX_MV_CPTE_COBRANZAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long ES_MEDIO_DE_PAGO { get; set; }
		[Column()]
		public long ES_COMPROBANTE { get; set; }
		[Column()]
		public long ID { get; set; }
	}
}
