using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[View (Name = "SW_TABLAS_CON_CAMPOS")]
	public partial class SW_TABLAS_CON_CAMPOS
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
		[Column()]
		public string TABLE_TYPE { get; set; }
		[Column()]
		public Int16 ORDINAL_POSITION { get; set; }
		[Column()]
		public string COLUMN_NAME { get; set; }
		[Column()]
		public string COLUMN_DEFAULT { get; set; }
		[Column()]
		public string IS_NULLABLE { get; set; }
		[Column()]
		public string DATA_TYPE { get; set; }
		[Column()]
		public long? CHARACTER_OCTET_LENGTH { get; set; }
	}
}
