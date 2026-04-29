using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_ESTADISTICACTA")]
	public partial class MA_ESTADISTICACTA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string GRUPO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public bool DEBE { get; set; }
		[Column()]
		public bool HABER { get; set; }
		[Column()]
		public long TipoGrafico { get; set; }
		[Column()]
		public DateTime? FECHAD { get; set; }
		[Column()]
		public DateTime? FECHAH { get; set; }
		[Column()]
		public long? PERIODICIDAD { get; set; }
		[Column()]
		public string CuentaD { get; set; }
		[Column()]
		public string CuentaH { get; set; }
		[Column()]
		public string VendedorD { get; set; }
		[Column()]
		public string VendedorH { get; set; }
		[Column()]
		public string ProvinciaD { get; set; }
		[Column()]
		public string ProvinciaH { get; set; }
		[Column()]
		public string CPostalD { get; set; }
		[Column()]
		public string CPostalH { get; set; }
		[Column()]
		public string Comprobantes { get; set; }
		[Column()]
		public long? Ranking { get; set; }
		[Column()]
		public string Agrupar { get; set; }
		[Column()]
		public bool EsRanking { get; set; }
	}
}
