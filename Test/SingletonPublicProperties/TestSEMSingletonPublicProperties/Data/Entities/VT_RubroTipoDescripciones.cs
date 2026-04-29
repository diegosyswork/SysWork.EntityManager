using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "VT_RubroTipoDescripciones")]
	public partial class VT_RubroTipoDescripciones
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
		public string IDFAMILIA { get; set; }
		[Column()]
		public string DescrFamilias { get; set; }
	}
}
