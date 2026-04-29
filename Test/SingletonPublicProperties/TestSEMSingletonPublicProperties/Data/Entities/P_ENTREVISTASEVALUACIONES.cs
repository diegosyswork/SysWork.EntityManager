using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "P_ENTREVISTASEVALUACIONES")]
	public partial class P_ENTREVISTASEVALUACIONES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TipoEntrevista { get; set; }
		[Column( Name = "Fecha Hora")]
		public DateTime? FechaHora { get; set; }
		[Column( Name = "Nro Documento")]
		public string NroDocumento { get; set; }
		[Column()]
		public string Postulante { get; set; }
		[Column()]
		public string Responsable { get; set; }
		[Column()]
		public string Comentarios { get; set; }
		[Column( Name = "Documento Adjunto")]
		public string DocumentoAdjunto { get; set; }
		[Column()]
		public long? IdBusqueda { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
	}
}
