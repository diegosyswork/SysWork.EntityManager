using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_COMBOS_DETALLE")]
	public partial class V_TA_COMBOS_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdCombo { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdArticulo { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdUnidad { get; set; }
		[Column( IsPrimaryKey = true)]
		public double Cantidad { get; set; }
		[Column()]
		public long? Clase { get; set; }
		[Column()]
		public decimal? PrecioSinIva { get; set; }
	}
}
