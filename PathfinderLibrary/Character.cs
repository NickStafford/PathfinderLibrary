using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
    public class Character
    {
        #region Fields
        private int[] _alignment = new int[2]; //e.g. 0,0 = Lawful Good. 2,1 = Chaotic Neutral
        public Dictionary<string, int> Stats = new Dictionary<string, int>();
        #endregion

        #region Properties
        public int Size { get; set; }
        public char Gender  { get; set; }
        public int Age { get; set; }
        public BaseRace Race { get; set; }
        public string Name { get; set; }
        public BaseClass[] Classes { get; set; }
        public int[] Alignment
        {
            get { return _alignment; }
            set { _alignment = value; }
        }
        #endregion

        public Character(string inputName, BaseRace inputRace, BaseClass initialClass)
        {
            Name = inputName;
            Race = inputRace;
            Classes[0] = initialClass;

            //Initialise the values of the characters statistics.
            Stats.Add("STR", 10);
            Stats.Add("DEX", 10);
            Stats.Add("CON", 10);
            Stats.Add("INT", 10);
            Stats.Add("WIS", 10);
            Stats.Add("CHA", 10);
        }

        public getStatModifier(string statName) {
            int statLevel = Stats[statName];

            return Math.Floor((statLevel - 10) / 2);
        }
    }
}