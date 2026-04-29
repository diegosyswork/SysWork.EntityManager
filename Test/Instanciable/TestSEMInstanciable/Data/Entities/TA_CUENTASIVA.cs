using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "TA_CUENTASIVA")]
	public partial class TA_CUENTASIVA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CFI_IVARI { get; set; }
		[Column()]
		public string CFI_IVARI1 { get; set; }
		[Column()]
		public string CFI_IVARI2 { get; set; }
		[Column()]
		public string CFI_IVARI3 { get; set; }
		[Column()]
		public string CFI_IVARI4 { get; set; }
		[Column()]
		public string CFI_IVARI5 { get; set; }
		[Column()]
		public string CFI_RETPERC { get; set; }
		[Column()]
		public string CFI_RETIGAN { get; set; }
		[Column()]
		public string CFI_RETIBTOS { get; set; }
		[Column()]
		public string DFI_IVARI { get; set; }
		[Column()]
		public string DFI_IVARNI { get; set; }
		[Column()]
		public string DFI_IVAREC { get; set; }
		[Column()]
		public string DFI_RETPERC { get; set; }
		[Column()]
		public string DFI_RETIBTOS { get; set; }
		[Column()]
		public string DFI_IVARM { get; set; }
		[Column()]
		public string DFI_IVACF { get; set; }
		[Column()]
		public string CFI_RETSUSS { get; set; }
		[Column()]
		public string CFI_RETVARIOS { get; set; }
		[Column()]
		public string CFI_PERCIBTOS { get; set; }
		[Column()]
		public string DFI_PERC_ELEGIBLE { get; set; }
		[Column()]
		public string CFI_PERCEP_OTROS { get; set; }
	}
}
