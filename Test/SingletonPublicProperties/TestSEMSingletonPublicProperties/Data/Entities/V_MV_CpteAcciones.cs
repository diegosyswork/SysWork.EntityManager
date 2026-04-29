using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MV_CpteAcciones")]
	public partial class V_MV_CpteAcciones
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string TIPO_ACCION { get; set; }
		[Column()]
		public DateTime? FECHAHORA { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string PC { get; set; }
		[Column()]
		public string SYSTEMUSER { get; set; }
	}
}
