using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MV_INVENTARIOS")]
	public partial class MV_INVENTARIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public long IdInventario { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdArticulo { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdUnidad { get; set; }
		[Column()]
		public double? Stock { get; set; }
		[Column()]
		public double? ConteoManual1 { get; set; }
		[Column()]
		public double? ConteoManual2 { get; set; }
		[Column()]
		public double? Diferencia { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public bool Ajustado { get; set; }
		[Column()]
		public bool MarcaAjuste { get; set; }
		[Column()]
		public bool TmpSinDiferencias { get; set; }
		[Column()]
		public string IdMotivoAjuste { get; set; }
	}
}
