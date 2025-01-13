
    public class Lurtz : Champion, IWorrior
{
    public Lurtz(string name) : base(name)
    {
        Race = RaceEnum.Orc;
    }

    public void GetRage()
    {
        Power += rnd.Next(50, 80);
        HP += 50;
        Mana = Mana - Mana / 2;
        Armor += 100;
    }
}
