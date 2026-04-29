using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace Test.Entities
{
	[View (Name = "STK_STOCK_EQUIV")]
	public partial class STK_STOCK_EQUIV
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long ID { get; set; }
		[Column()]
		public string equivalencia { get; set; }
		[Column()]
		public double? COEFICIENTE { get; set; }
		[Column()]
		public double? cantidadEq { get; set; }
		[Column()]
		public string TC { get; set; }
		[Column()]
		public string IDCOMPROBANTE { get; set; }
		[Column()]
		public long? IDCOMPLEMENTO { get; set; }
		[Column()]
		public long? SECUENCIA { get; set; }
		[Column()]
		public DateTime? FECHA { get; set; }
		[Column()]
		public string IDArticulo { get; set; }
		[Column()]
		public string Descripcion { get; set; }
		[Column()]
		public string IDUnidad { get; set; }
		[Column()]
		public double? CantidadUD { get; set; }
		[Column()]
		public double? Cantidad { get; set; }
		[Column()]
		public decimal? Costo { get; set; }
		[Column()]
		public decimal? PrecioVenta { get; set; }
		[Column()]
		public decimal? IVARI { get; set; }
		[Column()]
		public decimal? IVARNI { get; set; }
		[Column()]
		public decimal? IMPUESTOS { get; set; }
		[Column()]
		public string IdLista { get; set; }
		[Column()]
		public Int16? ClasePrecio { get; set; }
		[Column()]
		public string CuentaProveedor { get; set; }
		[Column()]
		public string NroSerie { get; set; }
		[Column()]
		public string NroLote { get; set; }
		[Column()]
		public string IdDeposito { get; set; }
		[Column()]
		public string IdPosicion { get; set; }
		[Column()]
		public string Estado { get; set; }
		[Column()]
		public string IdMotivoStock { get; set; }
		[Column()]
		public string IdOrigen { get; set; }
		[Column()]
		public string IdDestino { get; set; }
		[Column()]
		public bool Revisado { get; set; }
		[Column()]
		public string ControladoPor { get; set; }
		[Column()]
		public bool Anulado { get; set; }
		[Column()]
		public string TC_Origen { get; set; }
		[Column()]
		public string IdComprobante_Origen { get; set; }
		[Column()]
		public long? IdComplemento_Origen { get; set; }
		[Column()]
		public long? Id_Origen { get; set; }
		[Column()]
		public string IdUnidadBase { get; set; }
		[Column()]
		public string IdTecnico { get; set; }
		[Column()]
		public string IDCHOFER { get; set; }
		[Column()]
		public string IDVEHICULO { get; set; }
		[Column()]
		public DateTime? fechahora_grabacion { get; set; }
		[Column()]
		public DateTime? fechahora_modificacion { get; set; }
	}
}
