using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Core;
using IT.ELEC1C.LeagueView.MVC.Models;
using IT.ELEC1C.LeagueView.MVC.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IT.ELEC1C.LeagueView.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductDataService _service;
        private IPlayerDataService _playerservice;
        private ICityDataService _cityservice;
        private IUsersDataService _usersservice;

        public ProductController(IProductDataService service, IPlayerDataService service2, ICityDataService service3, IUsersDataService service4)
        {
            _service = service;
            _playerservice = service2;
            _cityservice = service3;
            _usersservice= service4;
        }

        

        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var teams = await _service.GetProductsAsync();
            return View(teams);
        }
        public async Task<IActionResult> Index2()
        {
            var players = await _playerservice.GetPlayersAsync();
            return View(players);
        }
        public async Task<IActionResult> Index3()
        {
            var city = await _cityservice.GetCityAsync();
            return View(city);
        }
        public async Task<IActionResult> Index4()
        {
            var users = await _usersservice.GetUsersAsync();
            return View(users);
        }

        //Teams Controllers
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Teams teams)
        {
            await _service.AddProductAsync(teams);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var products = await _service.GetProductsAsync();
            var product = products.Where(x => x.ID == id).FirstOrDefault();

            //var product = _service.GetProducts().FirstOrDefault(x => x.Id == id);
            //return View(product);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(Teams teams)
        {

            await _service.DeleteProduct(teams);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {

            var products = await _service.GetProductsAsync();
            var product = products.Where(x => x.ID == id).FirstOrDefault();
            //var product = _service.GetProducts().FirstOrDefault(x => x.Id == id);
            //return View(product);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(Teams teams)
        {
            await _service.UpdateProduct(teams);
            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public IActionResult AddProduct()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> AddProductAsync(Teams teams)

        //{
        //    await _service.AddProductAsync(teams);
        //    return RedirectToAction("Index");
        //}


      

        //[HttpPost]
        //public IActionResult UpdateProduct(Teams teams)
        //{
        //    _service.UpdateProduct(teams);
        //    return RedirectToAction("Index");
        //}
    }
}