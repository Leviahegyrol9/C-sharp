int i;
int osszeg = 0;
Console.WriteLine("Kérek 10 számot!");
for(i=1;i<=10;i++)
{
    int szam = Convert.ToInt32(Console.ReadLine());
    osszeg = osszeg + szam;
}
Console.WriteLine("A számok összeg:" + osszeg);