using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "AUX_ANEXOA")]
	public partial class AUX_ANEXOA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string CUENTA_TITULO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public long? CODIGO { get; set; }
		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column()]
		public decimal? COLUMNA2 { get; set; }
		[Column()]
		public decimal? COLUMNA3 { get; set; }
		[Column()]
		public decimal? COLUMNA4 { get; set; }
		[Column()]
		public decimal? COLUMNA5 { get; set; }
		[Column()]
		public decimal? COLUMNA6 { get; set; }
		[Column()]
		public decimal? COLUMNA7 { get; set; }
		[Column()]
		public decimal? COLUMNA8 { get; set; }
		[Column()]
		public decimal? COLUMNA9 { get; set; }
		[Column()]
		public decimal? COLUMNA10 { get; set; }
		[Column()]
		public decimal? COLUMNA11 { get; set; }
	}
}
