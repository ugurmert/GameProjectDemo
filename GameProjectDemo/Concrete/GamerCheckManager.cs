using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
	public class GamerCheckManager : IGamerCheckService
	{
		public bool CheckIfRealGamer(Gamer gamer)
		{
			if (gamer.NationalityId == "12345678910" && gamer.FirstName == "Kadir Uğur" && gamer.LastName == "Mert" && gamer.DateOfBirth.Year == 1990)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
