using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "L_MV_Ruit")]
	public partial class L_MV_Ruit
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public Int64 id { get; set; }
		[Column()]
		public string IdTipoDoc { get; set; }
		[Column()]
		public string NroDoc { get; set; }
		[Column()]
		public string SerieLic { get; set; }
		[Column()]
		public string NroLic { get; set; }
	}
}
