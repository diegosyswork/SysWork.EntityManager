using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MV_INVENTARIOSCAB")]
	public partial class MV_INVENTARIOSCAB
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public long IDINVENTARIO { get; set; }
		[Column()]
		public DateTime FECHA { get; set; }
		[Column()]
		public string IDDEPOSITO { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public bool AJUSTE_STOCK { get; set; }
		[Column()]
		public bool FINALIZADO { get; set; }
	}
}
