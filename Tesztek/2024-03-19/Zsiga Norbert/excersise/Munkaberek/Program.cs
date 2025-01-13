List<Worker> workers = await FileService.FileReadAsync("munkaber.txt");
Console.WriteLine("\t\t\t\thétfő\tkedd\tszerda\tcsütörtök\tpéntek");
workers.WriteCollectionToConsole();

int sumOfPayment = workers.Sum(w => w.Payment);
Console.WriteLine($"\nÖsszesen {sumOfPayment} FT-t kell fizetni");

Worker bestWorker = workers.MaxBy(x => x.SumOfWorkedHours);
WorkerNameAndHour bestWorkerNameAndHour = new WorkerNameAndHour {Name = bestWorker.Name, SumOfWorkedHours = bestWorker.SumOfWorkedHours };
Console.WriteLine($"\n{bestWorkerNameAndHour}");

List<WorkerNameAndPayment> workersAndPayments = workers.Select(x => new WorkerNameAndPayment
{
    Name = x.Name,
    Payment = x.Payment
}).ToList();
await FileService.WriteToFlieAsync(workersAndPayments, "fizetes_2024-03");

List<WorkerNameAndHour> workersNamesAndHours = workers.Select(x => new WorkerNameAndHour { Name = x.Name, SumOfWorkedHours = x.SumOfWorkedHours })
                                            .OrderBy(x => x.SumOfWorkedHours).ToList();
await DataService.WriteWorkersGrouped(workersNamesAndHours);

List<Team> teams = workers.GroupBy(x => x.Project)
                    .Select(x => new Team
                    {
                        TeamName = x.Key,
                        AmountOFMoney = x.Sum(x => x.Payment)
                    }).ToList();
string mostExpensiveTeam = teams.MaxBy(x => x.AmountOFMoney).TeamName;
DateTime dateTime =  DateTime.Today;
int WeekNumberOfMonth = DataService.GetWeekNumberOfMonth(dateTime);
Console.WriteLine($"\n2024-03/{WeekNumberOfMonth} heti kifizetéskor a {mostExpensiveTeam} csapatára kelet a legtöbb forrást biztosítani.");
