using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MV_BIENES_DETALLE")]
	public partial class MV_BIENES_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdComprobante { get; set; }
		[Column( IsPrimaryKey = true)]
		public long Secuencia { get; set; }
		[Column()]
		public long IdBien { get; set; }
		[Column()]
		public string Observaciones { get; set; }
	}
}
