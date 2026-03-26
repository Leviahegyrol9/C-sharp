using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Listproduct {  get; set; }
        public Product Newproduct { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Listproduct=new List<Product>();
            Newproduct = new Product();
            this.DataContext = this;
        }

        private void hozzaad_Click(object sender, RoutedEventArgs e)
        {
            Listproduct.Add(new Product(Newproduct.Name,Newproduct.Price));
            Newproduct=new Product();
            this.DataContext = null;
            this.DataContext = this;
        }
    }
}