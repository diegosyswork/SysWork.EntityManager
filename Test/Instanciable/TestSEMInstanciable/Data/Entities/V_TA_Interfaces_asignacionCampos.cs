using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_Interfaces_asignacionCampos")]
	public partial class V_TA_Interfaces_asignacionCampos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string INTERFACE { get; set; }
		[Column()]
		public string CAMPO_ORIGEN { get; set; }
		[Column()]
		public string CAMPO_TABLA { get; set; }
		[Column()]
		public string TABLA_ORIGEN { get; set; }
		[Column()]
		public string CAMPO { get; set; }
		[Column()]
		public string OPERADOR { get; set; }
		[Column()]
		public string VALOR { get; set; }
		[Column()]
		public long Secuencia { get; set; }
	}
}
