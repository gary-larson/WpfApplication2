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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication2.DNDDataSet dNDDataSet = ((WpfApplication2.DNDDataSet)(this.FindResource("dNDDataSet")));
            // Load data into the table Spells. You can modify this code as needed.
            WpfApplication2.DNDDataSetTableAdapters.SpellsTableAdapter dNDDataSetSpellsTableAdapter = new WpfApplication2.DNDDataSetTableAdapters.SpellsTableAdapter();
            dNDDataSetSpellsTableAdapter.Fill(dNDDataSet.Spells);
            System.Windows.Data.CollectionViewSource spellsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("spellsViewSource")));
            spellsViewSource.View.MoveCurrentToFirst();
        }
    }
}
