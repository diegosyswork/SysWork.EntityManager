using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "TA_USUARIOS")]
	public partial class TA_USUARIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string NOMBRE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SISTEMA { get; set; }
		[Column()]
		public string PASSWORD { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public bool CambiarProximoInicio { get; set; }
		[Column()]
		public string IdCaja { get; set; }
		[Column()]
		public string IdVendedor { get; set; }
		[Column()]
		public decimal? CreditoFiscal { get; set; }
		[Column()]
		public bool ModificaDescuentos { get; set; }
		[Column()]
		public bool ModificaPrecios { get; set; }
		[Column()]
		public bool CantidadesNegativas { get; set; }
		[Column()]
		public string MPEFAsoc { get; set; }
		[Column()]
		public string CtaCFAsoc { get; set; }
		[Column()]
		public string MPHabilitados { get; set; }
		[Column()]
		public bool ModificaListas { get; set; }
		[Column()]
		public bool ModificaListasItem { get; set; }
		[Column()]
		public bool ModificaClases { get; set; }
		[Column()]
		public bool ModificaClasesItem { get; set; }
		[Column()]
		public bool ModificaDescuentosItem { get; set; }
		[Column()]
		public bool ModificaDeposito { get; set; }
		[Column()]
		public bool ModificaDepositoItem { get; set; }
		[Column()]
		public bool ModificaCondicionVta { get; set; }
		[Column()]
		public bool ModificaMotivoVta { get; set; }
		[Column()]
		public bool ModificaRecargo { get; set; }
		[Column()]
		public bool ModificaVendedorAsociado { get; set; }
		[Column()]
		public string DepositoAsociado { get; set; }
		[Column()]
		public string IdTecnico { get; set; }
		[Column()]
		public string SucursalAsociada { get; set; }
		[Column()]
		public string ClasesDePreciosAutorizadas { get; set; }
		[Column()]
		public string ListasDePreciosAutorizadas { get; set; }
		[Column()]
		public bool ModificaPuntoDeVenta { get; set; }
		[Column()]
		public bool ModificaAlicuotasIVA { get; set; }
		[Column()]
		public bool OCULTAR_IMPORTES_EN_ARTICULOS { get; set; }
		[Column()]
		public bool MuestraChequesPendientes { get; set; }
		[Column()]
		public bool ConsultaUltimosPreciosDeVenta { get; set; }
		[Column()]
		public bool ConsultaStockOtrosDepositos { get; set; }
		[Column()]
		public bool ConsultaProximosIngresos { get; set; }
		[Column()]
		public bool PuedeSolicitarReposicion { get; set; }
		[Column()]
		public bool VENTAS_FACTURA_MULTIMONEDA { get; set; }
		[Column()]
		public bool COMPRAS_FACTURA_MULTIMONEDA { get; set; }
		[Column()]
		public bool EditaInformes_CL_PR { get; set; }
		[Column()]
		public string TerminalesAutorizadas { get; set; }
		[Column()]
		public bool V_NO_HABILITAR_SERVICIOS { get; set; }
		[Column()]
		public bool V_NO_HABILITAR_ARTICULOS { get; set; }
		[Column()]
		public bool V_NO_HABILITAR_OC { get; set; }
		[Column()]
		public bool VENTAS_COTIZACION_LIBRE { get; set; }
		[Column()]
		public bool AUTORIZAR_CUENTAS_AUTOMATICAMENTE { get; set; }
		[Column()]
		public bool PUEDE_DAR_PERMISOS_USUARIOS_CUENTAS { get; set; }
		[Column()]
		public bool NoModificaLimiteDeCredito { get; set; }
		[Column()]
		public bool MuestraRentabilidadEnPresupuestos { get; set; }
		[Column()]
		public bool MuestraRentabilidadEnComprobantesDeVentas { get; set; }
	}
}
