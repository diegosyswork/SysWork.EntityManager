using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_Postulantes_Experiencia")]
	public partial class P_MA_Postulantes_Experiencia
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IdPostulante { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdFunciones { get; set; }
		[Column()]
		public long Tiempo { get; set; }
		[Column()]
		public string IdAreas { get; set; }
		[Column()]
		public DateTime? PDesde { get; set; }
		[Column()]
		public DateTime? PHasta { get; set; }
	}
}
