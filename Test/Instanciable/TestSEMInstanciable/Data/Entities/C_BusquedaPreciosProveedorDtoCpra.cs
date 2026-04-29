using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "C_BusquedaPreciosProveedorDtoCpra")]
	public partial class C_BusquedaPreciosProveedorDtoCpra
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CODIGO { get; set; }
		[Column()]
		public string RAZON_SOCIAL { get; set; }
		[Column()]
		public string IdLista { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string IdArticulo { get; set; }
		[Column()]
		public decimal Precio1 { get; set; }
		[Column()]
		public decimal Precio2 { get; set; }
		[Column()]
		public decimal Precio3 { get; set; }
		[Column()]
		public decimal Precio4 { get; set; }
		[Column()]
		public decimal Precio5 { get; set; }
		[Column()]
		public string IdCond_Cpra_Vta { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public long? CantidadDias { get; set; }
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
