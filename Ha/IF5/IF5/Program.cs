// See https://aka.ms/new-console-template for more information
double szam1;
double szam2;
double szam3;

Console.WriteLine("Kérem az első számot:");
szam1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kérem a második számot:");
szam2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kérem a harmadik számot:");
szam3 = Convert.ToDouble(Console.ReadLine());
if((szam1<szam2) && (szam2<szam3))
    {
    Console.WriteLine("A harmadik szám a legnagyobb");
}
if ((szam2>szam3) && (szam3 < szam2))
{
    Console.WriteLine("A második szám a legnagyobb");
}
if ((szam2 < szam1) && (szam1>szam3))
{

}