using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VT_ESTADISTICA_CLIENTES_ENTREGAS")]
	public partial class VT_ESTADISTICA_CLIENTES_ENTREGAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public DateTime? ULTIMA_ENTREGA { get; set; }
		[Column()]
		public decimal? ENTREGA_MAX { get; set; }
		[Column()]
		public decimal? ENTREGA_MIN { get; set; }
		[Column()]
		public decimal? TOTAL_ENTREGAS { get; set; }
		[Column()]
		public long? CANTIDAD_ENTREGAS { get; set; }
		[Column()]
		public long? DiasUltEntrega { get; set; }
	}
}
