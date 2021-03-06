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
using System.Diagnostics;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace haiti.teens.math_general
{
    /// <summary>
    /// Interaction logic for multiplication.xaml
    /// </summary>
    public partial class multiplication : Page
    {
        public multiplication()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Content;

            switch (name)
            {
                case "Home":
                    Uri homeUri = new Uri("HomePage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(homeUri);
                    break;
                case "About":
                    Uri aboutUri = new Uri("AboutPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(aboutUri);
                    break;
                case "Kids":
                    Uri programsUri = new Uri("KidsPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(programsUri);
                    break;
                case "Teens":
                    Uri teensUri = new Uri("TeensPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(teensUri);
                    break;
                case "Teachers":
                    Uri teachersUri = new Uri("TeachersPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(teachersUri);
                    break;
            }

        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Name;

            switch (name)
            {
                case "button0":
                    if (Utils.Prompt("Description", "Simple multiplication and word problems.",0))                    
                        Process.Start("teens\\level_3\\Math\\Multiplication_1.ppt");
                    break;
                case "button5":
                    if (Utils.Prompt("Description", "More single digit mutliplication with supporting objects.",0))
                        Process.Start("teens\\level_3\\Math\\Multiplication_2.ppt");
                    break;
                case "button9":
                    if (Utils.Prompt("Description", "Word problem. Multiplying and divding by 1 and 2.  Text explanations.",0))
                        Process.Start("teens\\level_3\\Math\\Multiplication_and_Division_Rules.ppt");
                    break;
                case "button1":
                    if (Utils.Prompt("Description", "Into alegebraic expressions such as 3t or 6b (number times a variable)",0))
                        Process.Start("teens\\level_3\\Math\\Multiplication_Expressions.ppt");
                    break;
                default:
                    return;
            }

        }
    }
}
