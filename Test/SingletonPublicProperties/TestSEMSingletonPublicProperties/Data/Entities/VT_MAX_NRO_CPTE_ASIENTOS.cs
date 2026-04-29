using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VT_MAX_NRO_CPTE_ASIENTOS")]
	public partial class VT_MAX_NRO_CPTE_ASIENTOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string EL_MAXIMO { get; set; }
		[Column()]
		public string LETRA { get; set; }
	}
}
