using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Adatok : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int beszerzesi = 10;
        public int eladasi = 100;
        public int profit;

        public int Beszerzesi
        {
            get
            {
                return beszerzesi;
            }
            set
            {
                beszerzesi = value;
                OnPropertyChanged("Profit");
            }
        }

        public void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public int Eladasi
        {
            get
            {
                return eladasi;
            }
            set
            {
                eladasi = value;
            }
        }

        public int Profit
        {
            get
            {
                return eladasi - beszerzesi;
            }
        }
    }
}
