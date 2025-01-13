
    public class Tauriel : Champion, IWorrior
    {
    public Tauriel(string name) : base(name)
    {
        Race = RaceEnum.Elf;
    }

    public void GetRage()
    {
        Power += rnd.Next(40, 70);
        HP += 80;
        Mana -= 10;
        Armor += 150;
    }
}

