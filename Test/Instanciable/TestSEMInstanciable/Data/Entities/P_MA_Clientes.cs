using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "P_MA_Clientes")]
	public partial class P_MA_Clientes
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdCliente { get; set; }
		[Column()]
		public string Razon_Social { get; set; }
		[Column()]
		public string Domicilio { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public string CodPostal { get; set; }
		[Column()]
		public string IdProvincia { get; set; }
		[Column()]
		public string IdPais { get; set; }
		[Column()]
		public string Telefono { get; set; }
		[Column()]
		public string Fax { get; set; }
		[Column()]
		public string EMail { get; set; }
		[Column()]
		public string IdTipoDocumento { get; set; }
		[Column()]
		public string NumeroDocumento { get; set; }
		[Column()]
		public string IdCondicionIVA { get; set; }
		[Column()]
		public string IdCond_Cpra_Vta { get; set; }
		[Column()]
		public string IdCategoria { get; set; }
		[Column()]
		public bool Baja { get; set; }
	}
}
