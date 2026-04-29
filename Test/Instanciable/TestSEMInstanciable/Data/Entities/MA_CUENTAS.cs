using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_CUENTAS")]
	public partial class MA_CUENTAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public Int16? DV { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public bool TITULO { get; set; }
		[Column()]
		public bool AJUSTE { get; set; }
		[Column()]
		public Int16? INDICE { get; set; }
		[Column()]
		public bool BLOQUEO { get; set; }
		[Column()]
		public string MANUAL { get; set; }
		[Column()]
		public string MANUAL_HABER { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public bool Libro_Iva_Compras { get; set; }
		[Column()]
		public bool Libro_Iva_Ventas { get; set; }
		[Column()]
		public bool Bienes { get; set; }
		[Column()]
		public string Codigo_Deprec_Acumulada { get; set; }
		[Column()]
		public string Codigo_Deprec_Ejercicio { get; set; }
		[Column()]
		public bool Dada_De_Baja { get; set; }
		[Column()]
		public string TipoVista { get; set; }
		[Column()]
		public bool PideVencimiento { get; set; }
		[Column()]
		public string CuentaPrincipal { get; set; }
		[Column()]
		public bool CajaYBanco { get; set; }
		[Column()]
		public string CodigoOpcional { get; set; }
		[Column()]
		public string MedioDePago { get; set; }
		[Column()]
		public string IDMONEDA { get; set; }
		[Column()]
		public bool MEDIBLE_PF { get; set; }
		[Column()]
		public string USUARIO_ALTA { get; set; }
		[Column()]
		public DateTime? FECHA_ALTA { get; set; }
	}
}
