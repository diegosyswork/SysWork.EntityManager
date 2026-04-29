using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "Ta_NumArchivoLegal")]
	public partial class Ta_NumArchivoLegal
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TIPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TIPOREG { get; set; }
		[Column( IsPrimaryKey = true)]
		public string PERIODO { get; set; }
		[Column()]
		public long PaginaDesde { get; set; }
		[Column()]
		public long PaginaHasta { get; set; }
	}
}
