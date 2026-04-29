using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MA_AERONAVES")]
	public partial class V_MA_AERONAVES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IDAERONAVE { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string MARCA { get; set; }
		[Column()]
		public string MODELO { get; set; }
		[Column()]
		public string NRO_SERIE { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public DateTime? FH_FABRICACION { get; set; }
		[Column()]
		public double? HOBBS { get; set; }
		[Column()]
		public double? TTIME { get; set; }
		[Column()]
		public byte[]? IMAGEN { get; set; }
	}
}
