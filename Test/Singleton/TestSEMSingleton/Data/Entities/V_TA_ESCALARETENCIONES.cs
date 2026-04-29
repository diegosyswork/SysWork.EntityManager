using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_ESCALARETENCIONES")]
	public partial class V_TA_ESCALARETENCIONES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string IdRetencion { get; set; }
		[Column()]
		public decimal? Desde { get; set; }
		[Column()]
		public decimal? Hasta { get; set; }
		[Column()]
		public decimal? Importe { get; set; }
		[Column()]
		public long? Porcentaje { get; set; }
		[Column()]
		public decimal? SobreExcedente { get; set; }
	}
}
