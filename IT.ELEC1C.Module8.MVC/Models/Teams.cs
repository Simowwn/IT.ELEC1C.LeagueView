using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT.ELEC1C.LeagueView.MVC.Models
{
	[Table("Teams")]
	public class Teams
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int ID { get; set; }
        public string Name { get; set; }
		public string Coach { get; set; }
		public string City{ get; set; }
        public string Barangay { get; set; }
        public DateTime DateFormed { get; set; }
  


    }
}

