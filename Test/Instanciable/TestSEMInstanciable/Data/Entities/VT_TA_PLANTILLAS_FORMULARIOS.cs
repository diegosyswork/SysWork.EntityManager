using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "VT_TA_PLANTILLAS_FORMULARIOS")]
	public partial class VT_TA_PLANTILLAS_FORMULARIOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string TipoPlantilla { get; set; }
		[Column()]
		public string NombrePlantilla { get; set; }
	}
}
