using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entities
{
	public class Campaign : IEntity
	{
		public int Id { get; set; }
		public string CampaignName { get; set; }
		public DateTime CampaignStartDate { get; set; }
		public int CampaignDuration { get; set; }
		public int Discount { get; set; }
		public int CampaignPrice { get; set; }
	}
}
