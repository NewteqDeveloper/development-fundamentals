using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MetaPrinciples.Animals;
using MetaPrinciples.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MetaPrinciples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    /*
     * Biggest key to API is consistency, ensure constitency in this API
     * 
     * The 4 princples of API are:
     *  1. Simplicity
	    2. Expressiveness
	    3. Extensibility
	    4. Consistency
     * 
     * Include missing animals in this farm
     */
    public class FarmController : ControllerBase
    {
        private readonly AnimalService animalService;

        public FarmController()
        {
            // animal service should not be new'd up
            this.animalService = new AnimalService();
        }

        [HttpGet]
        [Route("getAll")]
        public IList<Animal> GetAllAnimals()
        {
            return animalService.Animals();
        }

        [HttpGet]
        [Route("getAllCats")]
        public List<Animal> GetAllCats()
        {
            return animalService.Animals().Where(x => x.Type == AnimalType.Cat).ToList();
        }

        [HttpGet]
        [Route("getDogs")]
        public IEnumerable<Animal> GetAllDogs()
        {
            return animalService.GetAllDogs();
        }

        [HttpGet]
        [Route("getTheCowsOnTheFarm")]
        public IActionResult GetAllCows()
        {
            animalService.GetAnimals();
            return Ok(animalService.GetCows());
        }

        [HttpGet]
        [Route("whatDoesTheDogSay")]
        public string DogSound()
        {
            var animalDog = animalService.Animals().FirstOrDefault(x => x.Type == AnimalType.Dog);
            var dog = (Dog)animalDog;
            return dog.Bark();
        }

        [HttpGet]
        [Route("CatSays")]
        public string CatSays()
        {
            var animalCat = animalService.Animals().FirstOrDefault(x => x.Type == AnimalType.Cat);
            var cat = (Cat)animalCat;
            return cat.Sound;
        }

        [HttpGet]
        [Route("cowSound")]
        public string CowSoundMakes()
        {
            var animalCow = animalService.Animals().FirstOrDefault(x => x.Type == AnimalType.Cow);
            var cow = (Cow)animalCow;
            return cow.MakeSound();
        }

        // TODO separation of concerns with reporting on animals

        [HttpGet]
        [Route("howManyDogs")]
        public string HowManyDogs()
        {
            return animalService.ReportOfDogs();
        }

        [HttpGet]
        [Route("NumberofCats")]
        public IActionResult NoCats()
        {
            // TODO princple of least astonishment
            animalService.ReportOfDogs();
            return Ok(animalService.ReportOfCats());
        }
    }
}
