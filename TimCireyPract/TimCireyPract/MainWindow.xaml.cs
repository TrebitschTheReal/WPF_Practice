﻿using System;
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

namespace TimCireyPract
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button_Exit.Foreground = Brushes.White;
            var people = new People();

            myComboBox.ItemsSource = people.Crowd;

        }

        private void Button_Exit_Click (object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Do you really want to quit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Button_Send_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {textBox_FirstName.Text}!","", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            button_Exit.Foreground = Brushes.White;
        }
    }
}
