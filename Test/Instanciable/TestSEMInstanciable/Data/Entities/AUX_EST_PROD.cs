using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "AUX_EST_PROD")]
	public partial class AUX_EST_PROD
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long id { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public double? CANTIDAD1 { get; set; }
		[Column()]
		public double? CANTIDAD2 { get; set; }
		[Column()]
		public double? CANTIDAD3 { get; set; }
		[Column()]
		public double? CANTIDAD4 { get; set; }
	}
}
