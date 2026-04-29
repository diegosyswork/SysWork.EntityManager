using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "L_MA_LicenciasCategorias")]
	public partial class L_MA_LicenciasCategorias
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string Serie { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NroLicencia { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdCategoria { get; set; }
	}
}
