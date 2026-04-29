using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "V_COBRANZASPORUSUARIO")]
	public partial class V_COBRANZASPORUSUARIO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public long MES_OPERATIVO { get; set; }
		[Column( Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column()]
		public string NroComprobante { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string MedioDePago { get; set; }
		[Column()]
		public string USUARIO_LOGEADO { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public string MONEDA { get; set; }
		[Column()]
		public decimal? COTIZACION { get; set; }
		[Column()]
		public long? ID_COTIZ { get; set; }
		[Column()]
		public string IdBanco { get; set; }
		[Column()]
		public long? Clearing { get; set; }
		[Column()]
		public string NroComprobanteBancario { get; set; }
		[Column()]
		public bool ChPropio { get; set; }
		[Column()]
		public string TJ_NroSocio { get; set; }
		[Column()]
		public string TJ_NroCupon { get; set; }
		[Column()]
		public long? TJ_Cuotas { get; set; }
		[Column()]
		public string TJ_Autorizo { get; set; }
		[Column()]
		public string TJ_Observaciones { get; set; }
		[Column()]
		public string DETALLE { get; set; }
		[Column()]
		public string IdCaja { get; set; }
		[Column()]
		public string CodigoOpcional { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
	}
}
