namespace Model
{
    public class Diak
    {
        public string Name { get; set; }
        public double Average { get; set; }

        public Diak()
        {
        }

        public Diak(string name, double average)
        {
            Name = name;
            Average = average;
        }

        public override string ToString()
        {
            return $"{Name}: {Average}";
        }
    }
}
