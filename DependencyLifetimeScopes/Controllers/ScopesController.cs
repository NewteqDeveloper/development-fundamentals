using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyLifetimeScopes.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DependencyLifetimeScopes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScopesController : ControllerBase
    {
        private readonly IServiceOne testingServiceOne;
        private readonly IServiceTwo testingServiceTwo;
        private readonly ISingleton singleton;
        private readonly IScoped scoped;
        private readonly ITransient transient;

        public ScopesController(IServiceOne testingServiceOne, IServiceTwo testingServiceTwo, ISingleton singleton, IScoped scoped, ITransient transient)
        {
            this.testingServiceOne = testingServiceOne;
            this.testingServiceTwo = testingServiceTwo;
            this.singleton = singleton;
            this.scoped = scoped;
            this.transient = transient;
        }

        [HttpPost("increase")]
        public IActionResult IncreaseAll()
        {
            this.testingServiceOne.Increase();
            return Ok();
        }

        //[HttpPost("increaseBy")]
        //public IActionResult IncreaseBy([FromQuery] int number)
        //{
        //    this.testingServiceOne.Increase(number);
        //    return Ok();
        //}

        [HttpGet("transient")]
        public IActionResult Transient()
        {
            return Ok(transient.Counter);
        }

        [HttpGet("singleton")]
        public IActionResult Singleton()
        {
            return Ok(singleton.Counter);
        }

        [HttpGet("scoped")]
        public IActionResult Scoped()
        {
            return Ok(scoped.Counter);
        }

        [HttpGet("transientX2")]
        public IActionResult Transient2()
        {
            testingServiceOne.Increase();
            testingServiceTwo.Increase();
            return Ok(transient.Counter);
        }

        [HttpGet("singletonX2")]
        public IActionResult Singleton2()
        {
            testingServiceOne.Increase();
            testingServiceTwo.Increase();
            return Ok(singleton.Counter);
        }

        [HttpGet("scopedX2")]
        public IActionResult Scoped2()
        {
            testingServiceOne.Increase();
            testingServiceTwo.Increase();
            return Ok(scoped.Counter);
        }
    }
}
