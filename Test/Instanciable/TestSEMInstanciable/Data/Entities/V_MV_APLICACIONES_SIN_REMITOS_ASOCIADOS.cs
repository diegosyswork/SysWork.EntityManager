using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOS")]
	public partial class V_MV_APLICACIONES_SIN_REMITOS_ASOCIADOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
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
	}
}
