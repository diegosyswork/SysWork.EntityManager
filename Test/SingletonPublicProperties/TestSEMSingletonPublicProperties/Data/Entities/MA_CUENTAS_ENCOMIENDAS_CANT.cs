using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_CUENTAS_ENCOMIENDAS_CANT")]
	public partial class MA_CUENTAS_ENCOMIENDAS_CANT
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IdEncomienda { get; set; }
	}
}
