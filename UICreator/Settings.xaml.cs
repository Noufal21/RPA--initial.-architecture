using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using UICreator.Classes;

namespace UICreator
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page
    {
        List<Setting> settings = new List<Setting>();
        public Settings()
        {
            InitializeComponent();
            settings.Add(new Setting("Server URL", ""));
            settings.Add(new Setting("User Name", ""));
            settings.Add(new Setting("Password", ""));
            settings.Add(new Setting("Bot Name", ""));
            settings.Add(new Setting("History Path", ""));
            SettingGridControl.ItemsSource = settings;
        }
    }
}
