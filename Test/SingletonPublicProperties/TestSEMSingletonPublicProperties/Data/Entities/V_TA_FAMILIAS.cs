using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_FAMILIAS")]
	public partial class V_TA_FAMILIAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IdFamilia { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public long? Transmision { get; set; }
		[Column()]
		public decimal? MKBase { get; set; }
		[Column()]
		public string RUTA_IMAGEN { get; set; }
	}
}
