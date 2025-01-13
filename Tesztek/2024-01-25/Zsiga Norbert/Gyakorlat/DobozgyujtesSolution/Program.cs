using IOLibrary;

int numberOfClass = ExtendedConsole.ReadInteger(1, "Kérem az osztályok számát:  ");

Class[] classes =GetClasses() ;

Console.Clear();

ClassOrdering(classes);

Console.WriteLine("Osztály         0,25 dobozok száma\t0,33 dobozok száma\t0,5 dobozok száma\tPontok");
WriteClasses(classes);

int sumOfAllCans = classes.Sum(x => x.NumberOf025Can + x.NumberOf05Can + x.NumberOf033Can);
Console.WriteLine($"\nA részt vett osztályok összesen {sumOfAllCans} dobozt gyűjtöttek össze.");

double averagePoint = classes.Average(x => x.Points);
Console.WriteLine($"\nA részt vett osztályok pontjainak az átlaga: {averagePoint:F2}.");

int numberOfclassesAboveAverage = classes.Count(x => x.Points > averagePoint);
Console.WriteLine($"\nA pontok alapján {numberOfclassesAboveAverage} osztály teljesítette az átlag felett.");

string canTypes = GetTheTypeOfLargestAmountCans(classes);
Console.WriteLine($"\nA legtöbb a {canTypes} dobozból gyűlt össze.");

int differenceBetweenBestAndWorstClass = classes.Max(c => c.Points) - classes.Min(c => c.Points);
Console.WriteLine($"\nA legtöbb és a legkevesebb pontot gyűjtő osztály közt {differenceBetweenBestAndWorstClass} pontkülönbség van.");

bool anyClassWith100points = classes.Any(c => c.Points == 100);
Console.WriteLine($"\n{(anyClassWith100points? "Van" : "Nincs olyan osztály")}, amely pontosan 100 pontot ért el.");

Class[] GetClasses()
{
    Class[] classes = new Class[numberOfClass];
    int numberOf25 = 0;
    int numberOf33 = 0;
    int numberOf5 = 0;
    string name = "";

    for (int i = 0; i < numberOfClass; i++)
    {
        name = ExtendedConsole.ReadString("Kérem az osztály nevét: ");
        numberOf25 = ExtendedConsole.ReadInteger(0, "Kérem a 0.25-ös dobozok számát: ");
        numberOf33 = ExtendedConsole.ReadInteger(0, "Kérem a 0.33-as dobozok számát: ");
        numberOf5 = ExtendedConsole.ReadInteger(0, "Kérem a 0.5-ös dobozok számát: ");

        classes[i] = new Class(name,numberOf25,numberOf33,numberOf5);
    }

    return classes;
}

void ClassOrdering(Class[] classes)
{
    Class temp = new Class();
    for (int i = 0;i < numberOfClass;i++)
    {
        for (int j = i+1;j < numberOfClass;j++)
        {
            if (classes[j].Points > classes[i].Points)
            {
                temp = classes[i];
                classes[i] = classes[j];
                classes[j] = temp;
            }
        }
    }
}

void WriteClasses(Class[] classes)
{
    foreach (var item in classes)
    {
        Console.WriteLine(item);
    }
}

string GetTheTypeOfLargestAmountCans(Class[] classes)
{
    string result ="" ;
    int[] temp =
    [
        classes.Sum(c => c.NumberOf025Can),
        classes.Sum(c => c.NumberOf033Can),
        classes.Sum(c => c.NumberOf05Can),
    ];
    int maxValue = temp.Max();

    for (int i = 0; i < 3; i++)
    {
        if (temp[i] == maxValue)
        {
            string temp2 = i switch
            {
                0 => "kicsi(0.25)",
                1 => "közepes(0.33)",
                2 => "nagy(0.5)"
            };
            result += temp2 + ",";
        }
    }
    return result;
}