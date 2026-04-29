using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "P_MA_Empresas")]
	public partial class P_MA_Empresas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long Id { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdEmpresa { get; set; }
		[Column()]
		public string NombreEmpresa { get; set; }
		[Column()]
		public string Calle { get; set; }
		[Column()]
		public string Numero { get; set; }
		[Column()]
		public string Piso { get; set; }
		[Column()]
		public string Dpto { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public string CodigoPostal { get; set; }
		[Column()]
		public string Telefono { get; set; }
		[Column()]
		public string eMail { get; set; }
		[Column()]
		public string CUIT { get; set; }
		[Column()]
		public string Actividad { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
		[Column()]
		public string Observaciones { get; set; }
		[Column()]
		public bool PideHonorarios { get; set; }
		[Column()]
		public string RPT_RECIBOSUELDO { get; set; }
	}
}
