using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_Tecnicos")]
	public partial class V_TA_Tecnicos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdTecnico { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string Cargo { get; set; }
		[Column()]
		public string Domicilio { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public string IdProvincia { get; set; }
		[Column()]
		public string Telefono { get; set; }
		[Column()]
		public decimal? CostoHora { get; set; }
		[Column()]
		public string Fotografia { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
		[Column()]
		public string UsuarioAsociado { get; set; }
		[Column()]
		public string SistemaAsociado { get; set; }
	}
}
