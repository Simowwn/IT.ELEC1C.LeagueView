using System;
using IT.ELEC1C.LeagueView.MVC.Models;

namespace IT.ELEC1C.LeagueView.MVC.Services
{
	public interface ICityDataService
	{

		Task<List<City>> GetCityAsync();
		//Task AddPlayers(Players players);
		//void DeletePlayers(Players players);
		//void UpdatePlayers(Players players);


    }
}

