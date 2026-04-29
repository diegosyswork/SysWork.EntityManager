using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "TA_REPORTES")]
	public partial class TA_REPORTES
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string Archivo { get; set; }
		[Column()]
		public string formula_Seleccion { get; set; }
		[Column()]
		public string formula_Ordenamiento { get; set; }
		[Column()]
		public bool PedirParametros { get; set; }
		[Column()]
		public bool SISTEMA { get; set; }
	}
}
