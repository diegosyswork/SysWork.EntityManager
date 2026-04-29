using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VT_MA_PRECIOS_ARTICULOS")]
	public partial class VT_MA_PRECIOS_ARTICULOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IdLista { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string IdArticulo { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string CUENTAPROVEEDOR { get; set; }
		[Column()]
		public string IDRUBRO { get; set; }
		[Column()]
		public string IDTIPO { get; set; }
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
		public decimal? COSTO { get; set; }
		[Column()]
		public bool ConIVA { get; set; }
		[Column()]
		public string TipoLista { get; set; }
		[Column()]
		public string IdMoneda { get; set; }
		[Column()]
		public bool EXENTO { get; set; }
	}
}
