using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp10
{
    public class Viz:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double elozo;
        public double aktualis;
        public double vizdij;
        public double koltseg;
        public double Elozo
        {
            get { return elozo; }
            set { elozo = value; OnPropertyChanged("Koltseg"); }
        }
        public double Aktualis
        {
            get { return aktualis; }
            set { aktualis = value; OnPropertyChanged("Koltseg"); }
        }
        public double Vizdij
        {
            get { return vizdij; }
            set { vizdij = value; OnPropertyChanged("Koltseg"); }
        }

        private void OnPropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }

        public double Koltseg
        {
            get
            {
                return (aktualis - elozo) * vizdij;
            }
        }
    }
}
