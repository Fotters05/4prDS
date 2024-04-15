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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Praktika1_DataSet
{
    public partial class Fourth : Page
    {
        private int bars;
        private int sets;
        private int client;


        INFOBARSTableAdapter INFOBARS = new INFOBARSTableAdapter();
        SUSHIBARSTableAdapter SUSHIBARS = new SUSHIBARSTableAdapter();
        SUSHISETSTableAdapter SUSHISETS = new SUSHISETSTableAdapter();
        CLIENTSTableAdapter CLIENTS = new CLIENTSTableAdapter();

        public Fourth()
        {

            InitializeComponent();
            SushiDataGrid.ItemsSource = INFOBARS.GetData();
            SUSHIBARSComboBox.DisplayMemberPath = "ID_SUSHIBARS";
            SUSHIBARSComboBox.ItemsSource = SUSHIBARS.GetData();
            SUSHISETSComboBox.DisplayMemberPath = "ID_SUSHISETS";
            SUSHISETSComboBox.ItemsSource = SUSHISETS.GetData();
            CLIENTSSComboBox.DisplayMemberPath = "ID_CLIENTS";
            CLIENTSSComboBox.ItemsSource = CLIENTS.GetData();

        }

        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            if (SUSHIBARSComboBox.SelectedItem != null &&
               SUSHISETSComboBox.SelectedItem != null &&
               CLIENTSSComboBox.SelectedItem != null)
            {
                DataRowView namebars = SUSHIBARSComboBox.SelectedItem as DataRowView;
                int SUSHIBARS_ID = Convert.ToInt32(namebars["ID_SUSHIBARS"]);

                DataRowView selectedSet = SUSHISETSComboBox.SelectedItem as DataRowView;
                int SUSHISETS_ID = Convert.ToInt32(selectedSet["ID_SUSHISETS"]);

                DataRowView cl = CLIENTSSComboBox.SelectedItem as DataRowView;
                int CLIENTS_ID = Convert.ToInt32(cl["ID_CLIENTS"]);

                INFOBARS.InsertQuery(SUSHIBARS_ID, SUSHISETS_ID, CLIENTS_ID);
                SushiDataGrid.ItemsSource = INFOBARS.GetData();
            }
        }


        private void Udalenie_Click(object sender, RoutedEventArgs e)
        {
            object ID_INFOBARS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            INFOBARS.DeleteQuery(Convert.ToInt32(ID_INFOBARS));
            SushiDataGrid.ItemsSource = INFOBARS.GetData();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = SushiDataGrid.SelectedItem as DataRowView;
            DataRowView selectedBar = SUSHIBARSComboBox.SelectedItem as DataRowView;
            DataRowView selectedSet = SUSHISETSComboBox.SelectedItem as DataRowView;
            DataRowView selectedClient = CLIENTSSComboBox.SelectedItem as DataRowView;


            if (selectedBar != null && selectedSet != null && selectedClient != null)
            {
                bars = Convert.ToInt32(selectedBar["ID_SUSHIBARS"]);
                sets = Convert.ToInt32(selectedSet["ID_SUSHISETS"]);
                client = Convert.ToInt32(selectedClient["ID_CLIENTS"]);

                selectedRow["SUSHIBARS_ID"] = bars;
                selectedRow["SUSHISETS_ID"] = sets;
                selectedRow["CLIENTS_ID"] = client;

                INFOBARS.UpdateQuery(bars, sets, client, Convert.ToInt32(selectedRow["ID_INFOBARS"]));

                SushiDataGrid.Items.Refresh();
            }
        }

        private void SUSHIBARSComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object Fircell = (SUSHIBARSComboBox.SelectedItem as DataRowView).Row[1];
            
        }
        private void SUSHISETSComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object SECcell = (SUSHISETSComboBox.SelectedItem as DataRowView).Row[1];

        }
        private void CLIENTSSComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object TREcell = (CLIENTSSComboBox.SelectedItem as DataRowView).Row[3];

        }
        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void SushiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (SushiDataGrid.SelectedItem != null)
                {
                    DataRowView selectedRow = SushiDataGrid.SelectedItem as DataRowView;

                    int carId = Convert.ToInt32(selectedRow["SUSHIBARS_ID"]);
                    int whereId = Convert.ToInt32(selectedRow["SUSHISETS_ID"]);
                    int supplierId = Convert.ToInt32(selectedRow["CLIENTS_ID"]);


                    foreach (DataRowView item in SUSHIBARSComboBox.Items)
                    {
                        if (Convert.ToInt32(item["ID_SUSHIBARS"]) == carId)
                        {
                            SUSHIBARSComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    foreach (DataRowView item in SUSHISETSComboBox.Items)
                    {
                        if (Convert.ToInt32(item["ID_SUSHISETS"]) == whereId)
                        {
                            SUSHISETSComboBox.SelectedItem = item;
                            break;
                        }
                    }

                    foreach (DataRowView item in CLIENTSSComboBox.Items)
                    {
                        if (Convert.ToInt32(item["ID_CLIENTS"]) == supplierId)
                        {
                            CLIENTSSComboBox.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }

    }
}
