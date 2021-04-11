using Game_Project.Abstract;
using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} game added.", game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} game deleted.", game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} game updated.", game.GameName);
        }
    }
}
