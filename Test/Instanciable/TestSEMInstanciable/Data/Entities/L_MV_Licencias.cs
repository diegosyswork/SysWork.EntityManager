using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "L_MV_Licencias")]
	public partial class L_MV_Licencias
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public Int64 id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdTipoDoc { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NroDoc { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Serie { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NroLicencia { get; set; }
	}
}
