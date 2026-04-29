using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "AUX_EstadisticaCta")]
	public partial class AUX_EstadisticaCta
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string GRUPO { get; set; }
		[Column()]
		public DateTime? FECHAD { get; set; }
		[Column()]
		public DateTime? FECHAH { get; set; }
		[Column()]
		public decimal? IMPORTEG1 { get; set; }
		[Column()]
		public decimal? IMPORTEG2 { get; set; }
		[Column()]
		public string Detalle { get; set; }
	}
}
