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
using Praktika1_DataSet.praktika1_datasetDataSetTableAdapters;



namespace Praktika1_DataSet
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            First firstPage = new First();
            this.Content = firstPage;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Second secondPage = new Second();
            this.Content = secondPage;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Theird theirdPage = new Theird();
            this.Content = theirdPage;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Fourth fourthPage = new Fourth();
            this.Content = fourthPage;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            All allPage = new All();
            this.Content = allPage;
        }
    }
}
