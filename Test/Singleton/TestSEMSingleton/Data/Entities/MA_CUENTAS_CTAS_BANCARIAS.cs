using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CUENTAS_CTAS_BANCARIAS")]
	public partial class MA_CUENTAS_CTAS_BANCARIAS
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
		public string TIPO_CTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDBANCO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SUCURSAL { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NUMERO { get; set; }
		[Column()]
		public string TITULAR { get; set; }
		[Column()]
		public string DNI_CUIT { get; set; }
		[Column()]
		public string CBU { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
