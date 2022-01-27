using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            {
                result["rhino"] = "Crash";
                result["giraffe"] = "Tower";
                result["elephant"] = "Herd";
                result["lion"] = "Pride";
                result["crow"] = "Murder";
                result["pigeon"] = "Kit";
                result["flamingo"] = "Pat";
                result["deer"] = "Herd";
                result["dog"] = "Pack";
                result["crocodile"] = "Float";
            }

            if (animalName == null)
            {
                return "unknown";
            }
            animalName = animalName.ToLower();

            if (result.ContainsKey(animalName))
            {
                foreach (string item in result.Keys)
                {
                    if (item == animalName)
                    {
                        return result[item];
                    }
                }
            }
            else if (!result.ContainsKey(animalName))
            {
                return "unknown";
            }

            //{
            //    foreach (string item in result.Keys)
            //    {
            //        animalName = animalName.ToLower();
            //        if (animalName == null)
            //        {
            //            return "unknown";
            //        }





            //        else if ((result.ContainsKey(animalName)) && (animalName == item))
            //            animalName = animalName.ToLower();
            //        {
            //            string groupName = result[animalName];
            //            return groupName;
            //        }
            //    }
            //}
            return "unknown";
        }
    }
}
