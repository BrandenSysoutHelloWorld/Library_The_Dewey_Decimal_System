using Library_The_Dewey_Decimal_System.Pages;
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

namespace Library_The_Dewey_Decimal_System
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

        private void Btn_Replacing_Books_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Replacing_Books replacing = new Replacing_Books();
            replacing.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            System.Windows.Application.Current.Shutdown();

        }

        private void Btn_Identifying_Areas_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Identifying_Areas identifying_Areas = new Identifying_Areas();
            identifying_Areas.Show();
        }

        private void Btn_Finding_Call_Numbers_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Find_Call_Numbers find = new Find_Call_Numbers();
            find.Show();

        }
    }
}
