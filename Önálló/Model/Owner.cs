using System;

namespace Önálló.Model
{
    public class Owner
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Residence { get; set; }
        public string HighestEducation { get; set; }
        public Owner()
        {

        }
    }
}
