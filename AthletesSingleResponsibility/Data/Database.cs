using AtheletesSingleResponsibility.Athletes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility.Data
{
    public static class Database
    {
        public static List<Athelete> Atheletes = new List<Athelete>
        {
            new HighJumper("High", "Jumper", Gender.Male, "ZA"),
            new HighJumper("Girl", "Jumper", Gender.Female, "US"),
            new LongJumper("Super", "Long", Gender.Male, "ZA"),
            new LongJumper("Mike", "Triple", Gender.Male, "US"),
            new Runner("Usain", "Bolt", Gender.Male, "JM"),
            new Runner("Caster", "Semenya", Gender.Female, "ZA"),
            new Swimmer("Fast", "Swimm", Gender.Female, "NZ"),
            new Swimmer("Michael", "Phelps", Gender.Male, "US"),
        };
    }
}
