using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "EQ_COND_INTERFACES")]
	public partial class EQ_COND_INTERFACES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string INTERFACE { get; set; }
		[Column()]
		public string VALOR_CAMPO { get; set; }
		[Column()]
		public string ASIGNADO_A_CUENTA { get; set; }
		[Column()]
		public string AL_DEBE_O_HABER { get; set; }
		[Column()]
		public string CAMPO_ORIGEN { get; set; }
		[Column()]
		public string OPERADOR { get; set; }
		[Column()]
		public string VALOR_CAMPO_ORIGEN { get; set; }
		[Column()]
		public long SECUENCIA { get; set; }
	}
}
