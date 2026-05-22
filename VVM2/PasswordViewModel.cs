using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace VVM3
{
    public partial class PasswordViewModel : ObservableObject
    {
        [ObservableProperty]
        private string pwd;
        [ObservableProperty]
        private string passwordLength = "Hossz: ";
        [ObservableProperty]
        private string containsNumber = "Van szám?";
        [ObservableProperty]
        private string containsUppercase = "Van nagybetű?";
        [ObservableProperty]
        private string passwordStrength = "Erősség: ";

        [RelayCommand]
        public void Analyze()
        {
            PasswordLength = $"Hossz: {Pwd.Length}";
            ContainsNumber = $"Van szám? {(Pwd.Any(char.IsDigit) ? "Igen" : "Nem")}";
            ContainsUppercase = $"Van nagybetű? {(Pwd.Any(char.IsUpper) ? "Igen" : "Nem")}";

            if (Pwd.Length < 6)
            {
                PasswordStrength = "Erősség: gyenge";
            }
            else if (Pwd.Length < 10)
            {
                PasswordStrength = "Erősség: közepes";
            }
            else PasswordStrength = "Erősség: erős";
        }

        [RelayCommand]
        public void Clear()
        {
            Pwd = string.Empty;
            PasswordLength = "Hossz: ";
            ContainsNumber = "Van szám?";
            ContainsUppercase = "Van nagybetű?";
            PasswordStrength = "Erősség: ";
        }
    }
}
