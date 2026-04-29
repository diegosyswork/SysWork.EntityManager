using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CASHPFE_DETALLE")]
	public partial class MA_CASHPFE_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CODIGO_CASHPFE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_GRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_SUBGRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public long? CANTIDAD { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public decimal? IMPORTEUNITARIO { get; set; }
		[Column()]
		public decimal? TOTAL { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
