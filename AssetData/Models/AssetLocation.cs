using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyAssetData.Models
{
   public class AssetLocation
    {
		public int Id { get; set; }

		[Required]
		[StringLength(30, ErrorMessage ="Limit Branch name to 30 characters")]
		public string Name { get; set; }
		
		[Required]
		public string Address { get; set; }

		[Required]
		public string Telephone { get; set; }
		public string Description { get; set; }
		public DateTime OpenDate { get; set; }
	}
}
