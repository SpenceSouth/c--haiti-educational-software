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
using System.Diagnostics;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace haiti.teens.math_general
{
    /// <summary>
    /// Interaction logic for fractions.xaml
    /// </summary>
    public partial class fractions : Page
    {
        public fractions()
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
                    if (Utils.Prompt("Description", "Geometric figures divided into halves.", 0))
                        Process.Start("teens\\level_3\\Math\\halves-thirds-and-fourths-1.pdf");
                    break;
                case "button5":
                    if (Utils.Prompt("Description", "Geometric figures divided into thirds.", 0))
                        Process.Start("teens\\level_3\\Math\\halves-thirds-and-fourths-2.pdf");
                    break;
                case "button9":
                    if (Utils.Prompt("Description", "Geometric figures divided into fourths.", 0))
                        Process.Start("teens\\level_3\\Math\\halves-thirds-and-fourths-3.pdf");
                    break;
                default:
                    return;
            }

        }
    }
}
