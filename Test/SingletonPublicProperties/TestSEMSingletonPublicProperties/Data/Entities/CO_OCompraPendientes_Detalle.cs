using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "CO_OCompraPendientes_Detalle")]
	public partial class CO_OCompraPendientes_Detalle
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public DateTime? FechaEntrega { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
	}
}
