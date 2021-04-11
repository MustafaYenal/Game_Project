using Game_Project.Abstract;
using Game_Project.Concrete;
using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManagerI();
            Gamer gamer1=new Gamer()
            {
                Id = 1,
                FirstName = "Burak",
                LastName = "KARA",
                DateOfBirth = new DateTime(2002, 7, 8),
                NationalityId = "74185296310"
            };
            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Mustafa";
            gamer2.LastName = "YENAL";
            gamer2.DateOfBirth = new DateTime(2002, 8, 7);
            gamer2.NationalityId = "35795145687";

            Gamer gamer3 = new Gamer();
            gamer3.Id = 3;
            gamer3.FirstName = "Evsa";
            gamer3.LastName = "YENAL";
            gamer3.DateOfBirth = new DateTime(2005, 10, 7);
            gamer3.NationalityId = "96336978514";

            gamerManager.Add(gamer1);
            Console.WriteLine();
            gamerManager.Delete(gamer2);
            Console.WriteLine();
            gamerManager.Update(gamer3);
            Console.WriteLine();

            Game game1 = new Game()
            {
                GameId = 15,
                GameName = "bus driving",
                GamePrice = 599.99,
            };
            Game game2 = new Game()
            {
                GameId = 18,
                GameName = "car racing ",
                GamePrice = 1499.99,
            };
            Game game3 = new Game()
            {
                GameId = 10,
                GameName = "Playstation",
                GamePrice = 6999.99,
            };



            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            Console.WriteLine();
            gameManager.Delete(game2);
            Console.WriteLine();
            gameManager.Update(game3);
            Console.WriteLine();

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 9,
                CampaignName = "Ilkbahar",
                CampaignDiscount = 30.00,
            };
            Campaign campaign2 = new Campaign()
            {
                CampaignId = 9,
                CampaignName = "Sonbahar",
                CampaignDiscount = 15.00,
            };
            Campaign campaign3 = new Campaign()
            {
                CampaignId = 9,
                CampaignName = "Yaz",
                CampaignDiscount = 25.00,
            };


            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            Console.WriteLine();
            campaignManager.Delete(campaign2);
            Console.WriteLine();
            campaignManager.Update(campaign3);
            Console.WriteLine();

            OrderManager orderManager = new OrderManager();
            orderManager.SalesGame(gamer1, game1, campaign1);

            Console.ReadLine();





        }
    }
}
