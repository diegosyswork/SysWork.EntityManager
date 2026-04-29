using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "P_SaldosClientesBusquedas")]
	public partial class P_SaldosClientesBusquedas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IdCliente { get; set; }
		[Column()]
		public string Razon_Social { get; set; }
		[Column()]
		public long IdBusqueda { get; set; }
		[Column()]
		public decimal? ImporteFacturar { get; set; }
		[Column()]
		public decimal? ImportePagado { get; set; }
		[Column()]
		public decimal? Saldo { get; set; }
		[Column()]
		public DateTime? FechaPago { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public long Id { get; set; }
	}
}
