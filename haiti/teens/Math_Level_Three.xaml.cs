﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace haiti.teens
{
    /// <summary>
    /// Interaction logic for Math_Level_Three.xaml
    /// </summary>
    public partial class Math_Level_Three : Page
    {
        public Math_Level_Three()
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

        private void addImageToButton(Button b, String src)
        {

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(src, UriKind.RelativeOrAbsolute));

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.Margin = new Thickness(10);
            stackPnl.Children.Add(img);

            b.Content = stackPnl;
            b.Background = Brushes.White;

        }

        private void addImageToButton(Button b, String src, String text)
        {

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(src, UriKind.RelativeOrAbsolute));

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.Margin = new Thickness(10);
            stackPnl.Children.Add(img);
            TextBlock t = new TextBlock();
            t.Text = text;
            //stackPnl.Children.Add(t);

            b.Content = stackPnl;
            b.Background = Brushes.White;

        }

        private void Program_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Content;

            switch (name)
            {
                case "Addition":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\addition.xaml", UriKind.Relative));
                    break;
                case "Subtraction":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\subtraction.xaml", UriKind.Relative));
                    break;
                case "Multiplication":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\multiplication.xaml", UriKind.Relative));
                    break;
                case "Division":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\division.xaml", UriKind.Relative));
                    break;
                case "Lengths":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\lengths.xaml", UriKind.Relative));
                    break;
                case "Percentages":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\percentages.xaml", UriKind.Relative));
                    break;
                case "Graphs":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\graphs.xaml", UriKind.Relative));
                    break;
                case "Fractions":
                    this.NavigationService.Navigate(new Uri("teens\\math_general\\fractions.xaml", UriKind.Relative));
                    break;

                /*
                case "Multiplication":
                    Program.openMultiplicationPPT();
                    break;
                 */
            }
        }

       
    }
}
