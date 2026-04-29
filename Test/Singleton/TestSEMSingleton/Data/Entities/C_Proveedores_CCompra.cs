using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "C_Proveedores_CCompra")]
	public partial class C_Proveedores_CCompra
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IdProveedor { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdCond_Cpra_Vta { get; set; }
		[Column()]
		public double? PorDto1 { get; set; }
		[Column()]
		public double? PorDto2 { get; set; }
		[Column()]
		public double? PorDto3 { get; set; }
		[Column()]
		public double? PorDto4 { get; set; }
		[Column()]
		public double? PorDto5 { get; set; }
	}
}
