using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_V_TA_CPTE")]
	public partial class VT_V_TA_CPTE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CODIGO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string SISTEMA { get; set; }
		[Column()]
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
		public long? R_ULTIMO_NRO { get; set; }
		[Column()]
		public long? R_NRO_DESDE { get; set; }
		[Column()]
		public long? R_NRO_HASTA { get; set; }
		[Column()]
		public long? R_SUC_DEFAULT { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public long TALONARIO { get; set; }
		[Column()]
		public DateTime? A_VENCIMIENTO { get; set; }
		[Column()]
		public DateTime? B_VENCIMIENTO { get; set; }
		[Column()]
		public DateTime? C_VENCIMIENTO { get; set; }
		[Column()]
		public DateTime? E_VENCIMIENTO { get; set; }
		[Column()]
		public DateTime? R_VENCIMIENTO { get; set; }
		[Column()]
		public DateTime? X_VENCIMIENTO { get; set; }
		[Column()]
		public string A_OBSERVACIONES { get; set; }
		[Column()]
		public string B_OBSERVACIONES { get; set; }
		[Column()]
		public string C_OBSERVACIONES { get; set; }
		[Column()]
		public string E_OBSERVACIONES { get; set; }
		[Column()]
		public string R_OBSERVACIONES { get; set; }
		[Column()]
		public string X_OBSERVACIONES { get; set; }
		[Column()]
		public long? COLOR_A { get; set; }
		[Column()]
		public long? COLOR_B { get; set; }
		[Column()]
		public long? COLOR_C { get; set; }
		[Column()]
		public long? COLOR_E { get; set; }
		[Column()]
		public long? COLOR_R { get; set; }
		[Column()]
		public long? COLOR_X { get; set; }
	}
}
