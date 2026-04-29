using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VE_SALDOSVDOR_DEBE")]
	public partial class VE_SALDOSVDOR_DEBE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public decimal? TOTALDEBE { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
	}
}
