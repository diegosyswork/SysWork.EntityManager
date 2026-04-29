using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_BIENES")]
	public partial class MA_BIENES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public double CODIGO { get; set; }
		[Column()]
		public string CUENTA_CONTABLE { get; set; }
		[Column()]
		public string CUENTA_EJERCICIO { get; set; }
		[Column()]
		public string CUENTA_ACUMULADA { get; set; }
		[Column()]
		public DateTime? FECHA_COMPRA { get; set; }
		[Column()]
		public decimal? COSTO { get; set; }
		[Column()]
		public decimal? VALOR_RESIDUAL { get; set; }
		[Column()]
		public decimal? VALOR_RECUPERO { get; set; }
		[Column()]
		public DateTime? FECHA_REVALUACION { get; set; }
		[Column()]
		public decimal? IMPORTE { get; set; }
		[Column()]
		public string VIDA_UTIL { get; set; }
		[Column()]
		public double? PORCENTAJE { get; set; }
		[Column()]
		public string PERIODO_TIEMPO { get; set; }
		[Column()]
		public string UBICACION { get; set; }
		[Column()]
		public string AFECTA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public DateTime? FECHA_BAJA { get; set; }
		[Column()]
		public string MOTIVO { get; set; }
		[Column()]
		public long? PERIODO { get; set; }
		[Column()]
		public long? PERIODO_REVALUACION { get; set; }
		[Column()]
		public byte? MES_OPERATIVO { get; set; }
		[Column()]
		public double? NRO_ASIENTO { get; set; }
		[Column()]
		public string TIPO_REG { get; set; }
		[Column()]
		public string SERIE { get; set; }
		[Column()]
		public string DENOMINACION { get; set; }
		[Column()]
		public string MARCA { get; set; }
		[Column()]
		public string MODELO { get; set; }
		[Column()]
		public string NRO_SERIE { get; set; }
		[Column()]
		public DateTime? FECHA_CALIBRACION { get; set; }
		[Column()]
		public DateTime? VENCIMIENTO { get; set; }
		[Column()]
		public string ASIGNADO { get; set; }
		[Column()]
		public string IDMARCABIEN { get; set; }
		[Column()]
		public string IDTIPOBIEN { get; set; }
		[Column()]
		public string IDESTADOBIEN { get; set; }
		[Column()]
		public string IDCLASEBIEN { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
		[Column()]
		public string IDPROPIETARIOBIEN { get; set; }
	}
}
