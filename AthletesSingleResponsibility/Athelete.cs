using System;
using System.Collections.Generic;
using System.Text;

namespace AtheletesSingleResponsibility
{
    public enum SprintDistance
    {
        OneHundred = 100,
        TwoHundred = 200,
        FourHundred = 400
    }

    public enum SwimDistance
    {
        Fifty = 50,
        OneHundred = 100,
        TwoHundred = 200
    }

    public enum Gender
    {
        Male,
        Female
    }
    
    public abstract class Athelete
    {
        public Athelete(string firstName, string lastName, Gender gender, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Country = country;
        }
        
        public string FirstName { get; }
        public string LastName { get; }
        public string Country { get; }
        public Gender Gender { get; }

        public string AtheleteInformation => $"{FirstName} {LastName} ({Gender}), from {Country} is now performing :: ";

        public abstract void RunSprints(SprintDistance distance);
        public abstract void Swim(SwimDistance distance);
        public abstract void LongJump();
        public abstract void HighJump();
        public abstract void RunHurdles();
        public abstract void RunRelay();
        public abstract void TripleJump();
    }
}
