using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_COTIZACION")]
	public partial class TA_COTIZACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public DateTime? FECHA_HORA { get; set; }
		[Column()]
		public decimal? MONEDA1 { get; set; }
		[Column()]
		public decimal? MONEDA2 { get; set; }
		[Column()]
		public decimal? MONEDA3 { get; set; }
		[Column()]
		public decimal? MONEDA4 { get; set; }
		[Column()]
		public decimal? MONEDA5 { get; set; }
	}
}
