using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "EM_MV_PESADAS_TRIGO")]
	public partial class EM_MV_PESADAS_TRIGO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long IDPESADA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TIPO_PESADA { get; set; }
		[Column()]
		public DateTime? FECHA_OPERATIVA { get; set; }
		[Column()]
		public DateTime? FH_INGRESO { get; set; }
		[Column()]
		public DateTime? FH_EGRESO { get; set; }
		[Column()]
		public string PATENTE { get; set; }
		[Column()]
		public string PATENTE_ACOPLADO { get; set; }
		[Column()]
		public long? CANTIDAD_EJES { get; set; }
		[Column()]
		public string PROCEDENCIA { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public double? PESO_ING_EJE_1 { get; set; }
		[Column()]
		public double? PESO_ING_EJE_2 { get; set; }
		[Column()]
		public double? PESO_ING_EJE_3 { get; set; }
		[Column()]
		public double? PESO_ING_EJE_4 { get; set; }
		[Column()]
		public double? PESO_ING_EJE_5 { get; set; }
		[Column()]
		public double? PESO_ING_EJE_6 { get; set; }
		[Column()]
		public double? PESO_EGR_EJE_1 { get; set; }
		[Column()]
		public double? PESO_EGR_EJE_2 { get; set; }
		[Column()]
		public double? PESO_EGR_EJE_3 { get; set; }
		[Column()]
		public double? PESO_EGR_EJE_4 { get; set; }
		[Column()]
		public double? PESO_EGR_EJE_5 { get; set; }
		[Column()]
		public double? PESO_EGR_EJE_6 { get; set; }
		[Column()]
		public double? PESO_TOTAL { get; set; }
		[Column()]
		public double? HUMEDAD { get; set; }
		[Column()]
		public double? PORC_TRIGO { get; set; }
		[Column()]
		public double? PORC_AFRE { get; set; }
		[Column()]
		public double? PESO_TRIGO { get; set; }
		[Column()]
		public double? PESO_AFRECHILLO { get; set; }
		[Column()]
		public long? CANTIDAD_BOLSAS { get; set; }
	}
}
