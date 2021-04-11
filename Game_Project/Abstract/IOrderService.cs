using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Abstract
{
    public interface IOrderService
    {
        void SalesGame(Gamer gamer, Game game, Campaign campaign);
    }
}
