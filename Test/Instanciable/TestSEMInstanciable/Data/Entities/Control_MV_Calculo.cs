using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "Control_MV_Calculo")]
	public partial class Control_MV_Calculo
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? Fecha { get; set; }
		[Column( IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public string RESPONSABLE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string PERIODO { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column( IsPrimaryKey = true)]
		public byte MES_OPERATIVO { get; set; }
		[Column( IsPrimaryKey = true, Name = "NUMERO ASIENTO")]
		public long NUMEROASIENTO { get; set; }
		[Column()]
		public bool Anulado { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
	}
}
