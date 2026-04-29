using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_REPORTES_PERSONALIZADOS_DETALLE")]
	public partial class V_TA_REPORTES_PERSONALIZADOS_DETALLE
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE_RP { get; set; }
		[Column()]
		public string NOMBRE_CAMPO { get; set; }
		[Column()]
		public string TABLA { get; set; }
		[Column()]
		public string CAMPO { get; set; }
		[Column()]
		public string TIPO_DATO { get; set; }
		[Column()]
		public long? MAX_LENGHT { get; set; }
		[Column()]
		public string TABLA_QUE_CONSULTA { get; set; }
		[Column()]
		public bool SOLO_DESDE { get; set; }
		[Column()]
		public bool ALINEABLE { get; set; }
		[Column()]
		public bool SELECTIVO { get; set; }
	}
}
