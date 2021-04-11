using Game_Project.Abstract;
using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} campaign added.",campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("{0} campaign deleted.", campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("{0} campaign updated.", campaign.CampaignName);
        }
    }
}
