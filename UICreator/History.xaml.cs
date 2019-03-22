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
    /// Interaction logic for History.xaml
    /// </summary
    /// 

    public partial class History : Page
    {
        List<Taskclass> histories = new List<Taskclass>();
        public History()
        {
            InitializeComponent();
            histories.Add(new Taskclass("144738465", "ADD_Customer", "FlowName", DateTime.Now, "2:07", "SUCESS", "filepath", "LogPath"));
            histories.Add(new Taskclass("144738462", "ADD_Customer", "FlowName", DateTime.Now, "2:07", "SUCESS", "filepath", "LogPath"));
            histories.Add(new Taskclass("144738444", "ADD_Customer", "FlowName", DateTime.Now, "2:07", "SUCESS", "filepath", "LogPath"));
            HistoryGridControl.ItemsSource = histories;
        }
    }
}
