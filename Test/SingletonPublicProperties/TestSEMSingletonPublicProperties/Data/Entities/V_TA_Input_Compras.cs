using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_Input_Compras")]
	public partial class V_TA_Input_Compras
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdMotivoCpra { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CondIva { get; set; }
		[Column()]
		public string Repuestos { get; set; }
		[Column()]
		public string Servicios { get; set; }
		[Column()]
		public string Otros { get; set; }
	}
}
