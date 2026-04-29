using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_MA_ARTICULOS_PROCESOS_PRODUCTIVOS")]
	public partial class V_MA_ARTICULOS_PROCESOS_PRODUCTIVOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDARTICULO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string ID_PROCESO_PRODUCTIVO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string ID_ATRIBUTO_PROCESO_PRODUCTIVO { get; set; }
		[Column()]
		public string VALOR_ATRIBUTO_PROCESO_PRODUCTIVO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public long? AGRUPACION { get; set; }
	}
}
