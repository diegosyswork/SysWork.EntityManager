using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "wsSysMobileRubros")]
	public partial class wsSysMobileRubros
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string idRubro { get; set; }
		[Column()]
		public string Descripcion { get; set; }
	}
}
