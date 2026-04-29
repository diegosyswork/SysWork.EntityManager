using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MA_Precios")]
	public partial class V_MA_Precios
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IdLista { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Nombre { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdArticulo { get; set; }
		[Column()]
		public bool ConIVA { get; set; }
		[Column()]
		public decimal Precio1 { get; set; }
		[Column()]
		public decimal Precio2 { get; set; }
		[Column()]
		public decimal Precio3 { get; set; }
		[Column()]
		public decimal Precio4 { get; set; }
		[Column()]
		public decimal Precio5 { get; set; }
		[Column()]
		public string IdMoneda { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TipoLista { get; set; }
		[Column()]
		public string FCOSTO { get; set; }
		[Column()]
		public string FCLASE1 { get; set; }
		[Column()]
		public string FCLASE2 { get; set; }
		[Column()]
		public string FCLASE3 { get; set; }
		[Column()]
		public string FCLASE4 { get; set; }
		[Column()]
		public string FCLASE5 { get; set; }
		[Column()]
		public string FCLASE6 { get; set; }
		[Column()]
		public string FCLASE7 { get; set; }
		[Column()]
		public string FCLASE8 { get; set; }
		[Column()]
		public string FCLASE9 { get; set; }
		[Column()]
		public string FCLASE10 { get; set; }
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
		public double? MK_PRECIO1 { get; set; }
		[Column()]
		public double? MK_PRECIO2 { get; set; }
		[Column()]
		public double? MK_PRECIO3 { get; set; }
		[Column()]
		public double? MK_PRECIO4 { get; set; }
		[Column()]
		public double? MK_PRECIO5 { get; set; }
		[Column()]
		public double? MK_PRECIO6 { get; set; }
		[Column()]
		public double? MK_PRECIO7 { get; set; }
		[Column()]
		public double? MK_PRECIO8 { get; set; }
		[Column()]
		public double? MK_PRECIO9 { get; set; }
		[Column()]
		public double? MK_PRECIO10 { get; set; }
	}
}
