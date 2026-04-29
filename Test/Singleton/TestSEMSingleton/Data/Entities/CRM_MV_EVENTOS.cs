using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "CRM_MV_EVENTOS")]
	public partial class CRM_MV_EVENTOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public DateTime FECHA_HORA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDEVENTO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string OPERADOR { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public string ASUNTO { get; set; }
		[Column()]
		public string CONTACTO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public DateTime? PROGRAMAR_PROXIMO_EVENTO { get; set; }
		[Column()]
		public string NRO_CASO { get; set; }
		[Column()]
		public bool REVISADO { get; set; }
		[Column()]
		public string REVISADO_POR { get; set; }
	}
}
