public class WorkerNameAndHour
{
        public string Name { get; set; }

        public int SumOfWorkedHours { get; set; }

        public WorkerNameAndHour() { }

        public WorkerNameAndHour(string name, int workedHours)
        {
            Name = name;

        SumOfWorkedHours = workedHours;
        }

        public override string ToString()
        {
        return $"A héten a legtöbb munkaórát {Name} dolgozta ({SumOfWorkedHours}óra).";
 
        }

    }



