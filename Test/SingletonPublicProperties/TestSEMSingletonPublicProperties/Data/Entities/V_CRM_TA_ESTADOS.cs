using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_CRM_TA_ESTADOS")]
	public partial class V_CRM_TA_ESTADOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDESTADO_CRM { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string APLICABLE_A_CPTE { get; set; }
		[Column()]
		public long? COLOR { get; set; }
	}
}
