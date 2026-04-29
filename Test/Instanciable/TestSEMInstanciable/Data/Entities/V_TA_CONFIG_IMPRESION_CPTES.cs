using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_CONFIG_IMPRESION_CPTES")]
	public partial class V_TA_CONFIG_IMPRESION_CPTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string PC_USUARIO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SUCURSAL { get; set; }
		[Column( IsPrimaryKey = true)]
		public string LETRA { get; set; }
		[Column()]
		public string IMPRESORA { get; set; }
		[Column()]
		public long? CANTIDADDECOPIAS { get; set; }
		[Column()]
		public long? CANTIDADDELINEAS { get; set; }
		[Column()]
		public string DESTINODEFAULT { get; set; }
		[Column()]
		public string FORMULARIO { get; set; }
		[Column()]
		public string FORMULARIO2 { get; set; }
		[Column()]
		public string FORMULARIO3 { get; set; }
		[Column()]
		public string FORMULARIO4 { get; set; }
		[Column()]
		public string ORIENTACION { get; set; }
		[Column()]
		public long? FORZAR_PAPEL { get; set; }
		[Column()]
		public string IMPRESORA2 { get; set; }
		[Column()]
		public string IMPRESORA3 { get; set; }
		[Column()]
		public string IMPRESORA4 { get; set; }
	}
}
