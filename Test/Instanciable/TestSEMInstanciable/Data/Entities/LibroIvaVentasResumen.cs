using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "LibroIvaVentasResumen")]
	public partial class LibroIvaVentasResumen
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string Periodo { get; set; }
		[Column()]
		public decimal? Facturado { get; set; }
	}
}
