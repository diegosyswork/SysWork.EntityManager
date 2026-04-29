using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "v_mv_CargosAplicados")]
	public partial class v_mv_CargosAplicados
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
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
		public string Observaciones { get; set; }
		[Column()]
		public decimal? Saldo { get; set; }
		[Column()]
		public decimal? Importe { get; set; }
	}
}
