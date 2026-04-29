using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_PLANILLASMoviles")]
	public partial class VT_PLANILLASMoviles
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long? IdPlanillaMovil { get; set; }
		[Column()]
		public DateTime? FechaPlanillaMovil { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
	}
}
