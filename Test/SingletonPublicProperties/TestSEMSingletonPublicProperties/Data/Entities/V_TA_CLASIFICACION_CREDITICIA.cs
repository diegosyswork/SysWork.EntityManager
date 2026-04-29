using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_CLASIFICACION_CREDITICIA")]
	public partial class V_TA_CLASIFICACION_CREDITICIA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string idClasificacionCrediticia { get; set; }
		[Column()]
		public string descripcion { get; set; }
		[Column()]
		public long? color { get; set; }
		[Column()]
		public DateTime? fechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? fechaHora_Modificacion { get; set; }
	}
}
