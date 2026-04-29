using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_MA_AERONAVES_DOCUMENTOS")]
	public partial class V_MA_AERONAVES_DOCUMENTOS
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string IDAERONAVE { get; set; }
		[Column( IsPrimaryKey = true)]
		public string RUTA_DOCUMENTO { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
	}
}
