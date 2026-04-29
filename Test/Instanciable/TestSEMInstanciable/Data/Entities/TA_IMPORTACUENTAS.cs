using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "TA_IMPORTACUENTAS")]
	public partial class TA_IMPORTACUENTAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string NOMBRE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TIPO_ARCHIVO { get; set; }
		[Column()]
		public string SEPARADOR { get; set; }
		[Column()]
		public string CALIFICADOR { get; set; }
		[Column()]
		public string CAMPO_DESCRIPCION { get; set; }
		[Column()]
		public string CAMPO_CONDIVA { get; set; }
		[Column()]
		public string CAMPO_CUIT { get; set; }
		[Column()]
		public string CAMPO_CODIGO { get; set; }
	}
}
