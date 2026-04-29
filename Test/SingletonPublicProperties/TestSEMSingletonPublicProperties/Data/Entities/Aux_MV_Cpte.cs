using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "Aux_MV_Cpte")]
	public partial class Aux_MV_Cpte
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string TIPO { get; set; }
		[Column()]
		public string Seccion { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string COLUMNA1 { get; set; }
		[Column()]
		public string COLUMNA2 { get; set; }
		[Column()]
		public string COLUMNA3 { get; set; }
		[Column()]
		public string COLUMNA4 { get; set; }
		[Column()]
		public string COLUMNA5 { get; set; }
		[Column()]
		public string COLUMNA6 { get; set; }
		[Column()]
		public string COLUMNA7 { get; set; }
		[Column()]
		public string COLUMNA8 { get; set; }
		[Column()]
		public string Encabezado { get; set; }
		[Column()]
		public string PieDePagina { get; set; }
		[Column()]
		public string COLUMNA9 { get; set; }
		[Column()]
		public string COLUMNA10 { get; set; }
		[Column()]
		public string COLUMNA11 { get; set; }
		[Column()]
		public string IMPORTEENLETRAS { get; set; }
		[Column()]
		public string COLUMNA12 { get; set; }
		[Column()]
		public string COLUMNA13 { get; set; }
		[Column()]
		public string COLUMNA14 { get; set; }
		[Column()]
		public string COLUMNA15 { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string IDDEPOSITO { get; set; }
		[Column()]
		public string COLUMNA16 { get; set; }
		[Column()]
		public string COLUMNA17 { get; set; }
		[Column()]
		public string COLUMNA18 { get; set; }
		[Column()]
		public string COLUMNA19 { get; set; }
		[Column()]
		public string COLUMNA20 { get; set; }
		[Column()]
		public double? AuxCantidad { get; set; }
		[Column()]
		public decimal? AuxPrecioSinIVA { get; set; }
		[Column()]
		public string AuxIdArticulo { get; set; }
		[Column()]
		public string AuxIdTarea { get; set; }
		[Column()]
		public string AUXIDGARANTIA { get; set; }
		[Column()]
		public string AUXIDUNIDAD { get; set; }
	}
}
