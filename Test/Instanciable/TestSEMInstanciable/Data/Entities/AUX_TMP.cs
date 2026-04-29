using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "AUX_TMP")]
	public partial class AUX_TMP
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string USUARIO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Cuenta { get; set; }
	}
}
