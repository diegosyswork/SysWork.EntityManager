using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MA_AERONAVES_COMPONENTES")]
	public partial class V_MA_AERONAVES_COMPONENTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column()]
		public string GRUPO { get; set; }
		[Column()]
		public long? ITEM { get; set; }
		[Column()]
		public string IDAERONAVE { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string NRO_SERIE { get; set; }
		[Column()]
		public DateTime? FECHA_INSTALACION { get; set; }
		[Column()]
		public string COL1 { get; set; }
		[Column()]
		public string COL2 { get; set; }
		[Column()]
		public string COL3 { get; set; }
		[Column()]
		public string COL4 { get; set; }
		[Column()]
		public string RESULTADO1 { get; set; }
		[Column()]
		public string COL5 { get; set; }
		[Column()]
		public string COL6 { get; set; }
		[Column()]
		public string COL7 { get; set; }
		[Column()]
		public string RESULTADO2 { get; set; }
		[Column()]
		public string RESULTADO3 { get; set; }
	}
}
