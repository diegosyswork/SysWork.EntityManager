using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MA_ARTICULOS_SINONIMOS")]
	public partial class V_MA_ARTICULOS_SINONIMOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDARTICULO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDARTICULOSINONIMO { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
	}
}
