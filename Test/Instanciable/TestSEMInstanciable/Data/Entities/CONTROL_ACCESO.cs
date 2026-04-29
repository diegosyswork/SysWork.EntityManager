using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "CONTROL_ACCESO")]
	public partial class CONTROL_ACCESO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string MAQUINA { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string FORMULARIO { get; set; }
		[Column()]
		public string TAREA { get; set; }
		[Column()]
		public DateTime? INGRESO { get; set; }
		[Column()]
		public DateTime? EGRESO { get; set; }
		[Column()]
		public string TAREASREALIZADAS { get; set; }
	}
}
