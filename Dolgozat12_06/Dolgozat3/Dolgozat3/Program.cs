// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kérem a dobás értékét (1-6)");
double dobas = Convert.ToDouble(Console.ReadLine());
if ((dobas >= 3)&&(dobas <= 5))
{
    Console.WriteLine("Ön nyert egy TV-t!");
}
else if (dobas == 6)
{
    Console.WriteLine("Ön nyert egy utazást!");
}
else
{
    Console.WriteLine("Ön egy  5000 forint értékű vásárlási utalványt nyert!");
}