using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_CRM_MV_CPTE")]
	public partial class V_CRM_MV_CPTE
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
		[Column()]
		public DateTime FECHA_HORA { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string USUARIO_WINDOWS { get; set; }
		[Column()]
		public string TERMINAL { get; set; }
		[Column()]
		public string IDESTADO_CRM { get; set; }
		[Column()]
		public string IDACCION_CRM { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
