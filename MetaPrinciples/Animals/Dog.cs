using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public class Dog : Animal
    {
        public override AnimalType Type => AnimalType.Dog;

        public string Bark()
        {
            return "Bark!";
        }

        public string PlayFetch()
        {
            return "Dog fetches stick";
        }
    }
}
