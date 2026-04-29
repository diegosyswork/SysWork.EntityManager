using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_FIDELIZACION_MV_PUNTOS")]
	public partial class V_FIDELIZACION_MV_PUNTOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public decimal? IMPORTE_CPTE { get; set; }
		[Column()]
		public long PUNTOS { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
