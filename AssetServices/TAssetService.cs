using Microsoft.EntityFrameworkCore;
using MyAssetData;
using MyAssetData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetServices
{
	public class TAssetService : IAsset
	{
		private AssetContext _context;
		public TAssetService(AssetContext context)
		{
			_context = context;
		}


		public void Add(Asset newAsset)
		{
			_context.Add(newAsset);
			_context.SaveChanges();
		}

		public IEnumerable<Asset> GetAll()
		{
			return _context.Assets
				.Include(asset => asset.Location)
				.Include(asset => asset.Status);
		}

		public Asset GetAsset(int id)
		{
			return _context.Assets
				.Include(asset => asset.Location)
				.Include(asset => asset.Status)
				.FirstOrDefault(asset => asset.Id == id);
		}

		public AssetLocation GetAssetCurrentLocation(int id)
		{
			return _context.Assets.FirstOrDefault(asset => asset.Id == id).Location;
		}

		public string GetAuthorOrDirector(int id)
		{
			var isBook = _context.Assets.OfType<Book>()
				.Where(asset => asset.Id == id).Any();

			var isVideo = _context.Assets.OfType<Video>()
				.Where(asset => asset.Id == id).Any();

			return isBook ?
				_context.Books.FirstOrDefault(book => book.Id == id).Author :
				_context.Videos.FirstOrDefault(video => video.Id == id).Director
				?? "Unknown";
		}

		public string GetDeweyIndex(int id)
		{
			if (_context.Books.Any(book => book.Id == id))
				return _context.Books.FirstOrDefault(book => book.Id == id).DeweyIndex;
			return "";
		}

		public string GetIsbn(int id)
		{
			if (_context.Books.Any(book => book.Id == id))
				return _context.Books.FirstOrDefault(book => book.Id == id).ISBN;
			return "";
		}

		public string GetTitle(int id)
		{
			return _context.Assets.SingleOrDefault(asset => asset.Id == id).Title;
		}

		public string GetType(int id)
		{
			var book = _context.Assets.OfType<Book>()
				.Where(b => b.Id == id);

			return book.Any() ? "Book" : "Video";
		}
	}
}
