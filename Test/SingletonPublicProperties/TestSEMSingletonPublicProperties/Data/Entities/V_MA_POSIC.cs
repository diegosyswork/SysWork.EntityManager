using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "V_MA_POSIC")]
	public partial class V_MA_POSIC
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IDPOSICION { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public bool TITULO { get; set; }
		[Column()]
		public bool HABILITADO { get; set; }
		[Column()]
		public bool RESERVADO { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public double? CAPACIDAD { get; set; }
		[Column()]
		public bool COMPLETA { get; set; }
		[Column()]
		public string TIPO { get; set; }
		[Column()]
		public string VALOR { get; set; }
		[Column()]
		public string IdRubro { get; set; }
		[Column()]
		public string IdTipo { get; set; }
		[Column()]
		public string IdArticulo { get; set; }
		[Column()]
		public long? OrdenIngreso { get; set; }
	}
}
