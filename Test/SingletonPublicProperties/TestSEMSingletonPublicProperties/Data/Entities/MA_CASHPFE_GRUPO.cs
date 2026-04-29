using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_CASHPFE_GRUPO")]
	public partial class MA_CASHPFE_GRUPO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO_CASHPFE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Nombre { get; set; }
	}
}
