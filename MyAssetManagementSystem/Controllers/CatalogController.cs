using Microsoft.AspNetCore.Mvc;
using MyAssetData;
using MyAssetManagementSystem.Models.Catalog;
using System.Linq;

namespace MyAssetManagementSystem.Controllers
{
    public class CatalogController : Controller
    {
		private IAsset _asset;
		public CatalogController(IAsset asset)
		{
			_asset = asset;
		}


		public IActionResult Index()
		{
			var assetModel = _asset.GetAll();

			var listingResult = assetModel.Select(result => new AssetIndexListingModel
			{
				Id = result.Id,
				ImageUrl = result.ImageUrl,
				AuthorOrDirector = _asset.GetAuthorOrDirector(result.Id),
				DeweyCallNumber = _asset.GetDeweyIndex(result.Id)

			});

			var model = new AssetIndexModel()
			{
				Assets = listingResult
			};

			return View(model);

		}

		//public IActionResult Detail(int id)
		//{
		//	var asset = _asset.GetAsset(id);



		//}


	}


}
