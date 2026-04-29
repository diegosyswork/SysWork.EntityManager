using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "AuxObtieneNeto")]
	public partial class AuxObtieneNeto
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public double? CANTIDAD { get; set; }
		[Column()]
		public double? PESO { get; set; }
		[Column()]
		public decimal? IMPORTE_S_IVA { get; set; }
		[Column()]
		public double? AlicIva { get; set; }
		[Column()]
		public bool CONSIGNADO { get; set; }
		[Column()]
		public bool PESO_X_CANTIDAD { get; set; }
		[Column()]
		public bool PESABLE { get; set; }
		[Column()]
		public double? PESO_X_UNIDAD { get; set; }
		[Column()]
		public bool ANULADA { get; set; }
		[Column()]
		public decimal? IMPORTE_C_IVA { get; set; }
	}
}
