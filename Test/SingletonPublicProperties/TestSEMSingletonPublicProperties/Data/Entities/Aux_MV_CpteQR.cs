using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "Aux_MV_CpteQR")]
	public partial class Aux_MV_CpteQR
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID_AUX_MV_CPTEQR { get; set; }
		[Column( IsPrimaryKey = true)]
		public string USUARIO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TC { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public byte[] QR_AFIP { get; set; }
	}
}
