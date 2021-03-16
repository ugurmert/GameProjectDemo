using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
	public class SaleManager : ISaleService
	{
		public void Sale(Gamer gamer, Game game)
		{
			Console.WriteLine(game.GameName + " game was purchased by " + gamer.FirstName + " " + gamer.LastName);
		}
		public void Sale(Gamer gamer, Game game, Campaign campaign)
		{
			Console.WriteLine(game.GameName + " game was purchased by " + gamer.FirstName + " " + gamer.LastName + " with " + campaign.Discount + "% discount");
		}
	}
}
