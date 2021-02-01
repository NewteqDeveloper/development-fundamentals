using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public class Bird : Animal
    {
        public override AnimalType Type => AnimalType.Bird;

        public string PlayFly()
        {
            return "Bird flies around the block and back";
        }
    }
}
