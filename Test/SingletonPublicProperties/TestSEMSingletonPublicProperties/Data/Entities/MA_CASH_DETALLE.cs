using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_CASH-DETALLE")]
	public partial class MA_CASH_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CODIGO_CASH { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_GRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_SUBGRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public decimal? SaldoPeriodo1 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo2 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo3 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo4 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo5 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo6 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo7 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo8 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo9 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo10 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo11 { get; set; }
		[Column()]
		public decimal? SaldoPeriodo12 { get; set; }
	}
}
