using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_CuentasComision")]
	public partial class V_TA_CuentasComision
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string Tipo { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
	}
}
