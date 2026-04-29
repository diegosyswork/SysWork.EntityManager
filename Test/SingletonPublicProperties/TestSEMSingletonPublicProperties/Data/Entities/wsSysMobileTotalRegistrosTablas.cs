using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "wsSysMobileTotalRegistrosTablas")]
	public partial class wsSysMobileTotalRegistrosTablas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TABLA { get; set; }
		[Column()]
		public long? CANTIDAD { get; set; }
	}
}
