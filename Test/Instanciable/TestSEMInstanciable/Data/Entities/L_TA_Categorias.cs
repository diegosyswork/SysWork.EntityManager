using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "L_TA_Categorias")]
	public partial class L_TA_Categorias
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IdCategoria { get; set; }
		[Column()]
		public string Descripcion { get; set; }
	}
}
