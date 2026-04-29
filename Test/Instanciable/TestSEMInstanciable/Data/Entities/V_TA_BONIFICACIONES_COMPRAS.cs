using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_BONIFICACIONES_COMPRAS")]
	public partial class V_TA_BONIFICACIONES_COMPRAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdBonificacion { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public double? PorcBonif1 { get; set; }
		[Column()]
		public double? PorcBonif2 { get; set; }
		[Column()]
		public double? PorcBonif3 { get; set; }
		[Column()]
		public double? PorcBonif4 { get; set; }
		[Column()]
		public double? PorcBonif5 { get; set; }
		[Column()]
		public double? PorcBonif6 { get; set; }
		[Column()]
		public double? PorcBonif7 { get; set; }
		[Column()]
		public double? PorcBonif8 { get; set; }
		[Column()]
		public double? PorcBonif9 { get; set; }
		[Column()]
		public double? PorcBonif10 { get; set; }
	}
}
