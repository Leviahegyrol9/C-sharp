using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public class Hitel : INotifyPropertyChanged
    {
        public int torleszto = 1000;
        public int kamatlab = 10;
        public int evek = 2;
        public double hitel;

        public int Torleszto
        {
            get { return torleszto; }
            set { torleszto = value; OnPropertyChanged("Hitelosszeg"); }
        }
        public int Kamatlab
        {
            get { return kamatlab; }
            set { kamatlab = value; OnPropertyChanged("Hitelosszeg"); }
        }
        public int Evek
        {
            get { return evek; }
            set { evek = value; OnPropertyChanged("Hitelosszeg"); }
        }
        public double Hitelosszeg
        {
            get
            {

                double r = Kamatlab / 100.0;
                double res = Torleszto * (1.0 - (1.0 / Math.Pow(1.0 + r, Evek))) / r;
                hitel = Math.Round(res);
                return hitel;
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}