
    public class Eowyn : Champion, IWorrior
    {
    public Eowyn(string name) : base(name)
    {
        Race = RaceEnum.Human;
    }

    public void GetRage()
    {
        Power += rnd.Next(20, 50);
        HP += 150;
        Mana = Mana - Mana/4;
        Armor += 200;
    }
}

