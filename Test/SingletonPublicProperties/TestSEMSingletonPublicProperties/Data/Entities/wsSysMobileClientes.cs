using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "wsSysMobileClientes")]
	public partial class wsSysMobileClientes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CODIGO { get; set; }
		[Column()]
		public string codigoOpcional { get; set; }
		[Column()]
		public string RAZON_SOCIAL { get; set; }
		[Column()]
		public string CALLE { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string PISO { get; set; }
		[Column()]
		public string DEPARTAMENTO { get; set; }
		[Column()]
		public string localidad { get; set; }
		[Column()]
		public string numero_documento { get; set; }
		[Column()]
		public string iva { get; set; }
		[Column()]
		public Int16 Clase { get; set; }
		[Column()]
		public double descuento { get; set; }
		[Column()]
		public string cpteDefault { get; set; }
		[Column()]
		public string idVendedor { get; set; }
		[Column()]
		public string TELEFONO { get; set; }
		[Column()]
		public string MAIL { get; set; }
	}
}
