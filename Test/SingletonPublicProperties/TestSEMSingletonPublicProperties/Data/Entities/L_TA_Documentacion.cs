using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "L_TA_Documentacion")]
	public partial class L_TA_Documentacion
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IdDocumentacion { get; set; }
		[Column()]
		public string Descripcion { get; set; }
	}
}
