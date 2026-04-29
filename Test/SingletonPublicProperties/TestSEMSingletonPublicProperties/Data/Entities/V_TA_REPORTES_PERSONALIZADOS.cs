using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_REPORTES_PERSONALIZADOS")]
	public partial class V_TA_REPORTES_PERSONALIZADOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_RP { get; set; }
		[Column()]
		public string NOMBRE_DESCRIPTIVO { get; set; }
		[Column()]
		public string ARCHIVO { get; set; }
		[Column()]
		public string WHERE_ADICIONAL { get; set; }
	}
}
