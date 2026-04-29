using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "P_MV_CtrolHorarios")]
	public partial class P_MV_CtrolHorarios
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdEmpresa { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Legajo { get; set; }
		[Column( IsPrimaryKey = true)]
		public DateTime FechaOperativa { get; set; }
		[Column( IsPrimaryKey = true)]
		public long Secuencia { get; set; }
		[Column()]
		public DateTime? Ingreso { get; set; }
		[Column()]
		public DateTime? Egreso { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public string ApellidoNombre { get; set; }
	}
}
