using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_Familiar")]
	public partial class P_MA_Familiar
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true, IsPrimaryKey = true)]
		public long Id { get; set; }
		[Column()]
		public string IdEmpresa { get; set; }
		[Column()]
		public string Legajo { get; set; }
		[Column()]
		public string Apellido { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string ApellidoCasada { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
		[Column()]
		public string NroDocumento { get; set; }
		[Column()]
		public DateTime? FechaNacimiento { get; set; }
		[Column()]
		public DateTime? AcargoDesde { get; set; }
		[Column()]
		public string IdParentesco { get; set; }
		[Column()]
		public string IdPais { get; set; }
		[Column()]
		public string Sexo { get; set; }
		[Column()]
		public string IdEstadoCivil { get; set; }
		[Column()]
		public bool Discapacitado { get; set; }
		[Column()]
		public string Escolaridad { get; set; }
		[Column()]
		public long? Cursa { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
	}
}
