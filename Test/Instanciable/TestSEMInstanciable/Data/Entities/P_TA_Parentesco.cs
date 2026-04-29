using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "P_TA_Parentesco")]
	public partial class P_TA_Parentesco
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string IdParentesco { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
	}
}
