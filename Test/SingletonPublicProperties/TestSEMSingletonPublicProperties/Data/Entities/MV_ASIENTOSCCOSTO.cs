using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "MV_ASIENTOSCCOSTO")]
	public partial class MV_ASIENTOSCCOSTO
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string PERIODO { get; set; }
		[Column( IsPrimaryKey = true)]
		public byte MES_OPERATIVO { get; set; }
		[Column( IsPrimaryKey = true, Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public long SECUENCIA { get; set; }
		[Column( Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column()]
		public string MONEDA { get; set; }
		[Column( IsPrimaryKey = true)]
		public string CCOSTO { get; set; }
		[Column()]
		public Single? PORCENTAJE { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Tipo_Reg { get; set; }
		[Column()]
		public decimal Importe { get; set; }
		[Column()]
		public DateTime? Fecha { get; set; }
	}
}
