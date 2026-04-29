using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "UTL_TA_VENTANAS")]
	public partial class UTL_TA_VENTANAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SISTEMA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string USUARIO_PC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string USUARIO_SISTEMA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string VENTANA { get; set; }
		[Column()]
		public double? WIDTH { get; set; }
		[Column()]
		public double? HEIGTH { get; set; }
		[Column()]
		public double? TTOP { get; set; }
		[Column()]
		public double? LLEFT { get; set; }
		[Column()]
		public string CLAVES { get; set; }
		[Column()]
		public string TIPOVISTA { get; set; }
	}
}
