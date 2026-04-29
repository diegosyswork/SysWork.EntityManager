using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_CUENTAS_DATOS_LABORALES")]
	public partial class MA_CUENTAS_DATOS_LABORALES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column()]
		public string EMPRESA { get; set; }
		[Column()]
		public string CALLE { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string PISO { get; set; }
		[Column()]
		public string DEPARTAMENTO { get; set; }
		[Column()]
		public string CPOSTAL { get; set; }
		[Column()]
		public string LOCALIDAD { get; set; }
		[Column()]
		public string PROVINCIA { get; set; }
		[Column()]
		public string PAIS { get; set; }
		[Column()]
		public string TELEFONO { get; set; }
		[Column()]
		public string FAX { get; set; }
		[Column()]
		public string MAIL { get; set; }
		[Column()]
		public string WEB { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public decimal? SUELDO_NETO { get; set; }
		[Column()]
		public decimal? INGRESO_FAMILIAR { get; set; }
		[Column()]
		public DateTime? FECHA_INGRESO { get; set; }
		[Column()]
		public string NRO_LEGAJO { get; set; }
	}
}
