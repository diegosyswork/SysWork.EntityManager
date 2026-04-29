using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CONTACTOS_ADIC")]
	public partial class MA_CONTACTOS_ADIC
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column()]
		public long IdContacto { get; set; }
		[Column()]
		public string TipoAdic { get; set; }
		[Column()]
		public string DescrAdic { get; set; }
	}
}
