using System;
using IT.ELEC1C.LeagueView.MVC.Data;
using IT.ELEC1C.LeagueView.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace IT.ELEC1C.LeagueView.MVC.Services
{
	public class CityDataService : ICityDataService
	{

		private AppDbContext _appDbContext;

		public CityDataService(AppDbContext appDbContext)
		{
            _appDbContext = appDbContext;
        }

        public async Task<List<City>> GetCityAsync()
        {
            var city = await _appDbContext.City.ToListAsync();
            return city;

        }



        //public async task addplayersasyn(players players)
        //{
        //    await _appdbcontext.players.addasync(players);
        //    await _appdbcontext.savechangesasync();
        //    _products.add(product);
        //}

        //public void deleteplayer(players players)
        //{

        //}

        //public void updateplayer(players players)
        //{

        //}
        //public async Task<List<Players>> GetPlayerAsync()
        //{
        //    var players = await _appDbContext.Teams.ToListAsync();
        //    return players;
   
        //}

        //public async Task AddProductAsync(Teams teams);
        //{
        // await _appDbContext.Teams.AddAsync(teams);
        //await _appdbcontext.savechangesasync();
        // _products.add(product);
        //}

        //public void DeleteProduct(Teams teams)
        //{
        //   var selectedProduct = _products.FirstOrDefault(x => x.Id == product.Id);

        //   if (selectedProduct != null)
        //    {
        //       _products.Remove(selectedProduct);
        //    }
        //}

        //public void UpdateProduct(Teams teams)
        //{
        //   var selectedProduct = _products.FirstOrDefault(x => x.Id == product.Id);

        //   if (selectedProduct != null)
        //    {
        //       selectedProduct.Name = product.Name;
        //       selectedProduct.Price = product.Price;
        //    }
        //}
    }
}

