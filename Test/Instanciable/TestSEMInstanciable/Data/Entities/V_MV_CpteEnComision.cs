using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_MV_CpteEnComision")]
	public partial class V_MV_CpteEnComision
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
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string TRABAJOS { get; set; }
		[Column()]
		public string TECNICOS { get; set; }
		[Column()]
		public DateTime? FECHAINICIO { get; set; }
		[Column()]
		public DateTime? FECHAFIN { get; set; }
		[Column()]
		public string LUGAR { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string DESCRIPCIONCUENTA { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public bool CONCOMPROBANTE { get; set; }
		[Column()]
		public bool ESANTICIPO { get; set; }
		[Column()]
		public string DEBEHABER { get; set; }
		[Column()]
		public decimal? CreditoFiscal { get; set; }
	}
}
