using System;

namespace Önálló.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Mileage { get; set; }
        public Car()
        {

        }
        public void IsExpired()
        {
            if (ExpiryDate < DateTime.Now) Console.WriteLine($"A(z) {Model} típusú autónak érvénytelen a műszakija!");

            else Console.WriteLine($"A(z) {Model} típusú autónak érvényes a műszakija!");
        }
    }
}