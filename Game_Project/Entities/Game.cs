using Game_Project.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Entities
{
    public class Game: IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public double GamePrice { get; set; }
    }
}
