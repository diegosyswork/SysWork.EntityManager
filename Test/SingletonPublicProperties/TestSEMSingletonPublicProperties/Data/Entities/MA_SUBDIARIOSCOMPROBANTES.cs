using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_SUBDIARIOSCOMPROBANTES")]
	public partial class MA_SUBDIARIOSCOMPROBANTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string Subdiario { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
	}
}
