using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "P_TodasLasSolicitudes")]
	public partial class P_TodasLasSolicitudes
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
		public string IdEstadoBusqueda { get; set; }
		[Column()]
		public string IdCliente { get; set; }
	}
}
