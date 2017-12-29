﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAssetManagementSystem.Models.Catalog
{
    public class AssetDetailModel
    {
		public int AssetId{ get; set; }
		public string Title { get; set; }
		public string AuthorOrDirector { get; set; }
		public string Type { get; set; }
		public int Year { get; set; }
		public string ISBN { get; set; }
		public string DeweyCallNumber { get; set; }
		public string Status { get; set; }
		public string Cost { get; set; }
		public string ImageUrl { get; set; }
		public string PatronName { get; set; }
		

	}
}
