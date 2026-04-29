using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "P_TodasLasSolicitudesPost")]
	public partial class P_TodasLasSolicitudesPost
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long IdBusqueda { get; set; }
		[Column()]
		public long ID_Evaluacion { get; set; }
		[Column()]
		public string Postulante { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public DateTime FechaAlta { get; set; }
		[Column()]
		public string SUELDO { get; set; }
		[Column()]
		public string Sexo { get; set; }
		[Column()]
		public long? Edad { get; set; }
		[Column( Name = "Zona Residencia")]
		public string ZonaResidencia { get; set; }
		[Column()]
		public bool DisponibleRadicacion { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public string IdEstadoPostulante { get; set; }
		[Column()]
		public bool Procesado { get; set; }
		[Column()]
		public string IdCliente { get; set; }
	}
}
