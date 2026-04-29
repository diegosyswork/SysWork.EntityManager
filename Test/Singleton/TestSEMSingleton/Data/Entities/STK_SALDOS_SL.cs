using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "STK_SALDOS_SL")]
	public partial class STK_SALDOS_SL
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string Equivalencia { get; set; }
		[Column()]
		public double? Stock { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string NroSerie { get; set; }
		[Column()]
		public string NroLote { get; set; }
	}
}
