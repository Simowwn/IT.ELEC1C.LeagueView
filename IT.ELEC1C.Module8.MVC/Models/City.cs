using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT.ELEC1C.LeagueView.MVC.Models
{
	[Table("City")]
	public class City
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int ID { get; set; }
        public string Name { get; set; }
		public int ZipCode { get; set; }

	
    }
}

