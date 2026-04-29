using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "dtproperties")]
	public partial class dtproperties
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long id { get; set; }
		[Column()]
		public long? objectid { get; set; }
		[Column( IsPrimaryKey = true)]
		public string property { get; set; }
		[Column()]
		public string value { get; set; }
		[Column()]
		public string uvalue { get; set; }
		[Column()]
		public byte[]? lvalue { get; set; }
		[Column()]
		public long version { get; set; }
	}
}
