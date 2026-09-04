using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace IKT4
{
    public partial class RezsiViewModel:ObservableObject
    {
        [ObservableProperty]
        private double villany = 0;
        [ObservableProperty]
        private double viz = 0;
        [ObservableProperty]
        private double gaz = 0;
        [ObservableProperty]
        private double havi = 0;
        [ObservableProperty]
        private double eves = 0;

        [RelayCommand]
        private void Calculate()
        {
            Havi = Villany + Viz + Gaz;
            Eves = Havi * 12;
        }

        [RelayCommand]
        private void Clear()
        {
            Havi = 0;
            Eves = 0;
            Viz = 0;
            Gaz = 0;
            Villany = 0;
        }
    }
}
