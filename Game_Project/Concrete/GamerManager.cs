using Game_Project.Abstract;
using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Concrete
{
    public class GamerManager: BaseGamerManager
    {
        IGamerCheckService _gamerCheckService;
        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }    
        }
    }
}
