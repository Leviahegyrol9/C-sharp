using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vállalat.Model
{
    public class Vallalat
    {
        public double bevetel;
        public double egyeb;
        public double bere;
        public double koltsegek;
        public double oBevetel;
        public double oKoltseg;
        public double aElotti;
        public double ado;
        public double aEredmeny;

        public double Bevetel
        {
            get {  return bevetel; }
            set { bevetel = value; }
        }
        public double Egyeb
        {
            get { return egyeb; }
            set { egyeb = value; }
        }
        public double Bere
        {
            get { return bere; }
            set { bere = value; }
        }
        public double Koltsegek
        {
            get { return koltsegek; }
            set { koltsegek = value; }
        }
        public double OBevetel
        {
            get 
            {
                oBevetel = bevetel + egyeb;
                return oBevetel;
            }
        }
        public double OKoltseg
        {
            get
            {
                oKoltseg = bere + koltsegek;
                return oKoltseg;
            }
        }
        public double AElotti
        {
            get
            {
                return oBevetel - oKoltseg;
            }
        }
        public double Ado
        {
            get
            {
                ado = AElotti * 0.3;
                return ado;
            }
        }
        public double AEredmeny
        {
            get
            {
                aEredmeny = AElotti - ado;
                return aEredmeny;
            }
        }
    }
}
