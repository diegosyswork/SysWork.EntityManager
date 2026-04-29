using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_ESTADISTICA_CLIENTES")]
	public partial class VT_ESTADISTICA_CLIENTES
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
		public DateTime? UltVenta { get; set; }
		[Column()]
		public decimal? VentaMinima { get; set; }
		[Column()]
		public decimal? VentaMaxima { get; set; }
		[Column()]
		public long? CantFacturas { get; set; }
		[Column()]
		public decimal? TotalVentas { get; set; }
		[Column()]
		public decimal? PromedioVenta { get; set; }
		[Column()]
		public long? DiasUltVenta { get; set; }
	}
}
