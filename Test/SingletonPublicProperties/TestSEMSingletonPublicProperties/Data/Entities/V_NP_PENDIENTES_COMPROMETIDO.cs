using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "V_NP_PENDIENTES_COMPROMETIDO")]
	public partial class V_NP_PENDIENTES_COMPROMETIDO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public double? Comprometido { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
	}
}
