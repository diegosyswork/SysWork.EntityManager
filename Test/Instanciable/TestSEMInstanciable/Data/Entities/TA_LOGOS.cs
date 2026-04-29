using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "TA_LOGOS")]
	public partial class TA_LOGOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long IDint { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDLOGO { get; set; }
		[Column()]
		public string RUTA { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
	}
}
