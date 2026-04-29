using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "AUX_BALANCEGRAL")]
	public partial class AUX_BALANCEGRAL
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public decimal? SUBCUENTA_D { get; set; }
		[Column()]
		public decimal? SUBCUENTA_H { get; set; }
		[Column()]
		public decimal? CUENTA_D { get; set; }
		[Column()]
		public decimal? CUENTA_H { get; set; }
		[Column()]
		public decimal? SUBRUBRO_D { get; set; }
		[Column()]
		public decimal? SUBRUBRO_H { get; set; }
		[Column()]
		public decimal? RUBRO_D { get; set; }
		[Column()]
		public decimal? RUBRO_H { get; set; }
		[Column()]
		public decimal? SUBCAPITULO_D { get; set; }
		[Column()]
		public decimal? SUBCAPITULO_H { get; set; }
		[Column()]
		public decimal? CAPITULO_D { get; set; }
		[Column()]
		public decimal? CAPITULO_H { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
	}
}
