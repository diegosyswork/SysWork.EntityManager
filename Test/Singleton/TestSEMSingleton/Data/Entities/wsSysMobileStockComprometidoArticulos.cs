using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "wsSysMobileStockComprometidoArticulos")]
	public partial class wsSysMobileStockComprometidoArticulos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public double? Stock { get; set; }
	}
}
