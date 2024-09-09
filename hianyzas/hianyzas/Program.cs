// See https://aka.ms/new-console-template for more information
int igazolatlan;
Console.WriteLine("Kérem az igazolatlan hiányzások számát!");
igazolatlan = Convert.ToInt32(Console.ReadLine());
if (igazolatlan<5)
{
    Console.WriteLine("Figyelmeztetés!");
}else if(igazolatlan<=15)
{
    Console.WriteLine("Igazgatói");
}
else
{
    Console.WriteLine("Felfüggesztés!");
}
