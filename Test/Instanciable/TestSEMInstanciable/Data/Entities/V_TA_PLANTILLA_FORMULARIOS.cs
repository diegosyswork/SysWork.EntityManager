using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_PLANTILLA_FORMULARIOS")]
	public partial class V_TA_PLANTILLA_FORMULARIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string TipoPlantilla { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NombrePlantilla { get; set; }
		[Column( IsPrimaryKey = true)]
		public string DataField { get; set; }
		[Column()]
		public string Valor { get; set; }
	}
}
