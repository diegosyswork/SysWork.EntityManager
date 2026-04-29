using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VT_RankingConsumo")]
	public partial class VT_RankingConsumo
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public double? Consumo { get; set; }
		[Column()]
		public double? ValorVenta { get; set; }
		[Column()]
		public double? ValorCosto { get; set; }
		[Column()]
		public string CUENTA { get; set; }
	}
}
