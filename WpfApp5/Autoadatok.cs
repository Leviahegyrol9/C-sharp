using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public class Autoadatok: INotifyPropertyChanged
    {
        public double tav = 1;
        public double uzemanyag = 1;
        public double fogyasztas;

        public double Tav
        {
            get
            {
                return tav;
            }
            set
            {
                tav = value;
                OnPropertychanged("Fogyasztas");
            }
        }

        public void OnPropertychanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public double Uzemanyag
        {
            get
            {
                return uzemanyag;
            }
            set
            {
                uzemanyag = value;
            }
        }

        public double Fogyasztas
        {
            get
            {
                fogyasztas = (uzemanyag / tav) * 100;
                return Math.Round(fogyasztas, 2 );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
