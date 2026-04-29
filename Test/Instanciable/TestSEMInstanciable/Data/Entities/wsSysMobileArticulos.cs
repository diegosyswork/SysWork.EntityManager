using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "wsSysMobileArticulos")]
	public partial class wsSysMobileArticulos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string idArticulo { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string IdRubro { get; set; }
		[Column()]
		public decimal Impuestos { get; set; }
		[Column()]
		public double? TasaIVA { get; set; }
		[Column()]
		public bool EXENTO { get; set; }
		[Column()]
		public decimal? PRECIO1 { get; set; }
		[Column()]
		public decimal? PRECIO2 { get; set; }
		[Column()]
		public decimal? PRECIO3 { get; set; }
		[Column()]
		public decimal? PRECIO4 { get; set; }
		[Column()]
		public decimal? PRECIO5 { get; set; }
		[Column()]
		public decimal? PRECIO6 { get; set; }
		[Column()]
		public decimal? PRECIO7 { get; set; }
		[Column()]
		public decimal? PRECIO8 { get; set; }
		[Column()]
		public decimal? PRECIO9 { get; set; }
		[Column()]
		public decimal? PRECIO10 { get; set; }
	}
}
