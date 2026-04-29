using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MV_APLICACION")]
	public partial class MV_APLICACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column()]
		public string TCO_ORIGEN { get; set; }
		[Column()]
		public string SUCURSAL_ORIGEN { get; set; }
		[Column()]
		public string NUMERO_ORIGEN { get; set; }
		[Column()]
		public string LETRA_ORIGEN { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string IDComprobante { get; set; }
		[Column()]
		public string IDComprobante_Origen { get; set; }
		[Column()]
		public string TC_PRINT { get; set; }
		[Column()]
		public string IdComprobante_PRINT { get; set; }
	}
}
