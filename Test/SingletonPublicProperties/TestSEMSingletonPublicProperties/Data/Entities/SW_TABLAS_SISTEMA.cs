using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "SW_TABLAS_SISTEMA")]
	public partial class SW_TABLAS_SISTEMA
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TABLE_CATALOG { get; set; }
		[Column()]
		public string TABLE_SCHEMA { get; set; }
		[Column()]
		public string TABLE_NAME { get; set; }
	}
}
