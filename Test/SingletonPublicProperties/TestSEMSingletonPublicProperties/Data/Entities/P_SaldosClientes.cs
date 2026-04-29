using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "P_SaldosClientes")]
	public partial class P_SaldosClientes
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
		public decimal? Saldo { get; set; }
	}
}
