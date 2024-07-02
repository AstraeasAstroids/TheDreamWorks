using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDreamWorks
{
    public class Chore
    {
        public string ChoreName { get; }
        public DateTime DayofChore { get; }


        public Chore(string name, DateTime dt) 
        {
            ChoreName = name;
            DayofChore = dt;
        }
        
    }
}
