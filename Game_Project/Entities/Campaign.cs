using Game_Project.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Entities
{
    public class Campaign: IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
