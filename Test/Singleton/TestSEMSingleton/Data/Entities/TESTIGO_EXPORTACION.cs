using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TESTIGO_EXPORTACION")]
	public partial class TESTIGO_EXPORTACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string CODIGO_ORIGEN { get; set; }
		[Column()]
		public string CODIGO_SISTEMA { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public DateTime FH_GRABACION { get; set; }
	}
}
