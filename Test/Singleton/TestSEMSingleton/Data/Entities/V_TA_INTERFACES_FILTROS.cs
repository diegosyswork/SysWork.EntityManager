using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_INTERFACES_FILTROS")]
	public partial class V_TA_INTERFACES_FILTROS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_INTERFACE { get; set; }
		[Column()]
		public string CAMPO { get; set; }
		[Column()]
		public string OPERADOR { get; set; }
		[Column()]
		public string VALOR { get; set; }
		[Column()]
		public string OPERADOR_LOGICO { get; set; }
	}
}
