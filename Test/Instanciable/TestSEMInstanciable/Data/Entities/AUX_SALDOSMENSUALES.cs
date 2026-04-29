using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "AUX_SALDOSMENSUALES")]
	public partial class AUX_SALDOSMENSUALES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public Int16? Mes { get; set; }
		[Column()]
		public Int16? Anio { get; set; }
		[Column()]
		public decimal? Saldo { get; set; }
		[Column()]
		public decimal? SaldoAjustado { get; set; }
		[Column()]
		public decimal? Diferencia { get; set; }
		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string USUARIO { get; set; }
	}
}
