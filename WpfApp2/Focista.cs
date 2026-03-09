namespace WpfApp2
{
    public class Focista : Sportolo
    {


        public string poszt { get; set; }
        public double golszam { get; set; }

        public Focista(string nev, int kor, double hetiedzes, string poszt, double golszam) : base(nev, kor, hetiedzes)
        {
            this.poszt = poszt;
            this.golszam = golszam;
        }

        public override double Adatok()
        {
            return golszam / 40;
        }
        public override string ToString()
        {
            return nev + "átlagos golszam az idenyre: " + Adatok();
        }
    }

}