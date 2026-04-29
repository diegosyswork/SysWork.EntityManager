using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_AGRUPCUENTAS_DETALLE")]
	public partial class TA_AGRUPCUENTAS_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdAgrupacion { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Cuenta { get; set; }
	}
}
