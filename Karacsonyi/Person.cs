namespace Model
{
    public class Person
    {
        public string Name { get; set; }
        public string Present { get; set; }

        public Person()
        {
        }

        public Person(string name, string present1, string present2)
        {
            Name = name;
            Present = present1;
        }

        public override string ToString()
        {
            return $"{Name}: {Present}";
        }
    }
}

