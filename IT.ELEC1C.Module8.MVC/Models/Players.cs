using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT.ELEC1C.LeagueView.MVC.Models
{
	[Table("Players")]
	public class Players
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int ID { get; set; }
		public int TeamID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public decimal Height { get; set; }
		public string Position { get; set; }
		public decimal Weight { get; set; }
		public string DominantHand { get; set; }
		public int Age { get; set;  }
		public string Hometown { get; set; }
		public int Number { get; set; }
		public DateTime DateJoined { get; set; }
		
    }
}

