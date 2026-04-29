using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_TA_ALERTAS_STOCK")]
	public partial class V_TA_ALERTAS_STOCK
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string USUARIO { get; set; }
		[Column()]
		public string IDARTICULO_DESDE { get; set; }
		[Column()]
		public string IDARTICULO_HASTA { get; set; }
		[Column()]
		public string IDRUBRO_DESDE { get; set; }
		[Column()]
		public string IDRUBRO_HASTA { get; set; }
		[Column()]
		public string IDTIPO_DESDE { get; set; }
		[Column()]
		public string IDTIPO_HASTA { get; set; }
		[Column()]
		public string IDFAMILIA_DESDE { get; set; }
		[Column()]
		public string IDFAMILIA_HASTA { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
	}
}
