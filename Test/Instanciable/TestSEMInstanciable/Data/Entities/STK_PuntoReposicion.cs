using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "STK_PuntoReposicion")]
	public partial class STK_PuntoReposicion
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string equivalencia { get; set; }
		[Column()]
		public double? Stock { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IDRUBRO { get; set; }
		[Column()]
		public string IDTIPO { get; set; }
		[Column()]
		public string IDFAMILIA { get; set; }
		[Column()]
		public long? PUNTOPEDIDO { get; set; }
	}
}
