int parosdb = 0;
Console.WriteLine("Kérek 5 db számot!");
for (int i = 1; i <= 5; i++)
{
    int szam = Convert.ToInt32(Console.ReadLine());
    if (szam % 2 == 0)
    {

        parosdb++;
    }
}
Console.WriteLine("Párosok darabszáma: {0}", parosdb);