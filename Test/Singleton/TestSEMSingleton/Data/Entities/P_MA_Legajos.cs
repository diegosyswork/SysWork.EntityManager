using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_Legajos")]
	public partial class P_MA_Legajos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdEmpresa { get; set; }
		[Column( IsPrimaryKey = true)]
		public string Legajo { get; set; }
		[Column()]
		public string Apellido { get; set; }
		[Column()]
		public string ApellidoCasada { get; set; }
		[Column()]
		public string Nombre { get; set; }
		[Column()]
		public string Calle { get; set; }
		[Column()]
		public long? Nro { get; set; }
		[Column()]
		public string Piso { get; set; }
		[Column()]
		public string Departamento { get; set; }
		[Column()]
		public string CodPostal { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public string IdProvincia { get; set; }
		[Column()]
		public string IdPais { get; set; }
		[Column()]
		public string Telefonos { get; set; }
		[Column()]
		public string email { get; set; }
		[Column()]
		public string Sexo { get; set; }
		[Column()]
		public string IdEstadoCivil { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
		[Column()]
		public string NumeroDocumento { get; set; }
		[Column()]
		public string LugarNacimiento { get; set; }
		[Column()]
		public DateTime? FechaNacimiento { get; set; }
		[Column()]
		public string LugarCasamiento { get; set; }
		[Column()]
		public DateTime? FechaCasamiento { get; set; }
		[Column()]
		public DateTime? FechaIngreso { get; set; }
		[Column()]
		public DateTime? FechaIngresoAnterior { get; set; }
		[Column()]
		public string IdMotivoEgreso { get; set; }
		[Column()]
		public DateTime? FechaEgreso { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
		[Column()]
		public string IdObraSocial { get; set; }
		[Column()]
		public string IdCentroMedico { get; set; }
		[Column()]
		public string NotasCentroMedico { get; set; }
		[Column()]
		public string ANSSAL { get; set; }
		[Column()]
		public string IdSindicato { get; set; }
		[Column()]
		public string IdSind_Categoria { get; set; }
		[Column()]
		public string IdSind_Cargo { get; set; }
		[Column()]
		public decimal? SueldoBasico { get; set; }
		[Column()]
		public decimal? SueldoNeto { get; set; }
		[Column()]
		public long? HorasMensuales { get; set; }
		[Column()]
		public DateTime? VenceContrato { get; set; }
		[Column()]
		public string IdGrupo { get; set; }
		[Column()]
		public bool AportaSindicato { get; set; }
		[Column()]
		public string NroFondoDesempleo { get; set; }
		[Column()]
		public string NroObraSocial { get; set; }
		[Column()]
		public string NroSindicato { get; set; }
		[Column()]
		public string NroCuil { get; set; }
		[Column()]
		public string NroDNRP { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public decimal? ImpTk1 { get; set; }
		[Column()]
		public decimal? ImpTk2 { get; set; }
		[Column()]
		public decimal? ImpTk3 { get; set; }
		[Column()]
		public decimal? ImpTk4 { get; set; }
		[Column()]
		public string IdFormasDePago { get; set; }
		[Column()]
		public string CuentaPago { get; set; }
		[Column()]
		public string IdBanco { get; set; }
		[Column()]
		public string IdCategorizacion { get; set; }
		[Column()]
		public string CodigoBarras { get; set; }
	}
}
