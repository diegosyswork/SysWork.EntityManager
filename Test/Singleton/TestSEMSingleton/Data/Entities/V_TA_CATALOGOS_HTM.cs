using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_CATALOGOS_HTM")]
	public partial class V_TA_CATALOGOS_HTM
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_CATALOGO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string ARCHIVO_PLANTILLA { get; set; }
		[Column()]
		public string MARCA_INICIO_CODIGO { get; set; }
		[Column()]
		public string MARCA_FIN_CODIGO { get; set; }
		[Column()]
		public long CANTIDAD_COLUMNAS { get; set; }
		[Column()]
		public long? CANTIDAD_FILAS { get; set; }
		[Column()]
		public string WHERE_ADIC { get; set; }
	}
}
