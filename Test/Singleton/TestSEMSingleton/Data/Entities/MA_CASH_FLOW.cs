using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "MA_CASH-FLOW")]
	public partial class MA_CASH_FLOW
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column( IsPrimaryKey = true)]
		public string CODIGO { get; set; }
		[Column()]
		public string NOMBRE { get; set; }
		[Column()]
		public bool MODIFICADO { get; set; }
		[Column( Name = "PERIODO 1")]
		public string PERIODO1 { get; set; }
		[Column( Name = "PERIODO 2")]
		public string PERIODO2 { get; set; }
		[Column( Name = "PERIODO 3")]
		public string PERIODO3 { get; set; }
		[Column( Name = "PERIODO 4")]
		public string PERIODO4 { get; set; }
		[Column( Name = "PERIODO 5")]
		public string PERIODO5 { get; set; }
		[Column( Name = "PERIODO 6")]
		public string PERIODO6 { get; set; }
		[Column( Name = "PERIODO 7")]
		public string PERIODO7 { get; set; }
		[Column( Name = "PERIODO 8")]
		public string PERIODO8 { get; set; }
		[Column( Name = "PERIODO 9")]
		public string PERIODO9 { get; set; }
		[Column( Name = "PERIODO 10")]
		public string PERIODO10 { get; set; }
		[Column( Name = "PERIODO 11")]
		public string PERIODO11 { get; set; }
		[Column( Name = "PERIODO 12")]
		public string PERIODO12 { get; set; }
	}
}
