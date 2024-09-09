// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kérem a háromszög első szögét!");
double szam1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kérem a háromszög második szögét!");
double szam2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Kérem a háromszög harmadik szögét!");
double szam3 = Convert.ToDouble(Console.ReadLine());
if ((szam1 < 180)&&(szam1>90))
{
    Console.WriteLine("Tompa szögű!");
}
else if ((szam2 < 180)&&(szam2 >90))
{
    Console.WriteLine("Tompa szögű");
}
else if ((szam3 < 180) && (szam3 > 90))
{
    Console.WriteLine("Tompa szögű");
}
else
{
    Console.WriteLine("A háromszög nem tompaszögű!");
}