using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MV_BIENES")]
	public partial class MV_BIENES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column()]
		public DateTime Fecha { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdComprobante { get; set; }
		[Column()]
		public string IdMotivoBien { get; set; }
		[Column()]
		public string Origen { get; set; }
		[Column()]
		public string Destino { get; set; }
		[Column()]
		public string Usuario { get; set; }
		[Column()]
		public string Observaciones { get; set; }
	}
}
