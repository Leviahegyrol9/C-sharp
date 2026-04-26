using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berek
{
    public class Ber:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public double brutto;
        public double levonasok;
        public double netto;
        public double osszeg;

        public double Brutto
        {
            get {  return brutto; }
            set { brutto = value; OnPropertyChanged("Netto", "Osszeg"); }
        }
        public double Levonasok
        {
            get {  return levonasok; }
            set { levonasok = value; OnPropertyChanged("Netto","Osszeg"); }
        }

        private void OnPropertyChanged(string v, string v2)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
                PropertyChanged(this, new PropertyChangedEventArgs(v2));
            }
        }

        public double Netto
        {
            get
            {
                return brutto - Osszeg;
            }
        }
        public double Osszeg
        {
            get
            {
                return brutto * (levonasok / 100);
            }
        }


    }
}
