


using System.ComponentModel;

public static class DataService
    {
    public static async Task<List<int>> MakeStringToIntList(string input)
    {
        string[] temp = input.Split(",");
        List<int> result = new List<int>();

        foreach (string number in temp)
        {
          result.Add(int.Parse(number));
        }
        return result;
    }

    public static async Task WriteWorkersGrouped(List<WorkerNameAndHour> workers)
    {
        int counter = 0;
        Console.WriteLine("\nrossz:");
        foreach (WorkerNameAndHour worker in workers)
        {
           
            if (worker.SumOfWorkedHours >= 21)
            { break; }
            counter++;
            Console.WriteLine($"\t-\t{worker.Name}({worker.SumOfWorkedHours})");
            
        }
        Console.WriteLine("\nátlagos:");
        foreach (WorkerNameAndHour worker in workers.Skip(counter))
        {
            if (worker.SumOfWorkedHours >= 30)
            { break; }
            Console.WriteLine($"\t-\t{worker.Name}({worker.SumOfWorkedHours})");
            
                counter++;
            
        }
        Console.WriteLine("\nKiváló:");
        foreach (WorkerNameAndHour worker in workers.Skip(counter))
        {
            Console.WriteLine($"\t-\t{worker.Name}({worker.SumOfWorkedHours})");
            
        }
}
    public static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }
}

