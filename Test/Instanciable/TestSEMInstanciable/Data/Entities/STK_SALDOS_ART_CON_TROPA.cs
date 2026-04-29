using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "STK_SALDOS_ART_CON_TROPA")]
	public partial class STK_SALDOS_ART_CON_TROPA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public double? PESO { get; set; }
		[Column()]
		public string NRO_TROPA { get; set; }
		[Column()]
		public long ID { get; set; }
		[Column()]
		public long? Id_Origen { get; set; }
	}
}
