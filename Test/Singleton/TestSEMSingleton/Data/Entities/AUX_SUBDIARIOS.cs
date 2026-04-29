using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "AUX_SUBDIARIOS")]
	public partial class AUX_SUBDIARIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string USUARIO { get; set; }
		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public long? PERIODO { get; set; }
		[Column()]
		public long? MES_OPERATIVO { get; set; }
		[Column( Name = "NUMERO ASIENTO")]
		public long? NUMEROASIENTO { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string SUCURSAL { get; set; }
		[Column()]
		public string NUMERO { get; set; }
		[Column()]
		public string LETRA { get; set; }
		[Column()]
		public decimal? CABIMPORTE { get; set; }
		[Column()]
		public string CONCEPTO { get; set; }
		[Column()]
		public string CUENTA_D { get; set; }
		[Column()]
		public string CUENTA_H { get; set; }
		[Column()]
		public decimal? IMPORTE_D { get; set; }
		[Column()]
		public decimal? IMPORTE_H { get; set; }
		[Column()]
		public string DESCRIPCION_D { get; set; }
		[Column()]
		public string DESCRIPCION_H { get; set; }
	}
}
