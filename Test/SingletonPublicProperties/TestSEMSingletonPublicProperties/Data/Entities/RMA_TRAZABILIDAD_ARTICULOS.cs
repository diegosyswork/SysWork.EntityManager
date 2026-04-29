using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "RMA_TRAZABILIDAD_ARTICULOS")]
	public partial class RMA_TRAZABILIDAD_ARTICULOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public DateTime FECHA_HORA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDCOMPROBANTE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDARTICULO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NRO_SERIE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDESTADORMA { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public string USUARIO_INFORME { get; set; }
		[Column()]
		public long ID_V_MV_CPTEINSUMOS { get; set; }
	}
}
