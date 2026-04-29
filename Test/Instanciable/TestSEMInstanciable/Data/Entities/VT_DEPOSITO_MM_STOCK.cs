using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VT_DEPOSITO_MM_STOCK")]
	public partial class VT_DEPOSITO_MM_STOCK
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long ID { get; set; }
		[Column()]
		public string Deposito { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string IdRubro { get; set; }
		[Column()]
		public string rubroDescripcion { get; set; }
		[Column()]
		public string ProveedorCodigo { get; set; }
		[Column()]
		public string ProveedorDescripcion { get; set; }
		[Column()]
		public string Marca { get; set; }
		[Column()]
		public double Minimo { get; set; }
		[Column()]
		public double Maximo { get; set; }
		[Column()]
		public string DDMM_DESDE { get; set; }
		[Column()]
		public string DDMM_HASTA { get; set; }
		[Column()]
		public double MINIMO_DDMM { get; set; }
		[Column()]
		public double MAXIMO_DDMM { get; set; }
		[Column()]
		public string UBICACION_HABITUAL { get; set; }
		[Column()]
		public double STOCK { get; set; }
		[Column()]
		public string IdTipo { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public string CODIGOBARRA { get; set; }
	}
}
