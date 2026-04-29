using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VT_MV_APLICACION")]
	public partial class VT_MV_APLICACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string TCO_ORIGEN { get; set; }
		[Column()]
		public string IdComprobanteOrigen { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
	}
}
