using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "P_Solucitudes")]
	public partial class P_Solucitudes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long IdBusqueda { get; set; }
		[Column()]
		public DateTime FechaSolicitud { get; set; }
		[Column()]
		public string Cliente { get; set; }
		[Column()]
		public string Funciones { get; set; }
		[Column()]
		public string Areas { get; set; }
		[Column()]
		public string Sueldo { get; set; }
		[Column()]
		public bool Aceptado { get; set; }
		[Column()]
		public string TipoEntrevista { get; set; }
		[Column()]
		public string IdEstadoBusqueda { get; set; }
	}
}
