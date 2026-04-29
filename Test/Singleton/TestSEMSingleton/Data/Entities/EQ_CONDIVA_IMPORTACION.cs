using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "EQ_CONDIVA_IMPORTACION")]
	public partial class EQ_CONDIVA_IMPORTACION
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public string CODIGO_ORIGEN { get; set; }
		[Column()]
		public string CODIGO_SISTEMA { get; set; }
	}
}
