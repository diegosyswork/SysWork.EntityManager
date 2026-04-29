using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_ZONAS")]
	public partial class V_TA_ZONAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IDZONA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public DateTime? FECHAHORA_GRABACION { get; set; }
		[Column()]
		public DateTime? FECHAHORA_MODIFICACION { get; set; }
	}
}
