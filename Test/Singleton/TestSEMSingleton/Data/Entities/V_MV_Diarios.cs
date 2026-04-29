using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "V_MV_Diarios")]
	public partial class V_MV_Diarios
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long ID { get; set; }
		[Column()]
		public long IDDiario { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long IDCOMPLEMENTO { get; set; }
		[Column()]
		public string IDTecnico { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string IDTarea { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public DateTime? FECHAINICIO { get; set; }
		[Column()]
		public DateTime? FECHAFIN { get; set; }
		[Column()]
		public long? MINUTOS { get; set; }
		[Column()]
		public string OBSERVACIONES { get; set; }
		[Column()]
		public string MATRICULA { get; set; }
		[Column()]
		public string CUENTA { get; set; }
		[Column()]
		public string AUTORIZADOPOR { get; set; }
		[Column()]
		public long? NUMEROAUTORIZACION { get; set; }
	}
}
