
public class Arwen : Champion, IMage
{
    public Arwen(string name) : base(name )
    {
        Race = RaceEnum.Elf;
    }
    
    public void CastASpell()
    {
        Power += rnd.Next(10, 50);
        HP += 100;
        Mana -= 50;
        Armor += 150;
    }
    
}

