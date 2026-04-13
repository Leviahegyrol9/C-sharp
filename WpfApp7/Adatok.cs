using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class Adatok : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime aktualis = DateTime.Today;
        public DateTime szuletesi = new DateTime(2007,7,17);
        public int kor;

        public int Aktualis
        {
            get
            {
                return aktualis;
            }
            set
            {
                aktualis = value;
                OnPropertyChanged("Kor");
            }
        }

        public void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public int Szuletesi
        {
            get
            {
                return szuletesi;
            }
            set
            {
                szuletesi = value;
            }
        }

        public int Kor
        {
            get
            {
                return aktualis.Year - szuletesi.Year;
            }
        }
    }
}
