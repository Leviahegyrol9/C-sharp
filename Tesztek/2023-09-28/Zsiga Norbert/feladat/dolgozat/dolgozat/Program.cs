using System.Transactions;

Console.Write("A vevő bemegy az autókereskedésbe és bemutatkozik: ");
string customer = Console.ReadLine();

Console.WriteLine($"Jó napot kedves {customer}. Miben segíthetek?");

Console.Write("Engem érdekelne egy: ");
string carType = Console.ReadLine();

Console.WriteLine($"Értem, egy {carType}. Hány köbcentis motorra gondolt?");
int engineSize = int.Parse( Console.ReadLine() );

Console.Write("A vásárolni kívánt gépjárű ára (millió Ft): ");
double carPrice = double.Parse( Console.ReadLine() );

Console.WriteLine($"Kedves {customer}, a megvásárolni kívánt gépjármű ára {carPrice} millió magyar forint. A vételárat hogyan kívánja rendezni: készpénz vagy hitel?");

double carPricePercent = double.Parse(Console.ReadLine());
Console.WriteLine($"{carPricePercent}%-ban fizetném készpénzben a többit hitelre szeretném");

double cash = carPrice * (carPricePercent / 100);
double loan = carPrice - cash;

Console.WriteLine($"Rendben, akkor {cash} millió Ft lesz a készpénz része és {loan} millió Ft + kamat lesz a hitel.");
Console.WriteLine("És mennyit tesz ki majd a kamat része?");
double interest;
if(loan >1 && loan <5)
{  
        interest = loan * 0.05;
}
else if (loan > 5 && loan < 10)
{
    interest = loan * 0.08;
}
else
{
    interest = loan * 0.13;
}

Console.WriteLine($"{interest} millió forint lesz.");

Console.WriteLine("Rendben\nMilyen színben rendelhető?");
Console.WriteLine("Kérem szépen van:\n1 – kék\n2 – piros\n3 – fekete\n4 – citromsárga\n5 – fehér");
Console.Write("Kérek egy számot a fenti listából: ");
char colorNumber = Console.ReadKey().KeyChar;

string color = colorNumber switch
{
    '1' => "kék",
    '2' => "piros",
    '3' => "fekete",
    '4' => "citromsárga",
    '5' => "fehér",
    _ => "Nincs ilyen szín",
};

Console.WriteLine($"\n{color} színűt szeretnék. A feleségemnek lesz.");
Console.WriteLine("Rendben, akkor összegezzük:");
Console.WriteLine($"Megrendelő: {customer}\nJármű: {carType}\nMotor nagysága: {engineSize}ccm\nSzín: {color}\nÖnerő: {cash} millió Huf\nHitel: {loan} millió Huf\nKamat: {interest} millió Huf");

Console.ReadKey();