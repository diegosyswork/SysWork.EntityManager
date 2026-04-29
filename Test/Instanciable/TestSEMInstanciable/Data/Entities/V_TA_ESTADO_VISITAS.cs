using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_ESTADO_VISITAS")]
	public partial class V_TA_ESTADO_VISITAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column()]
		public string IdEstadoVisita { get; set; }
		[Column()]
		public string Descripcion { get; set; }
	}
}
