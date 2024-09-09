Random vsz = new Random();
int szam;
int pozdb = 0;
int negdb = 0;
for(int i=1;i<=10;i++)
{
    szam = vsz.Next(-100, 100);
    Console.WriteLine(szam);
    if(szam%2 == 0)
    {
        pozdb++;
    }
    else
    {
        negdb++;
    }
}
Console.WriteLine("Pozitív számok darabszáma:" + pozdb);
Console.WriteLine("Negatív számok darabszáma:" + negdb);