using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IKT3
{
    public class Fuel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double distance;
        public double consumption;
        public double price;
        public double cost;
        public string type;

        public double Distance
        {
            get {  return distance; }
            set { distance = value; OnPropertyChanged("Cost", "Type"); ShowIssue(distance); }
        }
        public double Consumption
        {
            get {  return consumption; }
            set { consumption = value; OnPropertyChanged("Cost", "Type"); ShowIssue(consumption); }
        }
        public double Price
        {
            get {  return price; }
            set { price = value; OnPropertyChanged("Cost", "Type"); ShowIssue(price); }
        }
        public double Cost
        {
            get
            {
                double neededFuel = (distance / 100) * consumption;
                return neededFuel * price;
            }
        }
        public string Type
        {
            get
            {
                if (Cost < 5000) return "Olcsó utazás";
                else if (Cost < 15000) return "Átlagos utazás";
                else return "Drága utazás";
            }
        }

        private void OnPropertyChanged(string propertyName, string propertyName2)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName2));
            }
        }

        private void ShowIssue(double field)
        {
            if (!double.TryParse(field.ToString(), out _)) MessageBox.Show("Nem számot adott meg!");
        }
    }
}
