using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Athletes
{
    public class Runner : Athelete
    {
        public Runner(string firstName, string lastName, Gender gender, string country) : base(firstName, lastName, gender, country)
        {
        }

        public override void HighJump()
        {
            throw new NotImplementedException();
        }

        public override void LongJump()
        {
            throw new NotImplementedException();
        }

        public override void RunHurdles()
        {
            Console.WriteLine($"{AtheleteInformation} Running Hurdles");
        }

        public override void RunRelay()
        {
            Console.WriteLine($"{AtheleteInformation} Running Relay");
        }

        public override void RunSprints(SprintDistance distance)
        {
            Console.WriteLine($"{AtheleteInformation} Running the sprints for: {(int)distance}m");
        }

        public override void Swim(SwimDistance distance)
        {
            throw new NotImplementedException();
        }

        public override void TripleJump()
        {
            throw new NotImplementedException();
        }
    }
}
