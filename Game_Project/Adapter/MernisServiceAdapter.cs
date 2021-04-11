using Game_Project.Abstract;
using Game_Project.Entities;
using Game_Project.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Project.Adapter
{
    public  class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula
                (
                gamer.Id,
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(),
                gamer.DateOfBirth.Year
                );
        }
    }
}
