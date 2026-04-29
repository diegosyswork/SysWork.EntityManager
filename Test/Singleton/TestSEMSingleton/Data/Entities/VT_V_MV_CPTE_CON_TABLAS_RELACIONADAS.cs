using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_V_MV_CPTE_CON_TABLAS_RELACIONADAS")]
	public partial class VT_V_MV_CPTE_CON_TABLAS_RELACIONADAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public DateTime? FECHA_FACTURACION { get; set; }
		[Column()]
		public DateTime? fechahora_grabacion { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string CODIGOOPCIONAL { get; set; }
		[Column()]
		public string RAZON_SOCIAL { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string DOMICILIO { get; set; }
		[Column()]
		public string TELEFONO { get; set; }
		[Column()]
		public string LOCALIDAD { get; set; }
		[Column()]
		public string IDPROVINCIA { get; set; }
		[Column()]
		public string DOCUMENTOTIPO { get; set; }
		[Column()]
		public string DOCUMENTONUMERO { get; set; }
		[Column()]
		public string CONDICIONIVA { get; set; }
		[Column()]
		public string IDCOND_CPRA_VTA { get; set; }
		[Column()]
		public long? CLASEPRECIO { get; set; }
		[Column()]
		public string COMENTARIOS { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public bool FINALIZADA { get; set; }
		[Column()]
		public bool APROBADO { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string USUARIO_LOGUEADO { get; set; }
		[Column()]
		public string IDESTADO_CRM { get; set; }
	}
}
