using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_PUBLICACIONES")]
	public partial class TA_PUBLICACIONES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string Archivo { get; set; }
		[Column()]
		public string Referencia { get; set; }
		[Column()]
		public long? EJERCICIO { get; set; }
	}
}
