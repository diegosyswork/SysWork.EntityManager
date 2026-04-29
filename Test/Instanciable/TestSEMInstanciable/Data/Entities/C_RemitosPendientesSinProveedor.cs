using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "C_RemitosPendientesSinProveedor")]
	public partial class C_RemitosPendientesSinProveedor
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
		public string TC_Facturado { get; set; }
		[Column()]
		public string IdComprobante_Facturado { get; set; }
		[Column()]
		public string CUENTA { get; set; }
	}
}
