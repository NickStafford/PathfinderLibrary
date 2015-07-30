using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
          public abstract class BaseClass
          {
                    private int _hitDie;
                    private BaseSkill[] _classSkills;
                    private BaseFeature _classFeatures;

                    internal BaseFeature ClassFeatures
                    {
                              get { return _classFeatures; }
                              set { _classFeatures = value; }
                    }

                    internal BaseSkill[] ClassSkills
                    {
                              get { return _classSkills; }
                              set { _classSkills = value; }
                    }

                    public int HitDie
                    {
                              get { return _hitDie; }
                              set { _hitDie = value; }
                    }

          }
}
