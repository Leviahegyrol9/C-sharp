using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VVM
{
    public partial class TempViewModel:ObservableObject
    {
        [ObservableProperty]
        public string celsius;
        [ObservableProperty]
        public string fahrenheit = "Fahrenheit: ";
        [ObservableProperty]
        public string kelvin = "Kelvin: ";

        [RelayCommand]
        public void Converter()
        {
            double c = double.Parse(Celsius);
            double f = (c * 9 /5) + 32;
            double k = c + 273.15;

            Fahrenheit = $"Fahrenheit: {f:n2} F";
            Kelvin = $"Kelvin: {k:n2} K";
        }

        [RelayCommand]
        public void Clear()
        {
            Celsius = string.Empty;
            Fahrenheit = "Fahrenheit: ";
            Kelvin = "Kelvin: ";
        }
    }
}