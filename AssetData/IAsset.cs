using MyAssetData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAssetData
{
  public interface IAsset
    {
		IEnumerable<Asset> GetAll();
		Asset GetAsset(int id);
		void Add(Asset newAsset);
		string GetAuthorOrDirector(int id);
		string GetDeweyIndex(int id);
		string GetType(int id);
		string GetTitle(int id);
		string GetIsbn(int id);

		AssetLocation GetAssetCurrentLocation(int id);
    }
}
