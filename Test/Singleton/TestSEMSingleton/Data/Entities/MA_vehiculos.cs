using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_vehiculos")]
	public partial class MA_vehiculos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string PATENTE { get; set; }
		[Column()]
		public string TIPO_VEHICULO { get; set; }
		[Column()]
		public string MARCA { get; set; }
		[Column()]
		public string MODELO { get; set; }
		[Column()]
		public long? ANIO { get; set; }
		[Column()]
		public string VTV { get; set; }
		[Column()]
		public DateTime? VTO_VTV { get; set; }
		[Column()]
		public string C_VERDE { get; set; }
		[Column()]
		public DateTime? VTO_C_VERDE { get; set; }
		[Column()]
		public string SEGURO { get; set; }
		[Column()]
		public DateTime? VTO_SEGURO { get; set; }
		[Column()]
		public string H_SUST_ALIM { get; set; }
		[Column()]
		public bool CARGA_LATERAL { get; set; }
		[Column()]
		public bool CARGA_FRONTAL { get; set; }
		[Column()]
		public double? CAP_PALLETS { get; set; }
		[Column()]
		public double? CAP_KILOS { get; set; }
		[Column()]
		public double? CAP_M3 { get; set; }
		[Column()]
		public string TIPO { get; set; }
		[Column()]
		public string SEMI_ASOCIADO { get; set; }
		[Column()]
		public bool DISPONIBLE { get; set; }
		[Column()]
		public bool FLOTA_BASE { get; set; }
		[Column()]
		public bool PUBLICIDAD { get; set; }
		[Column()]
		public string CUENTAPROVEEDOR { get; set; }
		[Column()]
		public bool FRIO { get; set; }
		[Column()]
		public bool RUTA { get; set; }
		[Column()]
		public bool LEASING { get; set; }
		[Column()]
		public string NRO_OBLEA_GNC { get; set; }
		[Column()]
		public DateTime? VTO_OBLEA_GNC { get; set; }
		[Column()]
		public string NRO_PHIDRA_GNC { get; set; }
		[Column()]
		public DateTime? VTO_PHIDRA_GNC { get; set; }
		[Column()]
		public DateTime? VTO_BATERIA { get; set; }
		[Column()]
		public DateTime? VTO_INSPECCION { get; set; }
		[Column()]
		public bool RASTREADOR { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
		[Column()]
		public string NRO_INTERNO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public long? ULTIMA_LECTURA_KM { get; set; }
		[Column()]
		public long? ULTIMA_LECTURA_HS { get; set; }
		[Column()]
		public string ASIGNADO { get; set; }
		[Column()]
		public string PROVINCIA_PATENTAMIENTO { get; set; }
	}
}
