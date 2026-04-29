using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_CUENTAS_INFORMES")]
	public partial class MA_CUENTAS_INFORMES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TIPO_INFORME { get; set; }
		[Column( IsPrimaryKey = true)]
		public long NRO_INFORME { get; set; }
		[Column()]
		public DateTime FECHA { get; set; }
		[Column()]
		public string INFORME { get; set; }
		[Column()]
		public string RESPONSABLE { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public string HIS_CALIFICACION { get; set; }
		[Column()]
		public DateTime? HIS_VENCIMIENTO_CALIFICACION { get; set; }
		[Column()]
		public bool HIS_ISO { get; set; }
	}
}
