using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_TERMINALES")]
	public partial class TA_TERMINALES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TERMINAL { get; set; }
		[Column()]
		public string PTO_VENTA { get; set; }
		[Column()]
		public string IP { get; set; }
		[Column()]
		public string REGISTRO_KEY { get; set; }
	}
}
