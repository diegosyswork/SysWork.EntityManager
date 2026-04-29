using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "L_MA_LICENCIASCtrolMedico")]
	public partial class L_MA_LICENCIASCtrolMedico
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string Serie { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NroLicencia { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdControlMedico { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
