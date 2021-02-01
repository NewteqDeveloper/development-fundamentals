using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public class Cat : Animal
    {
        public override AnimalType Type => AnimalType.Cat;

        public string Sound => "Meooooow....";

        public string Play()
        {
            return "Cat purrrrrs while playing with a scratcher";
        }
    }
}
