using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "CO_AplicacionOC")]
	public partial class CO_AplicacionOC
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TCO_ORIGEN { get; set; }
		[Column()]
		public string IDComprobante_Origen { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public double? CantidadUD { get; set; }
		[Column()]
		public double? Aplicado { get; set; }
	}
}
