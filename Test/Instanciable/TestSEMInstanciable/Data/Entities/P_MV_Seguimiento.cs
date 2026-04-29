using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "P_MV_Seguimiento")]
	public partial class P_MV_Seguimiento
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public long IdPostulante { get; set; }
		[Column()]
		public string IdCliente { get; set; }
		[Column()]
		public DateTime Fecha { get; set; }
		[Column()]
		public bool Contratado { get; set; }
		[Column()]
		public long IdProcesoBusqueda { get; set; }
	}
}
