using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "V_ImportesAplicados")]
	public partial class V_ImportesAplicados
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TCO_ORIGEN { get; set; }
		[Column()]
		public string IdComprobanteOrigen { get; set; }
		[Column()]
		public decimal? ImporteAplicado { get; set; }
	}
}
