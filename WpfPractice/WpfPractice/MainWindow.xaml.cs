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

namespace WpfPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerBase costumerBase = new CustomerBase();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Button_Add_Customer_Click(object sender, RoutedEventArgs e)
        {

            Customer customer = new Customer(TextBox_Name.Text,int.Parse(TextBox_Age.Text), TextBox_Adress.Text);
            costumerBase.GenerateCustomerList(customer);
        }
    }
}
