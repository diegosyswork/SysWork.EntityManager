using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "P_EvaluacionesPendientes")]
	public partial class P_EvaluacionesPendientes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? FechaHora { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
		[Column()]
		public string NroDocumento { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string Resultado { get; set; }
		[Column()]
		public long Id { get; set; }
		[Column()]
		public long IdBusqueda { get; set; }
		[Column()]
		public string DocAsociado { get; set; }
		[Column()]
		public string IdEstadoPostulante { get; set; }
		[Column()]
		public string TipoEntrevista { get; set; }
		[Column()]
		public bool Aceptado { get; set; }
	}
}
