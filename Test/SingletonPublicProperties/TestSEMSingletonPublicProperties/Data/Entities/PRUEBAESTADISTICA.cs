using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "PRUEBAESTADISTICA")]
	public partial class PRUEBAESTADISTICA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public decimal? IMPORTEG1 { get; set; }
		[Column()]
		public string DHG1 { get; set; }
		[Column()]
		public decimal? IMPORTEG2 { get; set; }
		[Column()]
		public string DHG2 { get; set; }
		[Column()]
		public decimal? IMPORTEG3 { get; set; }
		[Column()]
		public string DHG3 { get; set; }
		[Column()]
		public decimal? IMPORTEG4 { get; set; }
		[Column()]
		public string DHG4 { get; set; }
		[Column()]
		public decimal? IMPORTEG5 { get; set; }
		[Column()]
		public string DHG5 { get; set; }
		[Column()]
		public decimal? IMPORTEG6 { get; set; }
		[Column()]
		public string DHG6 { get; set; }
		[Column()]
		public decimal? IMPORTEG7 { get; set; }
		[Column()]
		public string DHG7 { get; set; }
	}
}
