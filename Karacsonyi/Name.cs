namespace Model
{
    public class Person
    {
        public string Name { get; set; }
        public string Present1 { get; set; }
        public string Present2 { get; set; }

        public Person()
        {
        }

        public Person(string name, string present1, string present2)
        {
            Name = name;
            Present1 = present1;
            Present2 = present2;
        }

        public override string ToString()
        {
            return $"{Name}: {Present1}, {Present2}";
        }
    }
}

