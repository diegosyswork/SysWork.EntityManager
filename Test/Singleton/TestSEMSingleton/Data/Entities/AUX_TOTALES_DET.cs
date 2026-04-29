using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "AUX_TOTALES_DET")]
	public partial class AUX_TOTALES_DET
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string Nombre_Grupo { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Cuenta { get; set; }
		[Column()]
		public decimal? Saldo { get; set; }
	}
}
