using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_COMBOS")]
	public partial class V_TA_COMBOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdCombo { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public DateTime? ValidoDesde { get; set; }
		[Column()]
		public DateTime? ValidoHasta { get; set; }
		[Column()]
		public string Mensaje { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? PRECIO1 { get; set; }
		[Column()]
		public decimal? PRECIO2 { get; set; }
		[Column()]
		public decimal? PRECIO3 { get; set; }
		[Column()]
		public decimal? PRECIO4 { get; set; }
		[Column()]
		public decimal? PRECIO5 { get; set; }
		[Column()]
		public decimal? PRECIO6 { get; set; }
		[Column()]
		public decimal? PRECIO7 { get; set; }
		[Column()]
		public decimal? PRECIO8 { get; set; }
		[Column()]
		public decimal? PRECIO9 { get; set; }
		[Column()]
		public decimal? PRECIO10 { get; set; }
		[Column()]
		public string URL1 { get; set; }
		[Column()]
		public string URL2 { get; set; }
		[Column()]
		public string URL3 { get; set; }
		[Column()]
		public string URL4 { get; set; }
		[Column()]
		public string URL5 { get; set; }
		[Column()]
		public string URL6 { get; set; }
		[Column()]
		public string INFORMACION_ADICIONAL { get; set; }
		[Column()]
		public string INFORMACION_ADICIONAL_TEXTO { get; set; }
		[Column()]
		public bool PUBLICAR_EN_MERCADOLIBRE { get; set; }
		[Column()]
		public string ID_PUBLICACION_MERCADOLIBRE { get; set; }
		[Column()]
		public string ID_CATEGORIA_MERCADOLIBRE { get; set; }
	}
}
