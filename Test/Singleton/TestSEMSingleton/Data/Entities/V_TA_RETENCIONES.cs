using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_RETENCIONES")]
	public partial class V_TA_RETENCIONES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdRetencion { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public decimal? MinimoNoImponible { get; set; }
		[Column()]
		public decimal? MinimoExcluido { get; set; }
		[Column()]
		public decimal? porcentaje { get; set; }
		[Column()]
		public string CODIGO_SIAP { get; set; }
	}
}
