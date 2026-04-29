using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_VENDEDORES")]
	public partial class V_TA_VENDEDORES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdVendedor { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string Domicilio { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public string IdProvincia { get; set; }
		[Column()]
		public string CodigoPostal { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
		[Column()]
		public string NumeroDocumento { get; set; }
		[Column()]
		public string IdCondIva { get; set; }
		[Column()]
		public string Telefono { get; set; }
		[Column()]
		public string E_Mail { get; set; }
		[Column()]
		public string http { get; set; }
		[Column()]
		public double? Porc_Venta { get; set; }
		[Column()]
		public double? Porc_Cobranza { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
		[Column()]
		public string IDDeposito { get; set; }
		[Column()]
		public string CodigoValidacion { get; set; }
		[Column()]
		public bool ACTIVO { get; set; }
		[Column()]
		public string IDSECTOR { get; set; }
		[Column()]
		public bool AUTORIZACION_AL_GENERAR_FC_DE_NP_CON_DIST_DEP { get; set; }
		[Column()]
		public string DEPOSITOS_QUE_AUTORIZA { get; set; }
	}
}
