using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "GM_PLANILLAS")]
	public partial class GM_PLANILLAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string ID_PLANILLA { get; set; }
		[Column()]
		public DateTime FECHA_PLANILLA { get; set; }
	}
}
