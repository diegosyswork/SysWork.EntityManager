using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "AUX_MAYORES")]
	public partial class AUX_MAYORES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string USUARIO { get; set; }
		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string CCOSTO { get; set; }
		[Column()]
		public decimal? SALDO_ANTERIOR { get; set; }
		[Column()]
		public decimal? SALDO_PERIODO { get; set; }
		[Column()]
		public decimal? SALDO_ACTUAL { get; set; }
		[Column( Name = "NUMERO ASIENTO")]
		public long? NUMEROASIENTO { get; set; }
		[Column()]
		public string SECUENCIA { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
		[Column()]
		public string DETALLE { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column( Name = "IMPORTE-DEBE")]
		public decimal? IMPORTEDEBE { get; set; }
		[Column( Name = "IMPORTE-HABER")]
		public decimal? IMPORTEHABER { get; set; }
		[Column()]
		public decimal? SALDO_PARCIAL { get; set; }
		[Column()]
		public string Tipo_Reg { get; set; }
		[Column()]
		public string TituloCopiador { get; set; }
		[Column()]
		public string NroComprobanteBancario { get; set; }
		[Column()]
		public string ConVto { get; set; }
		[Column()]
		public string OrdenDeCompra { get; set; }
		[Column()]
		public string AP_TCO { get; set; }
		[Column()]
		public string AP_SUCURSAL { get; set; }
		[Column()]
		public string AP_NUMERO { get; set; }
		[Column()]
		public string AP_LETRA { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public string IdComprobante { get; set; }
		[Column()]
		public bool EsSaldoApertura { get; set; }
		[Column()]
		public long? ID_COTIZ { get; set; }
		[Column()]
		public decimal SALDOMONEDA { get; set; }
		[Column()]
		public decimal? ADICIONAL1 { get; set; }
		[Column()]
		public decimal? ADICIONAL2 { get; set; }
		[Column()]
		public decimal? ADICIONAL3 { get; set; }
		[Column()]
		public decimal? ADICIONAL4 { get; set; }
		[Column()]
		public decimal? ADICIONAL5 { get; set; }
		[Column()]
		public decimal? ADICIONAL6 { get; set; }
		[Column()]
		public decimal? ADICIONAL7 { get; set; }
		[Column()]
		public decimal? ADICIONAL8 { get; set; }
		[Column()]
		public decimal? ADICIONAL9 { get; set; }
		[Column()]
		public decimal? ADICIONAL10 { get; set; }
		[Column()]
		public decimal? ADICIONAL11 { get; set; }
		[Column()]
		public decimal? ADICIONAL12 { get; set; }
		[Column()]
		public decimal? ADICIONAL13 { get; set; }
		[Column()]
		public decimal? ADICIONAL14 { get; set; }
		[Column()]
		public decimal? ADICIONAL15 { get; set; }
	}
}
