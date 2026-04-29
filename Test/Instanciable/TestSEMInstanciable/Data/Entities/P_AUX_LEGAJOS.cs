using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "P_AUX_LEGAJOS")]
	public partial class P_AUX_LEGAJOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long Id { get; set; }
		[Column()]
		public string DESCR_TIPODOCUMENTO { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
	}
}
