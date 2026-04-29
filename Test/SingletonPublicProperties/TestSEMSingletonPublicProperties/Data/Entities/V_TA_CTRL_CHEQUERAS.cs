using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_CTRL_CHEQUERAS")]
	public partial class V_TA_CTRL_CHEQUERAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDBANCO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SERIE { get; set; }
		[Column()]
		public double NUMERO_DESDE { get; set; }
		[Column()]
		public double NUMERO_HASTA { get; set; }
		[Column()]
		public string CuentaBanco { get; set; }
		[Column()]
		public string CuentaBancoDiferido { get; set; }
		[Column()]
		public string MASCARA_IMPRESION { get; set; }
	}
}
