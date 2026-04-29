using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_ARBOL_OPERATIVO")]
	public partial class MA_ARBOL_OPERATIVO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public bool TITULO { get; set; }
		[Column()]
		public bool DADA_DE_BAJA { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
