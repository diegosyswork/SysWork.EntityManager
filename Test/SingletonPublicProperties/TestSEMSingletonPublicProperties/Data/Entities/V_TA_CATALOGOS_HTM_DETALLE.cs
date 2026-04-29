using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_CATALOGOS_HTM_DETALLE")]
	public partial class V_TA_CATALOGOS_HTM_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_CATALOGO { get; set; }
		[Column()]
		public string VARIABLE { get; set; }
		[Column()]
		public string TABLA { get; set; }
		[Column()]
		public string Campo { get; set; }
	}
}
