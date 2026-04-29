using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MV_CpteTerceros")]
	public partial class V_MV_CpteTerceros
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string DETALLE { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string MATRICULA { get; set; }
		[Column()]
		public string ENVIADOPOR { get; set; }
		[Column()]
		public DateTime? FECHAENVIADO { get; set; }
		[Column()]
		public string RECIBIDOPOR { get; set; }
		[Column()]
		public DateTime? FECHARECIBIDO { get; set; }
		[Column()]
		public string REMITO { get; set; }
		[Column()]
		public string FACTURA { get; set; }
		[Column()]
		public decimal? ImportePresupuestado { get; set; }
		[Column()]
		public decimal? Importe { get; set; }
	}
}
