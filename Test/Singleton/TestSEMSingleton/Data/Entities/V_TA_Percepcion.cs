using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_TA_Percepcion")]
	public partial class V_TA_Percepcion
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string idPercepcion { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public decimal? MinimoNoImponible { get; set; }
		[Column()]
		public decimal Percepcion { get; set; }
		[Column()]
		public string CIVA_Excluir1 { get; set; }
		[Column()]
		public string CIVA_Excluir2 { get; set; }
		[Column()]
		public string CIVA_Excluir3 { get; set; }
		[Column()]
		public string CIVA_Excluir4 { get; set; }
		[Column()]
		public bool IVA { get; set; }
	}
}
