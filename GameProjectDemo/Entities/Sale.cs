using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
	public class Sale : IEntity
	{
		public int Id { get; set; }
		public int GameId { get; set; }
		public int GamerId { get; set; }
		public DateTime SaleDate { get; set; }
	}
}
