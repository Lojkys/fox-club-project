using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxService : IFoxService
    {
        public List<Fox> ListOfFoxes { get; set; }
        public Fox CurrentFox { get; set; }

        public FoxService()
        {
            ListOfFoxes = new List<Fox>();
        }

        public void AddFoxToDatabase(Fox fox)
        {
            ListOfFoxes.Add(fox);
        }

        public Fox GetFoxByName(string name)
        {
            CurrentFox = ListOfFoxes.Find(fox => fox.Name.Equals(name));
            return CurrentFox;
        }
    }
}
