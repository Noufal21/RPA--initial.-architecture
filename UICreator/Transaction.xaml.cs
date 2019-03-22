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
    /// Interaction logic for Transaction.xaml
    /// </summary>
    public partial class Transaction : Page
    {
        List<Attributes> attributes = new List<Attributes>();
        public Transaction()
        {
            InitializeComponent();
            attributes.Add(new Attributes("Attribute 1", ""));
            attributes.Add(new Attributes("Attribute 2", ""));
            attributes.Add(new Attributes("Attribute 3", ""));
            attributes.Add(new Attributes("Attribute 4", ""));
            attributes.Add(new Attributes("Attribute 5", ""));
            attributes.Add(new Attributes("Attribute 6", ""));
            attributes.Add(new Attributes("Attribute 7", ""));
            attributes.Add(new Attributes("Attribute 8", ""));
            attributes.Add(new Attributes("Attribute 9", ""));
            attributes.Add(new Attributes("Attribute 10", ""));
            AttributeGridControl.ItemsSource = attributes;
        }
    }
}
