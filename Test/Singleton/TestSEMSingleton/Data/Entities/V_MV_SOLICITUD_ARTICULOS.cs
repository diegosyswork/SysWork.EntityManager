using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MV_SOLICITUD_ARTICULOS")]
	public partial class V_MV_SOLICITUD_ARTICULOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public DateTime Fecha { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Usuario { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdArticulo { get; set; }
		[Column()]
		public double? Cantidad { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public string CPTE_PEDIDO { get; set; }
		[Column()]
		public DateTime? FECHA_PEDIDO { get; set; }
		[Column()]
		public string CPTE_INGRESO { get; set; }
		[Column()]
		public DateTime? FECHA_INGRESO { get; set; }
		[Column()]
		public string IDVENDEDOR { get; set; }
	}
}
