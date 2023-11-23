using System;
using IT.ELEC1C.LeagueView.MVC.Data;
using IT.ELEC1C.LeagueView.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;

namespace IT.ELEC1C.LeagueView.MVC.Services
{
	public class ProductDataService : IProductDataService
	{

		private AppDbContext _appDbContext;

		public ProductDataService(AppDbContext appDbContext)
		{
            _appDbContext = appDbContext;
        }

        public async Task<List<Teams>> GetProductsAsync()
        {
            var teams = await _appDbContext.Teams.ToListAsync();
            return teams;

        }

        public async Task AddProductAsync(Teams teams)
        {
            await _appDbContext.Teams.AddAsync(teams);
            await _appDbContext.SaveChangesAsync();

        }

        public async Task DeleteProduct(Teams teams)
        {

            var selectedProduct = await _appDbContext.Teams.FirstOrDefaultAsync(x => x.ID == teams.ID);

            if (selectedProduct != null)
            {
                _appDbContext.Teams.Remove(selectedProduct);

                await _appDbContext.SaveChangesAsync();

            }

           
        }

        public async Task UpdateProduct(Teams teams)
        {
            var selectedProduct = await _appDbContext.Teams.FirstOrDefaultAsync(x => x.ID == teams.ID);

            if (selectedProduct != null)
            {
                selectedProduct.Name = teams.Name;
                selectedProduct.Coach = teams.Coach;
                selectedProduct.City = teams.City;
                selectedProduct.Barangay = teams.Barangay;
                selectedProduct.DateFormed = teams.DateFormed;



                await _appDbContext.SaveChangesAsync();

            }
        }
        /**
        var selectedProduct = _products.FirstOrDefault(x => x.Id == product.Id);

        if (selectedProduct != null)
        {
            _products.Remove(selectedProduct);
        }
        **/






























        //[HttpGet]
        //public IActionResult AddProduct()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> AddProductAsync(Teams teams);
        //{
        //    await _service.AddProductAsync(teams);
        //return RedirectToActionResult("Index");




        //public async Task AddProductAsync(Players players)
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
        //public async Task<List<Teams>> GetProductsAsync()
        //{
        //    var teams = await _appDbContext.Teams.ToListAsync();
        //    return teams;

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

