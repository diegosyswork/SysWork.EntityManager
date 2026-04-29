using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MA_CUENTASCCOSTO")]
	public partial class MA_CUENTASCCOSTO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CCOSTO { get; set; }
		[Column()]
		public double? PORCENTAJE { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public bool PIDECONFIRMACION { get; set; }
	}
}
