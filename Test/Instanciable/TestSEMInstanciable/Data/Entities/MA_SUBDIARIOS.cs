using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "MA_SUBDIARIOS")]
	public partial class MA_SUBDIARIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column( Name = "CUENTA-DESDE")]
		public string CUENTADESDE { get; set; }
		[Column( Name = "CUENTA-HASTA")]
		public string CUENTAHASTA { get; set; }
		[Column( IsPrimaryKey = true, Name = "DEBE-HABER")]
		public string DEBEHABER { get; set; }
		[Column( IsPrimaryKey = true)]
		public long SECUENCIA { get; set; }
		[Column()]
		public DateTime? FechaHora_Grabacion { get; set; }
		[Column()]
		public DateTime? FechaHora_Modificacion { get; set; }
	}
}
