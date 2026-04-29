using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "P_MV_Busquedas")]
	public partial class P_MV_Busquedas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public long IdBusqueda { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public DateTime FechaProceso { get; set; }
		[Column()]
		public bool Seleccionado { get; set; }
		[Column()]
		public DateTime? FechaHoraEntrevista { get; set; }
		[Column()]
		public string Usuario { get; set; }
	}
}
