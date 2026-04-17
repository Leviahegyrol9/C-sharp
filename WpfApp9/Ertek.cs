using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    public class Ertek:INotifyPropertyChanged
    {
        public int befektetett;
        public int kamatlab;
        public int ido;
        public double osszeg;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public int Befektetett
        {
            get { return befektetett; }
            set {befektetett = value; OnPropertyChanged("Osszeg"); }
        }
        public int Kamatlab
        {
            get { return kamatlab; }
            set {kamatlab = value; OnPropertyChanged("Osszeg"); }
        }
        public int Ido
        {
            get { return ido; }
            set {ido = value; OnPropertyChanged("Osszeg"); }
        }
        public double Osszeg
        {
            get
            {
                double sum = 1 + (kamatlab / 100);

                return Math.Pow(sum, ido) * befektetett;
            }
        }
    }
}
