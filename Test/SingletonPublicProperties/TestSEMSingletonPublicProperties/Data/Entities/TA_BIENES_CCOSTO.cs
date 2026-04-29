using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "TA_BIENES_CCOSTO")]
	public partial class TA_BIENES_CCOSTO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IDCCOSTOBIEN { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
	}
}
