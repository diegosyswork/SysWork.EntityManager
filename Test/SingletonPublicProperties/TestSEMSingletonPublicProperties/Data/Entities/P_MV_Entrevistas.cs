using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "P_MV_Entrevistas")]
	public partial class P_MV_Entrevistas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string TipoEntrevista { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public DateTime? FechaHora { get; set; }
		[Column()]
		public string Responsable { get; set; }
		[Column()]
		public string Resultado { get; set; }
		[Column()]
		public bool Procesado { get; set; }
		[Column()]
		public bool Aceptado { get; set; }
		[Column()]
		public long IdProcesoBusqueda { get; set; }
		[Column()]
		public string DocAsociado { get; set; }
	}
}
