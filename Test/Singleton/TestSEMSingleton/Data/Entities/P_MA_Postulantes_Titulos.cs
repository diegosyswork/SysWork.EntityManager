using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_Postulantes_Titulos")]
	public partial class P_MA_Postulantes_Titulos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IdPostulante { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdTitulos { get; set; }
		[Column()]
		public string IdNivelEstudio { get; set; }
	}
}
