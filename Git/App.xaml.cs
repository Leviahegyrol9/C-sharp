using System.Windows;
using Git.Service;
using Git.Windows;

namespace Git
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (SettingsService.HasValidConfig())
            {
                new Manage().Show();
            }
            else
            {
                new FileChoose().Show();
            }
        }
    }
}