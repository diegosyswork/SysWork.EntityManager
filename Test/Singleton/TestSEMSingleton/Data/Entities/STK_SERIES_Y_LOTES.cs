using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "STK_SERIES_Y_LOTES")]
	public partial class STK_SERIES_Y_LOTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public string NroLote { get; set; }
		[Column()]
		public string NroSerie { get; set; }
		[Column()]
		public double? Cantidad { get; set; }
	}
}
