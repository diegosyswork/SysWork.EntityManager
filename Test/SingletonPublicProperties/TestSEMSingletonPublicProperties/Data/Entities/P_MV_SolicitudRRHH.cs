using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "P_MV_SolicitudRRHH")]
	public partial class P_MV_SolicitudRRHH
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IdBusqueda { get; set; }
		[Column()]
		public DateTime FechaSolicitud { get; set; }
		[Column()]
		public string IdCliente { get; set; }
		[Column()]
		public string IdFunciones { get; set; }
		[Column()]
		public string IdAreas { get; set; }
		[Column()]
		public decimal? SueldoDesde { get; set; }
		[Column()]
		public decimal? SueldoHasta { get; set; }
		[Column()]
		public decimal? ImporteFacturar { get; set; }
		[Column()]
		public string IdEstadoBusqueda { get; set; }
		[Column()]
		public bool IngresoPorInternet { get; set; }
		[Column()]
		public string Sexo { get; set; }
		[Column()]
		public bool PostuladoConsultora { get; set; }
		[Column()]
		public long? EdadDesde { get; set; }
		[Column()]
		public long? EdadHasta { get; set; }
		[Column()]
		public long? AniosExperiencia { get; set; }
		[Column()]
		public bool DisponibleRadicacion { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public string Criterios { get; set; }
	}
}
