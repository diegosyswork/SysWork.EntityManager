using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_Interfaces_Detalle")]
	public partial class V_TA_Interfaces_Detalle
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string INTERFACE { get; set; }
		[Column()]
		public string NOMBRE_CAMPO { get; set; }
		[Column()]
		public string TIPO_DATO { get; set; }
		[Column()]
		public string LONGITUD { get; set; }
		[Column()]
		public string FORMATO { get; set; }
		[Column()]
		public long SECUENCIA { get; set; }
	}
}
