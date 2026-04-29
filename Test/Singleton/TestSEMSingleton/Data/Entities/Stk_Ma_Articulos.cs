using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[View (Name = "Stk_Ma_Articulos")]
	public partial class Stk_Ma_Articulos
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public string Deposito { get; set; }
		[Column()]
		public double Stock { get; set; }
		[Column()]
		public long ID { get; set; }
		[Column()]
		public string IDARTICULO { get; set; }
		[Column()]
		public string CODIGOBARRA { get; set; }
		[Column()]
		public string DESCRIPCION { get; set; }
		[Column()]
		public string CUENTAPROVEEDOR { get; set; }
		[Column()]
		public string IDUNIDAD { get; set; }
		[Column()]
		public string IDRUBRO { get; set; }
		[Column()]
		public string IDTIPO { get; set; }
		[Column()]
		public bool USASERIE { get; set; }
		[Column()]
		public bool USALOTE { get; set; }
		[Column()]
		public bool EXENTO { get; set; }
		[Column()]
		public string NOTAS { get; set; }
		[Column()]
		public long? PUNTOPEDIDO { get; set; }
		[Column()]
		public decimal? COSTO { get; set; }
		[Column()]
		public decimal? IMPUESTOS { get; set; }
		[Column()]
		public decimal? PRECIO1 { get; set; }
		[Column()]
		public decimal? PRECIO2 { get; set; }
		[Column()]
		public decimal? PRECIO3 { get; set; }
		[Column()]
		public decimal? PRECIO4 { get; set; }
		[Column()]
		public decimal? PRECIO5 { get; set; }
		[Column()]
		public bool SUSPENDIDO { get; set; }
		[Column()]
		public long? PUNTOMAXIMO { get; set; }
		[Column()]
		public byte[]? Imagen { get; set; }
		[Column()]
		public string PoliticaPrecios { get; set; }
		[Column()]
		public double? TasaIVA { get; set; }
		[Column()]
		public decimal? PRECIO6 { get; set; }
		[Column()]
		public decimal? PRECIO7 { get; set; }
		[Column()]
		public decimal? PRECIO8 { get; set; }
		[Column()]
		public decimal? PRECIO9 { get; set; }
		[Column()]
		public decimal? PRECIO10 { get; set; }
		[Column()]
		public bool SUSPENDIDOV { get; set; }
		[Column()]
		public bool SUSPENDIDOC { get; set; }
		[Column()]
		public string IMAGEN_ICONO { get; set; }
		[Column()]
		public string IMAGEN_AMPLIADA { get; set; }
		[Column()]
		public string IMAGEN_AMPLIADA2 { get; set; }
		[Column()]
		public string USUARIO { get; set; }
		[Column()]
		public bool SUSPENDIDOGM { get; set; }
		[Column()]
		public string ABM { get; set; }
		[Column()]
		public double? CANT_MINIMA_PEDIDO_PROVEEDOR { get; set; }
		[Column()]
		public string UBICACION_HABITUAL { get; set; }
		[Column()]
		public string PROCEDENCIA { get; set; }
		[Column()]
		public bool BEBIDA_ALCOHOLICA { get; set; }
		[Column()]
		public bool CONSIGNADO { get; set; }
		[Column()]
		public bool SUSPENDIDOWEB { get; set; }
		[Column()]
		public bool NO_CONTROLA_STOCK { get; set; }
		[Column()]
		public string IDUNIDADSUELTOS { get; set; }
		[Column()]
		public bool SolicitaDatosMatarife { get; set; }
		[Column()]
		public string IDMONEDA { get; set; }
		[Column()]
		public string CODIGOARTPROVEEDOR { get; set; }
		[Column()]
		public string CODIGOBARRA2 { get; set; }
		[Column()]
		public string CODIGOBARRA3 { get; set; }
		[Column()]
		public string CODIGOBARRA4 { get; set; }
		[Column()]
		public string CODIGOBARRA5 { get; set; }
		[Column()]
		public string IDFAMILIA { get; set; }
		[Column()]
		public string ULTIMO_NRO_DESPACHO { get; set; }
		[Column()]
		public string IDBONIFICACION { get; set; }
		[Column()]
		public decimal? MK_PRECIO1 { get; set; }
		[Column()]
		public decimal? MK_PRECIO2 { get; set; }
		[Column()]
		public decimal? MK_PRECIO3 { get; set; }
		[Column()]
		public decimal? MK_PRECIO4 { get; set; }
		[Column()]
		public decimal? MK_PRECIO5 { get; set; }
		[Column()]
		public decimal? MK_PRECIO6 { get; set; }
		[Column()]
		public decimal? MK_PRECIO7 { get; set; }
		[Column()]
		public decimal? MK_PRECIO8 { get; set; }
		[Column()]
		public decimal? MK_PRECIO9 { get; set; }
		[Column()]
		public decimal? MK_PRECIO10 { get; set; }
		[Column()]
		public bool IVA_INCLUIDO { get; set; }
	}
}
