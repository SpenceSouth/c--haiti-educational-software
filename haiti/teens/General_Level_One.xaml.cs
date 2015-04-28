using System;
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
    /// Interaction logic for General_Level_One.xaml
    /// </summary>
    public partial class General_Level_One : Page
    {
        public General_Level_One()
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
                case "b1":
                    Process.Start("teens\\level_1\\GK\\colouratlasoftheuniverse.pdf");
                    break;
                case "b2":
                    Process.Start("teens\\level_1\\GK\\completeflagsoftheworldsmithsonianhandbooks.pdf");
                    break;
                case "b3":
                    Process.Start("teens\\level_1\\GK\\Continents.doc");
                    break;
                case "b4":
                    Process.Start("teens\\level_1\\GK\\countries.pdf");
                    break;
                case "b5":
                    Process.Start("teens\\level_1\\GK\\Flags_Europe.pdf");
                    break;
                case "b6":
                    Process.Start("teens\\level_1\\GK\\humanbodysystemsforkids.pdf");
                    break;
                case "b7":
                    Process.Start("teens\\level_1\\GK\\north & south america.pdf");
                    break;
                case "b8":
                    Process.Start("teens\\level_1\\GK\\read-clocks-and-write-the-time-1.pdf");
                    break;
                case "b9":
                    Process.Start("teens\\level_1\\GK\\read-clocks-and-write-the-time-2.pdf");
                    break;
                case "b10":
                    Process.Start("teens\\level_1\\GK\\read-time-1.pdf");
                    break;
                case "b11":
                    Process.Start("teens\\level_1\\GK\\read-time-2.pdf");
                    break;
                case "b12":
                    Process.Start("teens\\level_1\\GK\\read-time-3.pdf");
                    break;
                case "b13":
                    Process.Start("teens\\level_1\\GK\\read-time-4.pdf");
                    break;
                case "b14":
                    Process.Start("");
                    break;
                default:
                    break;
            }
        }
    }
}
