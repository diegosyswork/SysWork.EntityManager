using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "S_TA_EQUIV")]
	public partial class S_TA_EQUIV
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
		public string IDUNIDAD { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDUNIDAD_EQUIV { get; set; }
		[Column()]
		public double COEFICIENTE { get; set; }
		[Column()]
		public string TIPO_COEFICIENTE { get; set; }
		[Column()]
		public long? FORZAR_CLASE_PRECIO { get; set; }
	}
}
