using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_MOTIVO_AJUSTES")]
	public partial class V_TA_MOTIVO_AJUSTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IdMotivoAjuste { get; set; }
		[Column()]
		public string Descripcion { get; set; }
	}
}
