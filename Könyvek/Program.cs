using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Könyvek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "konyvek.txt";
            List<Book> books = GetTheBooks(fileName);

            Console.WriteLine($"{books.Count} könyv szerepel a listában");

            Book maxHonorarium = books.Single(a=> a.Honorarium == books.Max(x => x.Honorarium));

            Console.WriteLine($"Legtöbb honoráriumon kapott író: {maxHonorarium.FirstName} {maxHonorarium.LastName}");

            Console.WriteLine($"{(books.Any(b => b.Theme == "informatika") ? "Van" : "Nincs")} informatikai témájú könyv");

            Console.WriteLine($"2010-es kiadású könyvek száma: {books.Where(x => x.Year == 2010).Count()}");

            List<Book> writtenBySG = books.Where(sg => sg.FirstName == "Stephen" && sg.LastName == "King").ToList();

            bool isSuccess = WriteToFile("king.txt", writtenBySG);

            Console.WriteLine($"{(isSuccess ? "Sikeres" : "Sikertelen")} fájlbaírás");

            Dictionary<string, int> producerAndCount = GetProducerAndCount(books);

            foreach (var item in producerAndCount)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} db");
            }

            Console.WriteLine($"{books.Count(x => x.PageNum < 220)}db ");


        }
        private static Dictionary<string, int> GetProducerAndCount(List<Book> books)
        {
            HashSet<string> producers = books.Select(x => x.Producer).ToHashSet();
            Dictionary<string, int> producerAndCount = new Dictionary<string, int>();

            foreach(string producer in producers)
            {
                producerAndCount[producer] = 0;
            }

            foreach(Book book in books)
            {
                producerAndCount[book.Producer]++;
            }

            return producerAndCount;
        }
        private static bool WriteToFile(string fileName, List<Book> books)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach(Book book in books)
                    {
                        sw.WriteLine(book.Title);
                    }             
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        private static List<Book> GetTheBooks(string fileName)
        {
            List<Book> books = new List<Book>();
            Book book = null;

            try
            {
                using(StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] datas = line.Split('\t');

                        book = new Book
                        {
                            LastName = datas[0],
                            FirstName = datas[1],
                            BirthDay = Convert.ToDateTime(datas[2]),
                            Title = datas[3],
                            ISBN = datas[4],
                            Producer = datas[5],
                            Year = int.Parse(datas[6]),
                            Price = int.Parse(datas[7]),
                            Theme = datas[8],
                            PageNum = int.Parse(datas[9]),
                            Honorarium = int.Parse(datas[10])
                        };

                        books.Add(book);
                    }                   
                }

                return books;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
