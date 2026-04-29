using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "RANKING_CONSUMO")]
	public partial class RANKING_CONSUMO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long? IDCOMPLEMENTO { get; set; }
		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public string IDUnidad { get; set; }
		[Column()]
		public double? Cantidad { get; set; }
		[Column()]
		public string IdUnidadBase { get; set; }
		[Column()]
		public double? CantidadUD { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA_EQ { get; set; }
	}
}
