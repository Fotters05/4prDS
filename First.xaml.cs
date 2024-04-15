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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Praktika1_DataSet.praktika1_datasetDataSetTableAdapters;
using static System.Net.Mime.MediaTypeNames;

namespace Praktika1_DataSet
{
    public partial class First : Page
    {
        SUSHIBARSTableAdapter SUSHIBARS = new SUSHIBARSTableAdapter();

        public First()
        {
            InitializeComponent();
            SushiDataGrid.ItemsSource = SUSHIBARS.GetData();
        }
        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }

        private void Dobavlenie_Click(object sender, RoutedEventArgs e)
        {
            string TITLE = NameTbx.Text;
            int WORKINGHOURSE = int.Parse(WorkingHourse.Text);

            SUSHIBARS.InsertQuery(TITLE, WORKINGHOURSE);
            SushiDataGrid.ItemsSource = SUSHIBARS.GetData();
        }

        private void Udalenie_Click(object sender, RoutedEventArgs e)
        {
            object ID_SUSHIBARS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            SUSHIBARS.DeleteQuery(Convert.ToInt32(ID_SUSHIBARS));
            SushiDataGrid.ItemsSource = SUSHIBARS.GetData();
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            string TITLE = TitleTbx.Text;
            int WORKINGHOURSE = int.Parse(WH.Text);

            object ID_SUSHIBARS = (SushiDataGrid.SelectedItem as DataRowView).Row[0];
            SUSHIBARS.UpdateQuery (TITLE, WORKINGHOURSE, Convert.ToInt32(ID_SUSHIBARS));
            SushiDataGrid.ItemsSource = SUSHIBARS.GetData();
        }

        private void SushiDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SushiDataGrid.SelectedItem != null)
            {
                DataRowView selectedRow = SushiDataGrid.SelectedItem as DataRowView;


                string title = selectedRow.Row["TITLE"].ToString();
                int work = Convert.ToInt32(selectedRow["WORKINGHOURSE"]);
                string integerAsString = work.ToString();

                NameTbx.Text = title;
                WorkingHourse.Text = integerAsString;
                TitleTbx.Text = title;
                WH.Text = integerAsString;

            }
        }


    }
}
