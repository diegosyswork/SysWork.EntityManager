using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "P_MA_Postulantes_Obs")]
	public partial class P_MA_Postulantes_Obs
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public DateTime? Fecha { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public string Usuario { get; set; }
	}
}
