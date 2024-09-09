// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kérem a háromszög első oldalának hosszát!");
double oldal1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kérem a háromszög második oldalának hosszát!");
double oldal2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kérem a háromszög harmadik oldalának hosszát!");
double oldal3 = Convert.ToDouble(Console.ReadLine());
if ((oldal1 + oldal2 > oldal3) && (oldal1 + oldal3 > oldal2) && (oldal2 + oldal3 > oldal1))
{
    Console.WriteLine("Szerkeszthető a háromszög");
}
else
{
    Console.WriteLine("Nem szerkeszthető a háromszög");
}