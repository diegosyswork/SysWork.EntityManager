using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "LogDb")]
	public partial class LogDb
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long idLogDb { get; set; }
		[Column()]
		public DateTime fechaHora { get; set; }
		[Column()]
		public string usuario { get; set; }
		[Column()]
		public string tag { get; set; }
		[Column()]
		public string mensaje { get; set; }
		[Column()]
		public string modulo { get; set; }
		[Column()]
		public string metodo { get; set; }
		[Column()]
		public string sentenciaSQL { get; set; }
		[Column()]
		public string parametros { get; set; }
		[Column()]
		public string resultado { get; set; }
		[Column()]
		public string excepcion { get; set; }
	}
}
