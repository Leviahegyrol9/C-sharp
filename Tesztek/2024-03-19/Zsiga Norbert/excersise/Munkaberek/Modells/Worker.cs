
using System.Text;

public class Worker
    {
    public string Name { get; set; }
    public string Project { get; set; }

    public List<int> WorkedHours { get; set; }

    public int SumOfWorkedHours => WorkedHours.Sum(h => h);

    public int Payment => SumOfWorkedHours * 10000;

    public Worker() { }

    public Worker(string name, string project, List<int> workedHours)
    {
        Name = name;
        Project = project;
        WorkedHours = workedHours;
    }

    public override string ToString()
    {
       StringBuilder sb = new StringBuilder();
        sb.Append($"{Name.PadRight(9)}\t");
        sb.Append($"{Project.PadRight(9)}");
        foreach (int hour in WorkedHours)
        {
            sb.Append($"\t{hour}");
        }
        return sb.ToString();
    }

}

