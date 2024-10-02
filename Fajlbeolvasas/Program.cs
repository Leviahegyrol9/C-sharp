using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileBeolvasas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //az aktuális könyvtár lekérése
            string currentDirectory = Directory.GetCurrentDirectory();

            //az összes .txt fájl kilistázása az aktuália mappából
            string[] txtFiles = Directory.GetFiles(currentDirectory, "*.txt");

            if (txtFiles.Length == 0)
            {
                Console.WriteLine("Nincs .txt fájl az aktuális mappában");
            }

            // Fájlok kilistázása a konzolra
            Console.WriteLine("Válassz egy fájlt a következők közül: ");
            for (int i = 0; i < txtFiles.Length; i++)
            {
                Console.Write($"{i + 1}. {Path.GetFileName(txtFiles[i])} ");
            }

            // Felhasználói választás lekérese (ellenőrzés nélkül)
            Console.Write("Írd be a fájl számát: ");
            int fileIndex = int.Parse(Console.ReadLine());

            // Kiválasztott fájl neve és elérési útja
            string selectedFile = txtFiles[fileIndex - 1];

            // A kiválasztot fájl tartalmának beolvasása
            List<string> fileContent = new List<string>(File.ReadAllLines(selectedFile));

            // Fájl tartalmának megjelenítése soronként
            Console.WriteLine($"\nA(z) {Path.GetFileName(selectedFile)} tartalma:");
            foreach (string Line in fileContent)
            {
                Console.WriteLine(Line);
            }

            Console.ReadLine();
        }
    }
}
