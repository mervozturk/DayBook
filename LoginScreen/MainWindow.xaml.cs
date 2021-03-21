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

namespace LoginScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnLogin.Click += new RoutedEventHandler(buttonClick);
            
            
            txtregister.MouseUp += new MouseButtonEventHandler(RegisterShow);

        }
        
        private void RegisterShow(Object sender, EventArgs e)
        {
            RegisterScreen screen = new RegisterScreen();
            screen.Show();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (txtMail.Text == "" && password.Password=="")
            {
                Button clicked = (Button)sender;
                MessageBox.Show("Mail yada Şifrenizi Boş bıraktınız ");
            }
            else
            {
                WeekScreen screen = new WeekScreen();
                screen.Show();
            }
            
            
        }
    }
}
