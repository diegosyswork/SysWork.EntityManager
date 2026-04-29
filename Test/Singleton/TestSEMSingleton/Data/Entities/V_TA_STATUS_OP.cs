using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_STATUS_OP")]
	public partial class V_TA_STATUS_OP
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDESTATUS { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public long? COLOR { get; set; }
	}
}
