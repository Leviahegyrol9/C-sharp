using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Vérnyomás.Model;
using ViewModels.BaseClass;

namespace Vérnyomás.ViewModel
{
    public class NyomasViewModel:ViewModelBase
    {
        public Nyomas n;
        public RelayCommand CalculateCommand { get; set; }

        public NyomasViewModel()
        {
            n = new Nyomas();
            CalculateCommand = new RelayCommand(execute => Calculate());           
        }

        public void Calculate()
        {
            OnPropertyChanged("Pulzus");
            OnPropertyChanged("Vernyomas");
        }

        public double Kor
        {
            get { return n.kor; }
            set { n.kor = value; }
        }
        public double Suly
        {
            get { return n.suly; }
            set { n.suly = value; }
        }
        public double Szint
        {
            get { return n.szint; }
            set { n.szint = value; }
        }
        public double Pulzus
        {
            get
            {
                return n.Pulzus;
            }
        }
        public string Vernyomas
        {
            get
            {
                return n.Vernyomas;
            }
        }     
    }
}
