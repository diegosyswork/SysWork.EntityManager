using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "V_ConsultaDeRubroTipoProveerdorArticulos")]
	public partial class V_ConsultaDeRubroTipoProveerdorArticulos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IDRUBRO { get; set; }
		[Column()]
		public string DescrRubros { get; set; }
		[Column()]
		public string IDTIPO { get; set; }
		[Column()]
		public string DescrTipo { get; set; }
		[Column()]
		public string Proveedor { get; set; }
		[Column()]
		public string RAZON_SOCIAL { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
	}
}
