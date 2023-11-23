using System;
using IT.ELEC1C.LeagueView.MVC.Data;
using IT.ELEC1C.LeagueView.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace IT.ELEC1C.LeagueView.MVC.Services
{
	public class UsersDataService : IUsersDataService
	{

		private AppDbContext _appDbContext;

		public UsersDataService(AppDbContext appDbContext)
		{
            _appDbContext = appDbContext;
        }

        public async Task<List<Users>> GetUsersAsync()
        {
            var users = await _appDbContext.Users.ToListAsync();
            return users;

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

