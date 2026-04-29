using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_MARCAS")]
	public partial class TA_MARCAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public DateTime? fechahora_grabacion { get; set; }
		[Column()]
		public DateTime? fechahora_modificacion { get; set; }
	}
}
