using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "wsSysMobileVendedores")]
	public partial class wsSysMobileVendedores
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string idVendedor { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string codigoValidacion { get; set; }
	}
}
