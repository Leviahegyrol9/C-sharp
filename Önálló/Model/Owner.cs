using System;

namespace Önálló.Model
{
    public class Owner:IAge
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Residence { get; set; }
        public string HighestEducation { get; set; }

        public Owner(int id, string ownerName, DateTime birthDate, string residence, string highestEducation)
        {
            Id = id;
            OwnerName = ownerName;
            BirthDate = birthDate;
            Residence = residence;
            HighestEducation = highestEducation;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }
    }
}
