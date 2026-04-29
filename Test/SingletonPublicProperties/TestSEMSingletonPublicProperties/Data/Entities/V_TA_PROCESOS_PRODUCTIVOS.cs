using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_PROCESOS_PRODUCTIVOS")]
	public partial class V_TA_PROCESOS_PRODUCTIVOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string ID_PROCESO_PRODUCTIVO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string RUTA_REPORTES { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
