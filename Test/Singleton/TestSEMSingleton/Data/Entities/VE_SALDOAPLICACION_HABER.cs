using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VE_SALDOAPLICACION_HABER")]
	public partial class VE_SALDOAPLICACION_HABER
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TCO_ORIGEN { get; set; }
		[Column()]
		public string SUCURSAL_ORIGEN { get; set; }
		[Column()]
		public string NUMERO_ORIGEN { get; set; }
		[Column()]
		public string LETRA_ORIGEN { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? TOTAL { get; set; }
		[Column()]
		public decimal? SALDO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
	}
}
