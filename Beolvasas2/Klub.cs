using System;

namespace Beolvasas2
{
    public class Klub
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool HunNationality { get; set; }
        public bool AbrNationality { get; set; }
        public int Value { get; set; }
        public string Post { get; set; }

        public Klub()
        {

        }

        public Klub(string name, int number, string firstName, string lastName, DateTime birthDate, bool hunNationality, bool abrNationality, int value, string post)
        {
            Name = name;
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            HunNationality = hunNationality;
            AbrNationality = abrNationality;
            Value = value;
            Post = post;
        }

        public override string ToString()
        {
            return $"{Name}, {Number}, {FirstName}, {LastName}, {BirthDate.ToString("yyyy.MM.dd.")}, {HunNationality}, {AbrNationality}, {Value}, {Post}";
        }
    }
}
