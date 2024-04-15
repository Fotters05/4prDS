using Praktika1_DataSet.praktika1_datasetDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Praktika1_DataSet
{

    public partial class Second : Page
    {
        SUSHISETSTableAdapter SUSHISETS = new SUSHISETSTableAdapter();
        public Second()
        {
            {
                InitializeComponent();
                SushiDataGrid.ItemsSource = SUSHISETS.GetData();
                SetsCbx.DisplayMemberPath = "TITLESETS";
                SetsCbx.ItemsSource = SUSHISETS.GetData();
            }
        }


        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            string TITLESETS = NameTbx.Text;
            int PRICESETS = int.Parse(Prc.Text);
            int QUANTITY = int.Parse(Quant.Text);

            SUSHISETS.InsertQuery(TITLESETS, PRICESETS, QUANTITY);
            SushiDataGrid.ItemsSource = SUSHISETS.GetData();
        }

        private void Udalenie_Click(object sender, RoutedEventArgs e)
        {
            object ID_SUSHISETS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            SUSHISETS.DeleteQuery(Convert.ToInt32(ID_SUSHISETS));
            SushiDataGrid.ItemsSource = SUSHISETS.GetData();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            string TITLESETS = NameTbx.Text;
            int PRICESETS = int.Parse(Prc.Text);
            int QUANTITY = int.Parse(Quant.Text);

            object ID_SUSHISETS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            SUSHISETS.UpdateQuery(TITLESETS, PRICESETS, QUANTITY, Convert.ToInt32(ID_SUSHISETS));
            SushiDataGrid.ItemsSource = SUSHISETS.GetData();
        }



        private void SushiDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                DataRowView selectedRow = SushiDataGrid.SelectedItem as DataRowView;


                string titlesets = selectedRow.Row["TITLESETS"].ToString();
                int price = Convert.ToInt32(selectedRow["PRICESETS"]);
                string integerAsString = price.ToString();
                int q = Convert.ToInt32(selectedRow["QUANTITY"]);
                string integerAsString1 = q.ToString();

                NameTbx.Text = titlesets;
                Prc.Text = integerAsString;
                Quant.Text = integerAsString1;
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            SushiDataGrid.ItemsSource = SUSHISETS.SearchByName(Search_Click.Text);
        }

        private void SetsCbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SetsCbx.SelectedItem != null)
            {
                var TITLESETS = (string)(SetsCbx.SelectedItem as DataRowView).Row[1];
                SushiDataGrid.ItemsSource = SUSHISETS.Filters(TITLESETS);

            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SushiDataGrid.ItemsSource = SUSHISETS.GetData();
            Search_Click.Text = "";
            SetsCbx.SelectedItem = null;
        }
    }
}
 