using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MV_PreciosHis")]
	public partial class V_MV_PreciosHis
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column()]
		public DateTime FECHAHORA { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public string IDLISTA { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public decimal? COSTO { get; set; }
		[Column()]
		public decimal? IMPUESTOS { get; set; }
		[Column()]
		public decimal? TASAIVA { get; set; }
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
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public bool REVISADO { get; set; }
		[Column()]
		public string ABM { get; set; }
		[Column()]
		public bool SUSPENDIDO { get; set; }
	}
}
