using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_PoliticaPrecios")]
	public partial class V_TA_PoliticaPrecios
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Codigo { get; set; }
		[Column()]
		public decimal? Clase1 { get; set; }
		[Column()]
		public decimal? Clase2 { get; set; }
		[Column()]
		public decimal? Clase3 { get; set; }
		[Column()]
		public decimal? Clase4 { get; set; }
		[Column()]
		public decimal? Clase5 { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public decimal? CLASE6 { get; set; }
		[Column()]
		public decimal? CLASE7 { get; set; }
		[Column()]
		public decimal? CLASE8 { get; set; }
		[Column()]
		public decimal? CLASE9 { get; set; }
		[Column()]
		public decimal? CLASE10 { get; set; }
	}
}
