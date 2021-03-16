using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
	public class GamerManager : IGamerService
	{
		private IGamerCheckService _gamerCheckService;

		public GamerManager(IGamerCheckService gamerCheckService)
		{
			_gamerCheckService = gamerCheckService;
		}

		public void Add(Gamer gamer)
		{
			if (_gamerCheckService.CheckIfRealGamer(gamer) == true)
			{
				Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " added");
			}
			else
			{
				Console.WriteLine("Wrong information. Registration failed");
			}
		}

		public void Delete(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " deleted");
		}

		public void Update(Gamer gamer)
		{
			Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " updated");
		}
	}
}
