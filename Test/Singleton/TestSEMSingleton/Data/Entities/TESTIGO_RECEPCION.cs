using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TESTIGO_RECEPCION")]
	public partial class TESTIGO_RECEPCION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public DateTime? FECHA_HORA { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string ARCHIVO { get; set; }
		[Column()]
		public long? REGISTROS_LEIDOS { get; set; }
		[Column()]
		public long? REGISTROS_IGNORADOS { get; set; }
		[Column()]
		public long? TOTAL_LINEAS { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
	}
}
