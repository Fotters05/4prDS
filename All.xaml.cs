using Praktika1_DataSet.praktika1_datasetDataSetTableAdapters;
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

namespace Praktika1_DataSet
{

    public partial class All : Page
    {
        SUSHIBARSTableAdapter inf = new SUSHIBARSTableAdapter();
        public All()
        {
            InitializeComponent();
            SDataGrid.ItemsSource = inf.GetFullInfo();
        }

        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void Window_Loaded (object sender, RoutedEventArgs e)
        {
            SDataGrid.Columns[8].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[9].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[10].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[11].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[12].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[13].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[14].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[15].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[16].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[17].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[18].Visibility = Visibility.Collapsed;
            SDataGrid.Columns[19].Visibility = Visibility.Collapsed;

        }


    }
}
