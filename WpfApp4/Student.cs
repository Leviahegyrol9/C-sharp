using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class Student: INotifyPropertyChanged
    {
        public double alap;
        public double afa;
        public double ertek;

        public double Alap
        {
            get
            {
                return alap;
            }
            set
            {
                alap = value;
                OnPropertyChanged("Ertek");
            }
        }

        public double Afa
        {
            get
            {
                return afa;
            }
            set
            {
                afa = value;
                OnPropertyChanged("Ertek");
            }
        }

        public double Ertek
        {
            get
            {
                ertek = alap + (alap * (afa / 100));
                return ertek;
            }
        }

        public void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
