using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VE_SALDOSCTA")]
	public partial class VE_SALDOSCTA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string TipoVista { get; set; }
		[Column()]
		public decimal TOTALDEBE { get; set; }
		[Column()]
		public decimal TOTALHABER { get; set; }
		[Column()]
		public decimal? SALDO { get; set; }
	}
}
