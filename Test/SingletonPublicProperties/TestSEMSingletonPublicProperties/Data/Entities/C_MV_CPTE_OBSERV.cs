using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "C_MV_CPTE_OBSERV")]
	public partial class C_MV_CPTE_OBSERV
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TIPO_OBS { get; set; }
		[Column()]
		public string OBSERVACION { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public string UNIDAD { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
		[Column()]
		public string ITEM { get; set; }
		[Column()]
		public decimal? VALOR_UNITARIO { get; set; }
	}
}
