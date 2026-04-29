using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CASHPFE")]
	public partial class MA_CASHPFE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public bool MODIFICADO { get; set; }
		[Column()]
		public decimal PRECIO_OFERTA { get; set; }
		[Column()]
		public decimal RESULTADO_DESEADO { get; set; }
		[Column()]
		public decimal PORC_DESEADO { get; set; }
	}
}
