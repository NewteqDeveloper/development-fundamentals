using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Database
{
    public static class Data
    {

        public static IList<Animal> Animals = new List<Animal>
            {
                new Cat
                {
                    Name = "Kitty"
                },
                new Dog
                {
                    Name = "Doggo"
                },
                new Dog
                {
                    Name = "Max"
                },
                new Dog
                {
                    Name = "Billy",
                },
                new Cat
                {
                    Name = "Ginger"
                },
                new Cow
                {
                    Name = "Cowie"
                },
                new Cow
                {
                    Name = "Milky"
                },
                new Sheep
                {
                    Name = "Ba ba sheep"
                },
                new Chicken
                {
                    Name = "Chucky"
                },
                new Bird
                {
                    Name = "Tweety"
                }
            };
    }
}
