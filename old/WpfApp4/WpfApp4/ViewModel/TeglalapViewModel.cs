using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using ViewModels.BaseClass;
using WpfApp4.Model;

namespace WpfApp4.ViewModel
{
    public class TeglalapViewModel:ViewModelBase
    {
        public Teglalap t;
        public RelayCommand CalculateCommand { get; set; }
        public RelayCommand CloseCommand { get;set; }


        public TeglalapViewModel()
        {
            t = new Teglalap();
            CalculateCommand = new RelayCommand(execute => Calculate());
            CloseCommand = new RelayCommand(execute => CloseWindow());
        }

        public double AOldal
        {
            get { return t.aoldal; }
            set { t.aoldal = value; }
        }
        public double BOldal
        {
            get { return t.boldal; }
            set { t.boldal = value; }
        }
        public double Terulet
        {
            get { return t.Terulet; }

        }
        public double Kerulet
        {
            get
            {
                return t.Kerulet;
            }
        }
        public double Atlo
        {
            get
            {
                return t.Atlo;
            }
        }
        public void Calculate()
        {
            OnPropertyChanged("Terulet");
            OnPropertyChanged("Kerulet");
            OnPropertyChanged("Atlo");
        }
        public void CloseWindow()
        {
            Application.Current.Shutdown();
        }
    }
}
