using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MV_EJERCICIOS")]
	public partial class MV_EJERCICIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public long PERIODO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column( Name = "FECHA DESDE")]
		public DateTime FECHADESDE { get; set; }
		[Column( Name = "FECHA HASTA")]
		public DateTime FECHAHASTA { get; set; }
		[Column()]
		public bool CERRADO { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
		[Column()]
		public bool Cancelacion { get; set; }
		[Column()]
		public bool Cierre { get; set; }
		[Column()]
		public bool Apertura { get; set; }
	}
}
