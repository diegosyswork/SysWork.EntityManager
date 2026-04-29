using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "T_VEHICULOS_NOVEDADES")]
	public partial class T_VEHICULOS_NOVEDADES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string PATENTE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string idNovedadVehic { get; set; }
		[Column()]
		public long PERIODICIDAD { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
