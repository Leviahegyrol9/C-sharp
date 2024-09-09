int nyeremény;
int szam1;
int szam2;
Console.WriteLine("Kérem az első dobás értééte!");
szam1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem a második dobás értékét!");
szam2 = Convert.ToInt32(Console.ReadLine());
if (szam1==szam2)
{
    nyeremény = (szam1 + szam2) * 1000;
}else if((szam1+szam2)%2==0)
{
    nyeremény = (szam1 + szam2) * 100;
}
else
{
    nyeremény = 0;
}
Console.WriteLine("A nyeremény: {0}", nyeremény);