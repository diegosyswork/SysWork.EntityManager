using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "V_NP_PENDIENTES2")]
	public partial class V_NP_PENDIENTES2
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string SUCURSALREMITO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string IDCOND_CPRA_VTA { get; set; }
	}
}
