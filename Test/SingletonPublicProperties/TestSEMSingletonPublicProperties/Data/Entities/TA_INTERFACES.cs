using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "TA_INTERFACES")]
	public partial class TA_INTERFACES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string NOMBRE { get; set; }
		[Column()]
		public string SUBDIARIO { get; set; }
		[Column()]
		public string TIPO_ARCHIVO { get; set; }
		[Column()]
		public string SEPARADOR { get; set; }
		[Column()]
		public string NOMBRE_ARCHIVO { get; set; }
		[Column()]
		public string CALIFICADOR { get; set; }
		[Column()]
		public string FECHA_BASICOS { get; set; }
		[Column()]
		public string TC_BASICOS { get; set; }
		[Column()]
		public string SUC_BASICOS { get; set; }
		[Column()]
		public string NUM_BASICOS { get; set; }
		[Column()]
		public string LET_BASICOS { get; set; }
		[Column()]
		public string SUCNUMLET_BASICOS { get; set; }
		[Column()]
		public string FORMATO_SUC_NUM_LET { get; set; }
		[Column()]
		public string IMPORTETOTAL_BASICOS { get; set; }
		[Column()]
		public string VENCIMIENTO_BASICOS { get; set; }
		[Column()]
		public string CUENTA_PRINCIPAL_BASICOS { get; set; }
		[Column()]
		public string LIVA_TIPO { get; set; }
		[Column()]
		public string LIVA_NETO { get; set; }
		[Column()]
		public string LIVA_NETON { get; set; }
		[Column()]
		public string LIVA_CFRI { get; set; }
		[Column()]
		public string LIVA_DFRI { get; set; }
		[Column()]
		public string LIVA_DFRNI { get; set; }
		[Column()]
		public string LIVA_IMPIVAREC { get; set; }
		[Column()]
		public string LIVA_EXENTO { get; set; }
		[Column()]
		public string LIVA_RET_PERC { get; set; }
		[Column()]
		public string LIVA_RET_GANANCIAS { get; set; }
		[Column()]
		public string LIVA_RET_IBTOS { get; set; }
		[Column()]
		public string LIVA_RM { get; set; }
		[Column()]
		public string LIVA_CF { get; set; }
	}
}
