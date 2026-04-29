using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "wsSysMobileStockArticulosDepositos")]
	public partial class wsSysMobileStockArticulosDepositos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string idArticulo { get; set; }
		[Column()]
		public string Expr1 { get; set; }
		[Column()]
		public double? Stock { get; set; }
	}
}
