using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_MA_EXPRESOS")]
	public partial class V_MA_EXPRESOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string idExpreso { get; set; }
		[Column()]
		public string razonSocial { get; set; }
		[Column()]
		public string direccion { get; set; }
		[Column()]
		public string cuit { get; set; }
	}
}
