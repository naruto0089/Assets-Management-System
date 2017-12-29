using System.ComponentModel.DataAnnotations;

namespace MyAssetData.Models
{
   public class Status
    {
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string Descriptioin { get; set; }

	}
}
