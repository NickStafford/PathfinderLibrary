using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
    public class BaseClass
    {
        internal BaseFeature ClassFeatures { get; set; }
    
        internal BaseSkill[] ClassSkills { get; set; }
    
        public int HitDie { get; set; }
    }
}
