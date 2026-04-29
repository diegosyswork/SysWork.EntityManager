using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_MOTIVO_BAJA_CUENTAS")]
	public partial class V_TA_MOTIVO_BAJA_CUENTAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDMOTIVOBAJA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
	}
}
