using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "v_mv_creales")]
	public partial class v_mv_creales
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column()]
		public DateTime Fecha { get; set; }
		[Column()]
		public string Cuenta { get; set; }
		[Column()]
		public string Matricula { get; set; }
		[Column()]
		public string Concepto { get; set; }
		[Column()]
		public string Responsable { get; set; }
		[Column()]
		public decimal? Importe { get; set; }
		[Column()]
		public string Debe_Haber { get; set; }
		[Column()]
		public bool Anulado { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IdComprobante { get; set; }
		[Column()]
		public long? IdComplemento { get; set; }
		[Column()]
		public string Observaciones { get; set; }
	}
}
