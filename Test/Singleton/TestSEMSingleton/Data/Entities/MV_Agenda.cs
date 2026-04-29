using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MV_Agenda")]
	public partial class MV_Agenda
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string NombreAgenda { get; set; }
		[Column()]
		public DateTime Fecha { get; set; }
		[Column()]
		public string Mensaje { get; set; }
		[Column()]
		public DateTime? FechaAviso { get; set; }
		[Column()]
		public string NotasDelDia { get; set; }
		[Column()]
		public long? IdProcesoBusqueda { get; set; }
		[Column()]
		public long? IdEntrevista { get; set; }
	}
}
