using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_RANGOS_DATOS_ADIC")]
	public partial class TA_RANGOS_DATOS_ADIC
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string DESCRIPCION { get; set; }
		[Column( Name = "CUENTA-DESDE")]
		public string CUENTADESDE { get; set; }
		[Column( Name = "CUENTA-HASTA")]
		public string CUENTAHASTA { get; set; }
		[Column()]
		public string Vista { get; set; }
		[Column()]
		public bool PideVencimiento { get; set; }
		[Column()]
		public bool PideVencimientoHaber { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
	}
}
