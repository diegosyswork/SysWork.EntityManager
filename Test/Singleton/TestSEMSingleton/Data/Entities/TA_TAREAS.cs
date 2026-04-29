using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_TAREAS")]
	public partial class TA_TAREAS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string USUARIO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string SISTEMA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TAREA { get; set; }
	}
}
