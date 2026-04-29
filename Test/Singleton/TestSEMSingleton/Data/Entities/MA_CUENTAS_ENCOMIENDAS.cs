using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CUENTAS_ENCOMIENDAS")]
	public partial class MA_CUENTAS_ENCOMIENDAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public DateTime FECHA { get; set; }
		[Column()]
		public long CANT_BULTOS { get; set; }
		[Column()]
		public string TRANSPORTE { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
