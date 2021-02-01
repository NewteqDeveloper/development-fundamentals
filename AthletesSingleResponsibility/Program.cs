using AtheletesSingleResponsibility.Athletes;
using AtheletesSingleResponsibility.Data;
using System;

namespace AtheletesSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var athlete in Database.Atheletes)
            {
                if(athlete.GetType() == typeof(HighJumper))
                {
                    athlete.HighJump();
                    // this is intentional, and will break, because this high jumper does not know what to do with this type
                    athlete.LongJump();
                }

                if (athlete.GetType() == typeof(LongJumper))
                {
                    athlete.LongJump();
                    athlete.TripleJump();
                }

                if (athlete.GetType() == typeof(Runner))
                {
                    athlete.RunSprints(SprintDistance.OneHundred);
                    athlete.RunRelay();
                    athlete.RunHurdles();
                    // this is intentional, and will break, because this runner does not know what to do with this type
                    athlete.Swim(SwimDistance.OneHundred);
                }

                if (athlete.GetType() == typeof(Swimmer))
                {
                    athlete.Swim(SwimDistance.OneHundred);
                }
            }

            Console.ReadKey();
        }
    }
}
