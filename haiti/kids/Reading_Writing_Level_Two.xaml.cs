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

namespace haiti.kids
{
    /// <summary>
    /// Interaction logic for Reading_Writing_Level_Two.xaml
    /// </summary>
    public partial class Reading_Writing_Level_Two : Page
    {
        public Reading_Writing_Level_Two()
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

        private void Program_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Name;

            switch (name)
            {
                case "hps1Button":
                    Process.Start("kids\\level_2\\Reading and writing\\hps1.pdf");
                    break;
                case "hps2Button":
                    Process.Start("kids\\level_2\\Reading and writing\\hps2.pdf");
                    break;
                case "hps3Button":
                    Process.Start("kids\\level_2\\Reading and writing\\hps3.pdf");
                    break;
                case "hps4Button":
                    Process.Start("kids\\level_2\\Reading and writing\\hps4.pdf");
                    break;
                case "hps5Button":
                    Process.Start("kids\\level_2\\Reading and writing\\hps5.pdf");
                    break;
                case "rc1Button":
                    Process.Start("kids\\level_2\\Reading and writing\\rc1.pdf");
                    break;
                case "rc2Button":
                    Process.Start("kids\\level_2\\Reading and writing\\rc2.pdf");
                    break;
                case "readtime1Button":
                    Process.Start("kids\\level_2\\Reading and writing\\readtime1.pdf");
                    break;
                case "readtime2Button":
                    Process.Start("kids\\level_2\\Reading and writing\\readtime2.pdf");
                    break;
                case "readtime3Button":
                    Process.Start("kids\\level_2\\Reading and writing\\readtime3.pdf");
                    break;
                case "readtime4Button":
                    Process.Start("kids\\level_2\\Reading and writing\\readtime4.pdf");
                    break;
                default:
                    break;
            }
        }

       
    }
}
