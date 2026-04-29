using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_Choferes")]
	public partial class MA_Choferes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string APELLIDO { get; set; }
		[Column()]
		public string NOMBRES { get; set; }
		[Column()]
		public string TIPO_DOC { get; set; }
		[Column()]
		public string NRO_DOCUMENTO { get; set; }
		[Column()]
		public string LIBRETA_SANITARIA { get; set; }
		[Column()]
		public string REGISTRO { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO_REGISTRO { get; set; }
		[Column()]
		public string SEGURO { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO_SEGURO { get; set; }
		[Column()]
		public string DOMICILIO { get; set; }
		[Column()]
		public string LOCALIDAD { get; set; }
		[Column()]
		public string SAP { get; set; }
		[Column()]
		public string MOVILINK { get; set; }
		[Column()]
		public string TEL_PARTICULAR { get; set; }
		[Column()]
		public string TEL_CELULAR { get; set; }
		[Column()]
		public string SKYCOP { get; set; }
		[Column()]
		public string VEHICULO { get; set; }
		[Column()]
		public bool ACTIVO { get; set; }
		[Column()]
		public bool DISPONIBLE { get; set; }
		[Column()]
		public string CUENTAPROVEEDOR { get; set; }
		[Column()]
		public bool AUTORIZACION_MANEJO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public string CATEGORIA_REGISTRO { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
	}
}
