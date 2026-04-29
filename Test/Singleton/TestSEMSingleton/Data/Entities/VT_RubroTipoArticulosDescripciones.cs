using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_RubroTipoArticulosDescripciones")]
	public partial class VT_RubroTipoArticulosDescripciones
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string CODIGOBARRA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string CUENTAPROVEEDOR { get; set; }
		[Column()]
		public string NombreProveedor { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public string IDRUBRO { get; set; }
		[Column()]
		public string DescrRubros { get; set; }
		[Column()]
		public string IDTIPO { get; set; }
		[Column()]
		public string DescrTipo { get; set; }
		[Column()]
		public bool USASERIE { get; set; }
		[Column()]
		public bool USALOTE { get; set; }
		[Column()]
		public bool EXENTO { get; set; }
		[Column()]
		public string NOTAS { get; set; }
		[Column()]
		public long? PUNTOPEDIDO { get; set; }
		[Column()]
		public decimal? COSTO { get; set; }
		[Column()]
		public decimal? IMPUESTOS { get; set; }
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
		public bool SUSPENDIDO { get; set; }
		[Column()]
		public long? PUNTOMAXIMO { get; set; }
		[Column()]
		public string IDFAMILIA { get; set; }
		[Column()]
		public string DescrFamilias { get; set; }
	}
}
