using Game_Project.Abstract;
using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Concrete
{
    public class OrderManager : IOrderService
    {
        public void SalesGame(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("     Player : "+gamer.FirstName+" - "+gamer.LastName);
            Console.WriteLine("Game to buy : "+game.GameName);
            Console.WriteLine(" Game price : "+game.GamePrice+" TL");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(campaign.CampaignName + "Discount rate : % " + campaign.CampaignDiscount);

            double price;
            price = (game.GamePrice)-(game.GamePrice * campaign.CampaignDiscount )/ 100;

            Console.WriteLine("Discount price : "+price+" TL");

        }
    }
}
