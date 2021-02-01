using MetaPrinciples.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetaPrinciples.Services
{
    public class AnimalService
    {
        // Use to simulate connection to the database
        public bool IsConnected { get; private set; }

        private List<Animal> animals;

        public AnimalService()
        {

        }

        public void GetAnimals()
        {
            animals = Database.Data.Animals.ToList();
        }

        public IList<Animal> Animals()
        {
            // load default animals
            return Database.Data.Animals;
        }

        public IList<Animal> GetCows()
        {
            return animals.Where(x => x.Type == AnimalType.Cow).ToList();
        }

        public IEnumerable<Dog> GetAllDogs()
        {
            return animals.Where(x => x.Type == AnimalType.Dog).Select(x => (Dog)x);
        }

        // principle of least astonishment
        public string ReportOfDogs()
        {
            if (!IsConnected)
            {
                IsConnected = true; // simulate opening database connection
            }

            if (animals == null)
            {
                animals = Animals().ToList();
            }

            var dogs = animals.Where(x => x.Type == AnimalType.Dog);
            return $"There are a total of: {dogs.Count()} dogs";
        }

        public string ReportOfCats()
        {
            // TODO princple of least astonishment
            
            if (!IsConnected)
            {
                throw new InvalidOperationException("Connection to the database is not opened yet");
            }

            var cats = animals.Where(x => x.Type == AnimalType.Cat);
            return $"There are a total of: {cats.Count()} cats";
        }
    }
}
