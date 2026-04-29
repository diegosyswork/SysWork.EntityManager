using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_PostulanteAuxiliar")]
	public partial class P_MA_PostulanteAuxiliar
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public long Secuencia { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public string IdIdiomas { get; set; }
		[Column()]
		public string IdFunciones { get; set; }
		[Column()]
		public long? Tiempo { get; set; }
		[Column()]
		public string IdTitulos { get; set; }
		[Column()]
		public string IdConocimiento { get; set; }
	}
}
