using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "P_MV_SolicitudRRHH_Conocimientos")]
	public partial class P_MV_SolicitudRRHH_Conocimientos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IdBusqueda { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdConocimiento { get; set; }
	}
}
