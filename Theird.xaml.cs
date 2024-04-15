using Praktika1_DataSet.praktika1_datasetDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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

    public partial class Theird : Page
    {
        CLIENTSTableAdapter CLIENTS = new CLIENTSTableAdapter();
        public Theird()
        {
            InitializeComponent();
            SushiDataGrid.ItemsSource = CLIENTS.GetData();
        }

        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            string FIRST_NAME = FirstN.Text;
            string MIDDLENAME = MidN.Text;
            string SURNAME = SurN.Text;


            CLIENTS.InsertQuery(FIRST_NAME, MIDDLENAME, SURNAME);
            SushiDataGrid.ItemsSource = CLIENTS.GetData();
        }

        private void Udalenie_Click(object sender, RoutedEventArgs e)
        {
            object ID_CLIENTS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            CLIENTS.DeleteQuery(Convert.ToInt32(ID_CLIENTS));
            SushiDataGrid.ItemsSource = CLIENTS.GetData();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            string FIRST_NAME = FirstN.Text;
            string MIDDLENAME = MidN.Text;
            string SURNAME = SurN.Text;

            object ID_SUSHIBARS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            CLIENTS.UpdateQuery(FIRST_NAME, MIDDLENAME, SURNAME, Convert.ToInt32(ID_SUSHIBARS));
            SushiDataGrid.ItemsSource = CLIENTS.GetData();
        }

        private void SushiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                DataRowView selectedRow = SushiDataGrid.SelectedItem as DataRowView;


                string fn = selectedRow.Row["FIRST_NAME"].ToString();
                string mn = selectedRow.Row["MIDDLENAME"].ToString();
                string sn = selectedRow.Row["SURNAME"].ToString();

                FirstN.Text = fn;
                MidN.Text = mn;
                SurN.Text = sn;
            }
        }
    }
}
