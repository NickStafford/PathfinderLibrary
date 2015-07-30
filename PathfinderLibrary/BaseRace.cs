using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
    public abstract class BaseRace
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
