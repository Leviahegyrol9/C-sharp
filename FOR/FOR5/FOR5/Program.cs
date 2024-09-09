int csere;
int kezdo;
int veg;
Console.WriteLine("Kérem az intervallum kezdőértékét!");
kezdo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem az intervallum végértékét!");
veg = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Öttel osztható számok:\n");
if(kezdo>veg)
{
    csere = kezdo;
    kezdo = veg;
    veg = csere;
}
for(int i=kezdo;i<=veg;i++)
{
    if(i%5==0)
    {
        Console.WriteLine(i);
    }
}