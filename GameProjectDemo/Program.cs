using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                NationalityId = "12345678910",
                FirstName = "Kadir Uğur",
                LastName = "Mert",
                DateOfBirth = new DateTime(1990, 10, 07)
            };

            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                NationalityId = "12345678910",
                FirstName = "Uğur",
                LastName = "Mert",
                DateOfBirth = new DateTime(1990, 10, 07)
            };

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());

            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);

            Game game1 = new Game()
            {
                Id = 1,
                GameName = "Cyberpunk 2077",
                GamePrice = 249
            };

            Game game2 = new Game()
            {
                Id = 2,
                GameName = "Microsoft Flight Simulator",
                GamePrice = 349
            };

            GameManager gameManager = new GameManager();

            gameManager.Add(game1);
            gameManager.Add(game2);
            gameManager.Update(game1);
            gameManager.Delete(game2);

            Campaign campaign = new Campaign
            {
                Id = 1,
                CampaignName = "New Year",
                CampaignStartDate = new DateTime(2021, 01, 01),
                CampaignDuration = 30,
                Discount = 21,
            };

            CampaignManager campaignManager = new CampaignManager();

            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            SaleManager saleManager = new SaleManager();

            saleManager.Sale(gamer1, game1);
            saleManager.Sale(gamer1, game2, campaign);
        }
    }
}
