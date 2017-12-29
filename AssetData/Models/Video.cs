

using System.ComponentModel.DataAnnotations;

namespace MyAssetData.Models
{
 public class Video : Asset
    {
		[Required]
		public string Director { get; set; }
	}
}
