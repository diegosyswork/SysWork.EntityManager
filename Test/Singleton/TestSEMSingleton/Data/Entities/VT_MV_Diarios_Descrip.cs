using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "VT_MV_Diarios_Descrip")]
	public partial class VT_MV_Diarios_Descrip
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public long IDDiario { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string Tecnico { get; set; }
		[Column()]
		public string Tareas { get; set; }
		[Column()]
		public string Horas { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public long? NUMEROAUTORIZACION { get; set; }
		[Column()]
		public string AUTORIZADOPOR { get; set; }
		[Column()]
		public string IDTecnico { get; set; }
		[Column()]
		public string IDTarea { get; set; }
	}
}
