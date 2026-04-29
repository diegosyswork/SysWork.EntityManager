using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VT_ULTIMOS_PRECIOS_COMPRA")]
	public partial class VT_ULTIMOS_PRECIOS_COMPRA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public string RAZON_SOCIAL { get; set; }
	}
}
