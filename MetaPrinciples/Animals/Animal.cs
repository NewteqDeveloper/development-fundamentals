using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Animals
{
    public abstract class Animal
    {
        public abstract AnimalType Type { get; }

        public string Name { get; set; }
    }
}
