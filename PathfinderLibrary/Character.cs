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
        public Dictionary<string, BaseClass> Classes = new Dictionary<string,BaseClass>();
        #endregion

        #region Properties
        public int Size { get; set; }
        public char Gender  { get;
            set
            {
                if (value == 'M' || value == 'F')
                {
                    Gender = value;
                }
                else
                {
                    throw new Exception("Unkown gender value passed to character object.");
                }
            }
        }
        public int Age { get; set; }
        public BaseRace Race { get; set; }
        public string Name { get; set; }


        //The 'Environment' object that this character was created in, this limits the context that the character is active in, including available Classes and Races.
        public Environment Scope { get; private set;} 

        //<summary>
        //The Characters alignment as a a 2 dimensional coordinate. This maps to the following table:
        //
        //  Lawful Good     |  Neutral Good | Chaotic Good
        //  ----------------|---------------|---------
        //  Lawful Neutral  |    Neutral    | Chaotic Neutral
        //  ----------------|---------------|---------
        //  Lawful Evil     |  Neutral Evil | Chaotic Evil
        //
        //  e.g. Lawful Good would be (0,0).
        //</summary>
        public Point Alignment { get; set; }
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

        //<summary>
        //Return the modifier of one of the six basic stats based on the stat name given as a string input.
        //</summary>
        public int getStatModifier(string input)
        {
            double raw = (Stats[input] - 10)/2.0;

            return (int) Math.Floor(raw);
        }

        //<summary>
        //Retrieves the miscellaneous effects that are currently modifying the characters initiative.
        //</summary>
        public int InitiativeMiscModifier()
        {
            //TODO: Implement this. Will require me to start keeping track of gear and equipment.
            //This should return the SUM of the initiative modifiers based on equipped or active items.
            return 0;
        }

        //<summary>
        //Returns the characters initiative modifier based on dexterity and miscellaneous modifiers.
        //</summary>
        public int InitiativeMod()
        {
            return getStatModifier("DEX") + InitiativeMiscModifier();
        }
    }
}