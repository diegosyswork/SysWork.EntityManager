using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "TA_MENU")]
	public partial class TA_MENU
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long id { get; set; }
		[Column()]
		public string Menu { get; set; }
		[Column()]
		public string Titulo { get; set; }
		[Column()]
		public string Clave { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string Imagen { get; set; }
		[Column()]
		public string Proceso { get; set; }
		[Column()]
		public bool Habilitado { get; set; }
	}
}
