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

namespace Gezonder
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

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource huisartsenViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("huisartsenViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // huisartsenViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource klantenViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("klantenViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // klantenViewSource.Source = [generic data source]
            Gezonder.ZorgDataSet1 zorgDataSet1 = ((Gezonder.ZorgDataSet1)(this.FindResource("zorgDataSet1")));
            // Load data into the table Klant. You can modify this code as needed.
            Gezonder.ZorgDataSet1TableAdapters.KlantTableAdapter zorgDataSet1KlantTableAdapter = new Gezonder.ZorgDataSet1TableAdapters.KlantTableAdapter();
            zorgDataSet1KlantTableAdapter.Fill(zorgDataSet1.Klant);
            System.Windows.Data.CollectionViewSource klantViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("klantViewSource")));
            klantViewSource.View.MoveCurrentToFirst();
            // Load data into the table Huisarts. You can modify this code as needed.
            Gezonder.ZorgDataSet1TableAdapters.HuisartsTableAdapter zorgDataSet1HuisartsTableAdapter = new Gezonder.ZorgDataSet1TableAdapters.HuisartsTableAdapter();
            zorgDataSet1HuisartsTableAdapter.Fill(zorgDataSet1.Huisarts);
            System.Windows.Data.CollectionViewSource huisartsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("huisartsViewSource")));
            huisartsViewSource.View.MoveCurrentToFirst();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
