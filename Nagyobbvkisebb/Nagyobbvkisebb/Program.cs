// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kérem az első számot!");
int szam1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem a második számot!");
int szam2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem a harmadik számot!");
int szam3 = Convert.ToInt32(Console.ReadLine());
if ((szam1 > szam2) && (szam1 > szam3))
{
    Console.WriteLine("A legnagyobb szám: {0}", szam1);
} else if ((szam2>szam1) && (szam2>szam3))
{
    Console.WriteLine("A legnagyobb szám: {0}", szam2);
}
else
{
    Console.WriteLine("A legnagyobb szám: {0}", szam3);
}