using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MV_CALCULO_BIENES")]
	public partial class MV_CALCULO_BIENES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public double CODIGO { get; set; }
		[Column( IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public long PERIODO { get; set; }
		[Column()]
		public DateTime? FECHA_CIERRE { get; set; }
		[Column()]
		public string PERIODO_DE_CALCULO { get; set; }
		[Column()]
		public decimal? COSTO { get; set; }
		[Column()]
		public double? COEFICIENTE { get; set; }
		[Column()]
		public decimal? CA_VC { get; set; }
		[Column()]
		public double? PORCENTAJE_DEP { get; set; }
		[Column()]
		public decimal? VALOR_RECUPERO { get; set; }
		[Column()]
		public decimal? DEP_EJERCICIO { get; set; }
		[Column()]
		public decimal? DEP_ACUMULADA { get; set; }
		[Column()]
		public decimal? DEP_AJUSTADA { get; set; }
		[Column()]
		public decimal? DIF_DEP_AJUSTADA { get; set; }
		[Column()]
		public byte? AST_MES_OPERATIVO { get; set; }
		[Column()]
		public long? AST_NRO_ASIENTO { get; set; }
		[Column()]
		public long? IDCONTROL { get; set; }
	}
}
