using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_INDAJUSTE")]
	public partial class MA_INDAJUSTE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public Int16? AÑO { get; set; }
		[Column()]
		public Int16? MES { get; set; }
		[Column()]
		public double? INDICE1 { get; set; }
		[Column()]
		public double? INDICE2 { get; set; }
		[Column()]
		public double? INDICE3 { get; set; }
		[Column()]
		public double? INDICE4 { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public double? Importe1 { get; set; }
		[Column()]
		public double? Importe2 { get; set; }
		[Column()]
		public double? Importe3 { get; set; }
		[Column()]
		public double? Importe4 { get; set; }
	}
}
