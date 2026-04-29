using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "TA_COMPROBANTES")]
	public partial class TA_COMPROBANTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string SISTEMA { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public string ES { get; set; }
		[Column()]
		public bool PIDEVENCIMIENTO { get; set; }
		[Column()]
		public bool ModificaNumeracion { get; set; }
		[Column()]
		public long? A_ULTIMO_NRO { get; set; }
		[Column()]
		public long? A_NRO_DESDE { get; set; }
		[Column()]
		public long? A_NRO_HASTA { get; set; }
		[Column()]
		public long? A_SUC_DEFAULT { get; set; }
		[Column()]
		public long? B_ULTIMO_NRO { get; set; }
		[Column()]
		public long? B_NRO_DESDE { get; set; }
		[Column()]
		public long? B_NRO_HASTA { get; set; }
		[Column()]
		public long? B_SUC_DEFAULT { get; set; }
		[Column()]
		public long? C_ULTIMO_NRO { get; set; }
		[Column()]
		public long? C_NRO_DESDE { get; set; }
		[Column()]
		public long? C_NRO_HASTA { get; set; }
		[Column()]
		public long? C_SUC_DEFAULT { get; set; }
		[Column()]
		public long? E_ULTIMO_NRO { get; set; }
		[Column()]
		public long? E_NRO_DESDE { get; set; }
		[Column()]
		public long? E_NRO_HASTA { get; set; }
		[Column()]
		public long? E_SUC_DEFAULT { get; set; }
		[Column()]
		public long? X_ULTIMO_NRO { get; set; }
		[Column()]
		public long? X_NRO_DESDE { get; set; }
		[Column()]
		public long? X_NRO_HASTA { get; set; }
		[Column()]
		public long? X_SUC_DEFAULT { get; set; }
		[Column()]
		public string LETRAS { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public string Signo { get; set; }
		[Column()]
		public bool OrdenDeCompra { get; set; }
		[Column( IsPrimaryKey = true)]
		public long TALONARIO { get; set; }
		[Column()]
		public long? M_ULTIMO_NRO { get; set; }
		[Column()]
		public long? M_NRO_DESDE { get; set; }
		[Column()]
		public long? M_NRO_HASTA { get; set; }
		[Column()]
		public long? M_SUC_DEFAULT { get; set; }
	}
}
