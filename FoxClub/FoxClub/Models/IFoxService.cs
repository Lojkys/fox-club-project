using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public interface IFoxService
    {
        List<Fox> ListOfFoxes { get; set; }
        void AddFoxToDatabase(Fox fox);
        Fox GetFoxByName(string name);
    }
}
