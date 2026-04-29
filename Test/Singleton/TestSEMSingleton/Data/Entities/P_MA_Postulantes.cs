using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_Postulantes")]
	public partial class P_MA_Postulantes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long IdPostulante { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
		[Column()]
		public string NroDocumento { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public DateTime FechaAlta { get; set; }
		[Column()]
		public decimal SueldoDesde { get; set; }
		[Column()]
		public decimal? SueldoHasta { get; set; }
		[Column()]
		public string Sexo { get; set; }
		[Column()]
		public DateTime? FechaNacimiento { get; set; }
		[Column()]
		public long? Edad { get; set; }
		[Column()]
		public string IdZonaResidencia { get; set; }
		[Column()]
		public bool DisponibleRadicacion { get; set; }
		[Column()]
		public bool PostulanteBDO { get; set; }
		[Column()]
		public string IdEstadoPostulante { get; set; }
		[Column()]
		public string RutaAccesoCV { get; set; }
		[Column()]
		public string Comentarios { get; set; }
		[Column()]
		public string Referencia { get; set; }
	}
}
