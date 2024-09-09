// See https://aka.ms/new-console-template for more information
Random vsz = new Random();
int szam = vsz.Next(-100, 100);
if ((szam >= -30) && (szam < 40))
        {
    Console.WriteLine("A szám beleesik az intervallumba");
}
else
{
    Console.WriteLine("A szám nem esik bele az intervallumba");
}