using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_CUENTAS_ARCHIVOS_RELACIONADOS")]
	public partial class MA_CUENTAS_ARCHIVOS_RELACIONADOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public string RUTA_ARCHIVO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
	}
}
