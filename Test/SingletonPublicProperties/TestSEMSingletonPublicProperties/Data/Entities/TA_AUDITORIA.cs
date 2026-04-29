using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "TA_AUDITORIA")]
	public partial class TA_AUDITORIA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public DateTime FECHA_HORA { get; set; }
		[Column()]
		public string PC { get; set; }
		[Column()]
		public string USUARIO_WINDOWS { get; set; }
		[Column()]
		public string USUARIO_SISTEMA { get; set; }
		[Column()]
		public string EJECUTABLE { get; set; }
		[Column()]
		public string LINEA_COMANDOS { get; set; }
		[Column()]
		public string ACCION { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column()]
		public long? COMPLEMENTO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public DateTime? FECHA_CPTE { get; set; }
		[Column()]
		public string SENTENCIA_SQL { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
