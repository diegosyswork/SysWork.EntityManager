using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TMP_BusquedaPrecio")]
	public partial class TMP_BusquedaPrecio
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column()]
		public string Usuario { get; set; }
		[Column()]
		public string IdArticulo { get; set; }
		[Column()]
		public double? Cantidad { get; set; }
		[Column()]
		public long IdLista { get; set; }
		[Column()]
		public string NombreLista { get; set; }
		[Column()]
		public string TipoLista { get; set; }
		[Column()]
		public decimal? Precio { get; set; }
		[Column()]
		public string CuentaProveedor { get; set; }
		[Column()]
		public string NombreProveedor { get; set; }
		[Column()]
		public string CondicionCpra { get; set; }
		[Column()]
		public string DescripcionCondicion { get; set; }
		[Column()]
		public double? Descuento1 { get; set; }
		[Column()]
		public double? Descuento2 { get; set; }
		[Column()]
		public double? Descuento3 { get; set; }
		[Column()]
		public double? Descuento4 { get; set; }
		[Column()]
		public double? Descuento5 { get; set; }
		[Column()]
		public bool Chequeado { get; set; }
	}
}
