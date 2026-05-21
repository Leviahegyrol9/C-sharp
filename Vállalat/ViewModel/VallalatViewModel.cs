using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Vállalat.Model;
using ViewModels;
using ViewModels.BaseClass;

namespace Vállalat.ViewModel
{
    public class VallalatViewModel:ViewModelBase
    {
        public Vallalat v = new Vallalat();

        public RelayCommand CalculateCommand { get; set; }

        public VallalatViewModel()
        {
            CalculateCommand = new RelayCommand(execute => Calculate());
        }

        public void Calculate()
        {
            OnPropertyChanged("OBevetel");
            OnPropertyChanged("OKoltseg");
            OnPropertyChanged("AElotti");
            OnPropertyChanged("Ado");
            OnPropertyChanged("AEredmeny");
        }

        public double Bevetel
        {
            get { return v.bevetel; }
            set { v.bevetel = value; }
        }
        public double Egyeb
        {
            get { return v.egyeb; }
            set { v.egyeb = value; }
        }
        public double Bere
        {
            get { return v.bere; }
            set { v.bere = value; }
        }
        public double Koltsegek
        {
            get { return v.koltsegek; }
            set { v.koltsegek = value; }
        }
        public double OBevetel
        {
            get
            {             
                return v.OBevetel;
            }
        }
        public double OKoltseg
        {
            get
            {
                return v.OKoltseg;
            }
        }
        public double AElotti
        {
            get
            {
                return v.AElotti;
            }
        }
        public double Ado
        {
            get
            {
                return v.Ado;
            }
        }
        public double AEredmeny
        {
            get
            {
                return v.AEredmeny;
            }
        }
    }
}
