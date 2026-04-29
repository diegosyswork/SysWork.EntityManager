using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VT_ESTADISTICA_CLIENTES_COBRANZAS")]
	public partial class VT_ESTADISTICA_CLIENTES_COBRANZAS
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
		public DateTime? UltCobranza { get; set; }
		[Column()]
		public decimal? CobranzaMinima { get; set; }
		[Column()]
		public decimal? CobranzaMaxima { get; set; }
		[Column()]
		public long? CantCobranzas { get; set; }
		[Column()]
		public decimal? TotalCobranzas { get; set; }
		[Column()]
		public decimal? CobranzasVenta { get; set; }
		[Column()]
		public long? DiasUltCobranza { get; set; }
	}
}
