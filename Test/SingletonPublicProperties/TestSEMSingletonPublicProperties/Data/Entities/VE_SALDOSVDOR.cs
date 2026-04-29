using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VE_SALDOSVDOR")]
	public partial class VE_SALDOSVDOR
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public decimal TOTALDEBE { get; set; }
		[Column()]
		public decimal TOTALHABER { get; set; }
		[Column()]
		public decimal? SALDO { get; set; }
	}
}
