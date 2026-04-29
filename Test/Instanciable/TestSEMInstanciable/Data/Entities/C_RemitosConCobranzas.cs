using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "C_RemitosConCobranzas")]
	public partial class C_RemitosConCobranzas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string TC_ORIGEN { get; set; }
		[Column()]
		public string COMPROBANTE_ORIGEN { get; set; }
		[Column()]
		public string Cuenta { get; set; }
	}
}
