using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MV_CONTROL_AS_RES")]
	public partial class MV_CONTROL_AS_RES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public long PERIODO { get; set; }
		[Column( IsPrimaryKey = true)]
		public byte MES_OPERATIVO { get; set; }
		[Column( IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SUBDIARIO { get; set; }
		[Column()]
		public DateTime? FECHA_DESDE { get; set; }
		[Column()]
		public DateTime? FECHA_HASTA { get; set; }
		[Column()]
		public bool ANULADO { get; set; }
		[Column()]
		public string RESPONSABLE { get; set; }
		[Column()]
		public DateTime? FECHA_ALTA { get; set; }
		[Column()]
		public DateTime? FECHA_MODIFICACION { get; set; }
	}
}
