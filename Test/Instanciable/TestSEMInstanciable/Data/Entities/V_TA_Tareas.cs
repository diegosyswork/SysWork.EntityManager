using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[Table (Name = "V_TA_Tareas")]
	public partial class V_TA_Tareas
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column(IsIdentity = true)]
		public long ID { get; set; }
		[Column( IsPrimaryKey = true)]
		public string IdTarea { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public double? HorasEstimadas { get; set; }
		[Column()]
		public decimal? ValorHora { get; set; }
		[Column()]
		public bool ModificaValor { get; set; }
		[Column()]
		public bool Exento { get; set; }
		[Column()]
		public string IDTecnico { get; set; }
		[Column()]
		public bool PideDatosAdic { get; set; }
		[Column()]
		public double? TasaIVA { get; set; }
		[Column()]
		public string DescripcionAdicional { get; set; }
		[Column()]
		public string IDMONEDA { get; set; }
	}
}
