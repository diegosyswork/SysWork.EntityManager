using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CUENTAS_RUTEO_VENDEDOR")]
	public partial class MA_CUENTAS_RUTEO_VENDEDOR
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDVENDEDOR { get; set; }
		[Column( IsPrimaryKey = true)]
		public long DIA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public long ORDEN { get; set; }
	}
}
