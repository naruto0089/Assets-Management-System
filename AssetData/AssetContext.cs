using Microsoft.EntityFrameworkCore;
using MyAssetData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAssetData
{
   public  class AssetContext : DbContext
    {
		public AssetContext(DbContextOptions options) : base(options){}

		public DbSet<Book> Books { get; set; }
		public DbSet<Video> Videos { get; set; }
		public DbSet<Asset> Assets { get; set; }
		public DbSet<AssetLocation> AssetLocations { get; set; }
		public DbSet<Status> Statuses { get; set; }
		
	}
}
