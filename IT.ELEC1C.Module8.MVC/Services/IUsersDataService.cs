using System;
using IT.ELEC1C.LeagueView.MVC.Models;

namespace IT.ELEC1C.LeagueView.MVC.Services
{
	public interface IUsersDataService
	{

		Task<List<Users>> GetUsersAsync();
		//Task AddPlayers(Players players);
		//void DeletePlayers(Players players);
		//void UpdatePlayers(Players players);


    }
}

