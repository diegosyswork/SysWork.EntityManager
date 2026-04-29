using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "P_TA_Sindicatos")]
	public partial class P_TA_Sindicatos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string IdSindicato { get; set; }
		[Column()]
		public string IdSind_Categoria { get; set; }
		[Column()]
		public string IdSind_Cargo { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public long? HorasConvenio { get; set; }
	}
}
