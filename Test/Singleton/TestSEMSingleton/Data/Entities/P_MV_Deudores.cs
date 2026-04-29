using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MV_Deudores")]
	public partial class P_MV_Deudores
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public DateTime Fecha { get; set; }
		[Column()]
		public string IdCliente { get; set; }
		[Column()]
		public long IdBusqueda { get; set; }
		[Column()]
		public decimal? ImporteFacturar { get; set; }
		[Column()]
		public decimal? ImportePagado { get; set; }
		[Column()]
		public DateTime? FechaPago { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public string Usuario { get; set; }
	}
}
