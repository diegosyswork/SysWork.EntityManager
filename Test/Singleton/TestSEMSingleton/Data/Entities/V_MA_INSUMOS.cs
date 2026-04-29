using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MA_INSUMOS")]
	public partial class V_MA_INSUMOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdArticulo { get; set; }
		[Column()]
		public string IdUnidadInsumo { get; set; }
		[Column()]
		public string IdArticuloInsumo { get; set; }
		[Column()]
		public double? Cantidad { get; set; }
		[Column()]
		public string TIPOINS { get; set; }
		[Column()]
		public string IDTAREA { get; set; }
		[Column()]
		public string DESCRIPCION_OC { get; set; }
		[Column()]
		public decimal? IMPORTE_OC { get; set; }
	}
}
