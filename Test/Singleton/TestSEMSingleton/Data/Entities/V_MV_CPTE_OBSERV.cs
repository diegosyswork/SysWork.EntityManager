using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MV_CPTE_OBSERV")]
	public partial class V_MV_CPTE_OBSERV
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDCOMPROBANTE { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string TIPO_OBS { get; set; }
		[Column()]
		public string OBSERVACION { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
	}
}
