using System;
using System.Collections.Generic;
using System.Text;

namespace MyAssetData.Models
{
   public abstract class Asset
    {
		public int Id { get; set; }
		public string Title { get; set; }
		public int Year { get; set; }
		public Status Status { get; set; }
		public decimal Cost { get; set; }
		public string ImageUrl { get; set; }
		public int NumberOfCopies { get; set; }
		public virtual AssetLocation Location { get; set; }
	}
}
