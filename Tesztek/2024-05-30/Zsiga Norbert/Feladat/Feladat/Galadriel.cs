
    public class Galadriel :Champion, IMage
    {
    public Galadriel(string name) : base(name)
    {
        Race = RaceEnum.Elf;
    }

    public void CastASpell()
    {
        Power += rnd.Next(20, 60);
        HP += 200;
        Mana -= 70;
        Armor += 100;
    }

}

