using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CONTACTOS")]
	public partial class MA_CONTACTOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long id { get; set; }
		[Column()]
		public string Nombre_y_Apellido { get; set; }
		[Column()]
		public string Domicilio { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public string Provincia { get; set; }
		[Column()]
		public string C_Postal { get; set; }
		[Column()]
		public string Telefono { get; set; }
		[Column()]
		public string Fax { get; set; }
		[Column()]
		public string Celular { get; set; }
		[Column()]
		public string email { get; set; }
		[Column()]
		public string WebSite { get; set; }
		[Column()]
		public string Observaciones { get; set; }
	}
}
