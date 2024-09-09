// See https://aka.ms/new-console-template for more information
Console.WriteLine("Írja be a testsúly értékét kg-ban!");
int testsuly = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Írja be a magasság értékét m-ben");
int magassag = Convert.ToInt32(Console.ReadLine());
double index = testsuly / (Math.Pow(magassag, 2));

if (index < 20)
{
    Console.WriteLine("Sovány!");
}
else if ((20 < index) && (index > 25))
{
    Console.WriteLine("Normál súly!");
}
else
{
    Console.WriteLine("Túlsúly!");
}
