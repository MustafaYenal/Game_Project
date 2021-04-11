using Game_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("{0}-{1} gamer added.",gamer.FirstName,gamer.LastName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("{0}-{1} gamer deleted.", gamer.FirstName, gamer.LastName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("{0}-{1} gamer updated.", gamer.FirstName, gamer.LastName);
        }
    }
}
