using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SysWork.Data.Mapping;
namespace SysWork.SWCG.Test.Entities.Entities
{
	[Table (Name = "TA_DistLocalidades")]
	public partial class TA_DistLocalidades
	{
		/// <summary>
		/// This class was created automatically with SysWork.EntityManager.
		/// Please check the DbTypes and the field names.
		/// </summary>

		[Column()]
		public long id { get; set; }
		[Column()]
		public string Localidad { get; set; }
		[Column()]
		public double? Distancia { get; set; }
	}
}
