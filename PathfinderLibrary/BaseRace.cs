using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
    public class BaseRace
    {
        public string Name { get; set; }

        public BaseRace(string inputName)
        {
            Name = inputName;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
