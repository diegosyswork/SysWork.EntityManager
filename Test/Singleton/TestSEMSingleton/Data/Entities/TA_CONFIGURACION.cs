using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_CONFIGURACION")]
	public partial class TA_CONFIGURACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string GRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CLAVE { get; set; }
		[Column()]
		public string VALOR { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
	}
}
