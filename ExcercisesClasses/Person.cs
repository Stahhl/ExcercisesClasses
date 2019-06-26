using System;
using System.Collections.Generic;
using System.Text;

public enum Sport
{
    NULL,
    TENNIS,
    RUGBY,
    SOCCER,
    HURLING,
    SQUASH,
}
public enum Gender
{
    NULL,
    FEMALE,
    MALE,
    OTHER
}

namespace ExcercisesClasses
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public Gender Gender { get; set; }
        public Sport FavoriteSport { get; set; }
        public Sport LeastFavoriteSport { get; set; }

        public Person(string firstName, string lastName, string birthDay, Gender gender, Sport favoriteSport, Sport leastFavoriteSport)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            FavoriteSport = favoriteSport;
            LeastFavoriteSport = leastFavoriteSport;
        }

    }
}
