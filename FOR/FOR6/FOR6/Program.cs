Random vsz = new Random();
int db = 0;
int szam;
for (int i = 1; i <= 5; i++)
    {
    szam = vsz.Next(1, 100);
    Console.WriteLine(szam);
    if (szam % 2 != 0)
    //if(szam%2==1)
    {
        db++;
    }
}
Console.WriteLine("A páratlan értékek darabszáma:{0}", db);