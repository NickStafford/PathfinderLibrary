using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
    public class Environment
    {
        #region Fields
        private Dictionary<string, BaseClass> _knownClasses;
        private Dictionary<string, BaseRace> _knownRaces;
        #endregion

        public BaseClass[] ClassesArray(string classesConfigPath)
        {
            //TODO: Initialise a global array of all the classes from a file.
            
            return new BaseClass[0];

            //This should be called by the program using this library to create the array of classes to build an environment.
        }

        public BaseRace[] initialiseRacesArray(string racesConfigPath)
        {
            //TODO: Initialise a global array of all the races from a file.

            //This should be called by the program using this library to create the array of classes to build an environment.

            return new BaseRace[0];
        }

        public BaseFeature[] FeaturesArray(string featuresConfigPath)
        {
            //TODO: Initialise a global array of all the features from a file.

            //This should be called by the program using this library to create the array of features to build an environment.

            return new BaseFeature[0];
        }


    }
}
