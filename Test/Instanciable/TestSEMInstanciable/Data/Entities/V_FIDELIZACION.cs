using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_FIDELIZACION")]
	public partial class V_FIDELIZACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string TIPO { get; set; }
		[Column()]
		public decimal? IMPORTE_DE_LA_COMPRA { get; set; }
		[Column()]
		public long? PUNTOS_QUE_ACUMULA { get; set; }
		[Column()]
		public decimal? MONTO_MINIMO_COMPRA { get; set; }
		[Column()]
		public string CPTES_QUE_ACUMULAN { get; set; }
		[Column()]
		public string TIPO_INCLUSION_CLIENTES { get; set; }
		[Column()]
		public string INCLUIR_CLASES { get; set; }
		[Column()]
		public string INCLUIR_CATEGORIAS { get; set; }
		[Column()]
		public bool OBLIGA_USO_TARJETA { get; set; }
	}
}
