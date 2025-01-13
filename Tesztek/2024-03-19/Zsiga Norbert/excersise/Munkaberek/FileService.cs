using System.Text;

public static class FileService
    {
    public static async Task<List<Worker>> FileReadAsync(string fileName)
    { 
        List<Worker> workers = new List<Worker>();
        Worker worker = null;
        string path = Path.Combine("Source", fileName);
        string temp = null;

        using FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 128);
        using StreamReader sr = new StreamReader(fs,Encoding.UTF8);

        while (!sr.EndOfStream)
        { 
            worker = new Worker();
            worker.Name = await sr.ReadLineAsync();
            worker.Project = await sr.ReadLineAsync();
            temp = await sr.ReadLineAsync();

            worker.WorkedHours =await  DataService.MakeStringToIntList(temp);

            workers.Add(worker);
            await sr.ReadLineAsync();
        }
        return workers;
    }

    public static async Task WriteToFlieAsync(List<WorkerNameAndPayment> workers, string filename)
    {
        Directory.CreateDirectory("output");
        string path = Path.Combine("output", $"{filename}.txt");

        using FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None, 128);
        using StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

        foreach (var worker in workers)
        {
           await sw.WriteLineAsync($"{worker}");
        }
    }
    }

