
    public abstract class Champion
    {
    protected static Random rnd = new Random();
    public string Name { get; set; }

    public RaceEnum Race { get; set; }

    public int HP { get; protected set; } = rnd.Next(500, 800);
    public int Mana { get; protected set; } = rnd.Next(400, 750);
    public int Power { get; protected set; } = rnd.Next(1000, 2000);
    public int Armor { get; protected set; } = rnd.Next(400, 900);


    public bool Attack(Champion enemy)
    {
        SpecialAbility();
        enemy.SpecialAbility();

        if (this is IMage)
        {
            (this as IMage).CastASpell();
        }
        else
        {
            (this as IWorrior).GetRage();
        }

        if (enemy is IMage mageEnemy)
        {
            mageEnemy.CastASpell();

            if (this.Power > (mageEnemy as Champion).Armor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            (enemy as IWorrior).GetRage();

            {
                if (this.Power > (enemy as Champion).Armor)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public void SpecialAbility()
    {
        if (Race == RaceEnum.Human)
        {
            HP += 10;
        }
        else if (Race == RaceEnum.Elf)
        {
            Mana += 20;
        }
        else if (Race == RaceEnum.Dwarf)
        {
            Armor += 20;
        }
        else if (Race == RaceEnum.Orc)
        {
            Power += 10;
        }
        else
        {
            Power += 20;
        }
    }

    protected Champion()
    {
        
    }

    protected Champion(string name)
    {
        Name = name;
    }
}

