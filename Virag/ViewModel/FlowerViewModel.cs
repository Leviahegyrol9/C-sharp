using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Virag.Model;

namespace Virag.ViewModel
{
    public class FlowerViewModel:ViewModelBase
    {
        public Flower f;
        public RelayCommand CalculateCommand {  get; set; }

        public FlowerViewModel()
        {
            f = new Flower();
            CalculateCommand = new RelayCommand(e => Calculate());
        }

        public int Tulipan
        {
            get { return f.tulipan; }
            set { f.tulipan = value; }
        }
        public int Rozsa
        {
            get { return f.rozsa; }
            set { f.rozsa = value; }
        }
        public int Narcisz
        {
            get { return f.narcisz; }
            set { f.narcisz = value; }
        }
        public int Fizetendo
        {
            get
            {
                return f.Fizetendo;
            }
        }

        public void Calculate()
        {
            OnPropertyChanged("Fizetendo");
        }
    }
}
