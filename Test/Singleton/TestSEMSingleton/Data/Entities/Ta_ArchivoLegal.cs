using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "Ta_ArchivoLegal")]
	public partial class Ta_ArchivoLegal
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string PERIODO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TIPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TIPOREG { get; set; }
		[Column()]
		public string TIPOARCHIVOLEGAL { get; set; }
		[Column()]
		public string ARCHIVOGENERADO { get; set; }
		[Column()]
		public string ARCHIVOINTERNO { get; set; }
		[Column()]
		public long? EJERCICIO { get; set; }
		[Column()]
		public long? NRO_INTERNO { get; set; }
		[Column()]
		public long? PaginaDesde { get; set; }
		[Column()]
		public long? PaginaHasta { get; set; }
	}
}
