using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "wsSysMobileDepositos")]
	public partial class wsSysMobileDepositos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string idDeposito { get; set; }
		[Column()]
		public string Descripcion { get; set; }
	}
}
