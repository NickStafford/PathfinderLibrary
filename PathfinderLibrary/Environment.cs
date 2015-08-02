using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderLibrary
{
    public class Environment
    {
        public static BaseClass[] ClassesArray(string classesConfigPath)
        {
            //TODO: Initialise a global array of all the classes from a file.
            
            return new BaseClass[0];

            //This should be called by the program using this library to create the array of classes to build an environment.
        }

        public static BaseRace[] RacesArray(string racesConfigPath)
        {
            //TODO: Initialise a global array of all the races from a file.

            //This should be called by the program using this library to create the array of classes to build an environment.

            return new BaseRace[0];
        }

        public static BaseFeature[] FeaturesArray(string featuresConfigPath)
        {
            //TODO: Initialise a global array of all the features from a file.

            //This should be called by the program using this library to create the array of features to build an environment.

            return new BaseFeature[0];
        }


    }
}
