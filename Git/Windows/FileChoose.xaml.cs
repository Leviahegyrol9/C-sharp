using Git.Service;
using Git.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Git
{
    public partial class FileChoose : Window
    {
        public FileChoose()
        {
            InitializeComponent();
        }

        private void SelectFile(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog
                {
                    Title = "Válaszd ki az elérési útvonalakat tartalmazó szöveges file-t!",
                    Filter = "Text File|*.txt",
                    RestoreDirectory = true
                };

                if (dlg.ShowDialog() == true)
                {

                    PathService.SavePath(dlg.FileName);

                    new Manage().Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void FileChoose_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            Application.Current.Shutdown();           
        }
    }
}
