using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_DEPOSITO_MM")]
	public partial class V_TA_DEPOSITO_MM
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IdArticulo { get; set; }
		[Column()]
		public double? Minimo { get; set; }
		[Column()]
		public double? Maximo { get; set; }
		[Column()]
		public string DDMM_DESDE { get; set; }
		[Column()]
		public string DDMM_HASTA { get; set; }
		[Column()]
		public double? MINIMO_DDMM { get; set; }
		[Column()]
		public double? MAXIMO_DDMM { get; set; }
		[Column()]
		public string UBICACION_HABITUAL { get; set; }
	}
}
