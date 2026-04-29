using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_FIDELIZACION_ARTICULOS")]
	public partial class V_FIDELIZACION_ARTICULOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDARTICULO { get; set; }
		[Column()]
		public decimal? IMPORTE_P_ACUMULAR { get; set; }
		[Column()]
		public long? CANTIDAD_P_ACUMULAR { get; set; }
		[Column()]
		public long PUNTOS_QUE_ACUMULA { get; set; }
	}
}
