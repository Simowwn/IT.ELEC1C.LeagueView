using System;
using IT.ELEC1C.LeagueView.MVC.Models;

namespace IT.ELEC1C.LeagueView.MVC.Services
{
	public interface IProductDataService
	{
		Task<List<Teams>> GetProductsAsync();
		Task AddProductAsync(Teams teams);
		Task DeleteProduct(Teams teams);
		Task UpdateProduct(Teams teams);


    }
}

