using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT.ELEC1C.LeagueView.MVC.Models
{
	[Table("Users")]
	public class Users
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int ID { get; set; }
        public string Email { get; set; }
		public string Username { get; set; }
		public string PasswordHash { get; set; }

	
    }
}

