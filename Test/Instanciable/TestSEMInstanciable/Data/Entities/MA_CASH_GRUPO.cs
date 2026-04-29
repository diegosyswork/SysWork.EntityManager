using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_CASH-GRUPO")]
	public partial class MA_CASH_GRUPO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO_CASH { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NOMBRE { get; set; }
	}
}
