using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_BIENES_NOVEDADES")]
	public partial class MA_BIENES_NOVEDADES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public double CODIGO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public double? COSTO { get; set; }
		[Column()]
		public decimal? VALOR_RECUPERO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public long? PERIODO { get; set; }
		[Column()]
		public long? PERIODO_REVALUACION { get; set; }
		[Column()]
		public byte? MES_OPERATIVO { get; set; }
		[Column()]
		public long NRO_ASIENTO { get; set; }
		[Column()]
		public string TIPO_REG { get; set; }
		[Column()]
		public long VIDA_UTIL { get; set; }
		[Column()]
		public double PORCENTAJE { get; set; }
	}
}
