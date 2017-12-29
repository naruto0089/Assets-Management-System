

using System.ComponentModel.DataAnnotations;

namespace MyAssetData.Models
{
  public  class Book : Asset
    {
		[Required]
		public string ISBN { get; set; }

		[Required]
		public string Author { get; set; }

		[Required]
		public string DeweyIndex { get; set; }
	}
}
