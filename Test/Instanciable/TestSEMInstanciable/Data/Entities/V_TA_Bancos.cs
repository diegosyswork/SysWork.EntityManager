using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_Bancos")]
	public partial class V_TA_Bancos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdBanco { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
	}
}
