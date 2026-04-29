using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "C_MV_CpteTareas")]
	public partial class C_MV_CpteTareas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string IDTAREA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public double HORAS { get; set; }
		[Column()]
		public decimal VALORHORA { get; set; }
		[Column()]
		public decimal VALORHORA_S_IVA { get; set; }
		[Column()]
		public decimal? TOTAL { get; set; }
		[Column()]
		public bool EXENTO { get; set; }
	}
}
