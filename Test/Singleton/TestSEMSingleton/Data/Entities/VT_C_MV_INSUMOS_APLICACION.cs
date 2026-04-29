using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_C_MV_INSUMOS_APLICACION")]
	public partial class VT_C_MV_INSUMOS_APLICACION
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
		public string IDARTICULO { get; set; }
		[Column()]
		public double? CantidadAplicada { get; set; }
		[Column()]
		public string CUENTA { get; set; }
	}
}
