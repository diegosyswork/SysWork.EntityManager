using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_CASH_CONTROL")]
	public partial class MA_CASH_CONTROL
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string CODIGO_CASH { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_GRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_SUBGRUPO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string PERIODO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public byte MES_OPERATIVO { get; set; }
		[Column( IsPrimaryKey = true, Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column()]
		public string TIPO_REG { get; set; }
		[Column( IsPrimaryKey = true)]
		public DateTime FECHA { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public decimal? IMPORTE_DIF { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
	}
}
