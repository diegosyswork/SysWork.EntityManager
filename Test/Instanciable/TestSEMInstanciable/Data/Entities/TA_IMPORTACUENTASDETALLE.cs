using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "TA_IMPORTACUENTASDETALLE")]
	public partial class TA_IMPORTACUENTASDETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string NOMBRE_CAMPO { get; set; }
		[Column()]
		public string LONGITUD { get; set; }
		[Column()]
		public long SECUENCIA { get; set; }
	}
}
