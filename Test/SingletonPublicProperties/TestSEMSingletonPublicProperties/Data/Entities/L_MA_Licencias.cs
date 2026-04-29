using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities
{
	[Table (Name = "L_MA_Licencias")]
	public partial class L_MA_Licencias
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdTipoDoc { get; set; }
		[Column( IsPrimaryKey = true)]
		public string NroDoc { get; set; }
		[Column()]
		public string Serie { get; set; }
		[Column()]
		public string NroLicencia { get; set; }
		[Column()]
		public string IdClaseLicencia { get; set; }
		[Column()]
		public string Apellido { get; set; }
		[Column()]
		public string Nombres { get; set; }
		[Column()]
		public string Domicilio { get; set; }
		[Column()]
		public string IdLocalidad { get; set; }
		[Column()]
		public string IdPartido { get; set; }
		[Column()]
		public string Telefono { get; set; }
		[Column()]
		public string CodPostal { get; set; }
		[Column()]
		public string Factor { get; set; }
		[Column()]
		public string RH { get; set; }
		[Column()]
		public DateTime FechaNacimiento { get; set; }
		[Column()]
		public DateTime FechaEmision { get; set; }
		[Column()]
		public DateTime FechaVencimiento { get; set; }
		[Column()]
		public byte[]? FotoCarnet { get; set; }
		[Column()]
		public byte[]? FotoFirma { get; set; }
		[Column()]
		public string CategoriasAbrev { get; set; }
		[Column()]
		public bool DonaOrganos { get; set; }
		[Column()]
		public bool NoExpresaVoluntad { get; set; }
		[Column()]
		public string Sexo { get; set; }
		[Column()]
		public string ReemplazaSerie { get; set; }
		[Column()]
		public string ReemplazaNumero { get; set; }
		[Column()]
		public string Observaciones { get; set; }
	}
}
