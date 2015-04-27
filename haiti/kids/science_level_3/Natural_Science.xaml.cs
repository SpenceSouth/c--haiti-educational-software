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

namespace haiti.kids.science_level_3
{
    /// <summary>
    /// Interaction logic for Natural_Science.xaml
    /// </summary>
    public partial class Natural_Science : Page
    {
        public Natural_Science()
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
                    Process.Start("kids\\level_3\\Science\\Characteristics_of_Plants.ppt");
                    break;
                case "button1":
                    Process.Start("kids\\level_3\\Science\\everythingonearth.pdf");
                    break;
                case "button2":
                    Process.Start("kids\\level_3\\Science\\Water.ppt");
                    break;
                case "button5":
                    Process.Start("kids\\level_3\\Science\\ECOSYSTEM_for_kids.ppt");
                    break;
                case "button6":
                    Process.Start("kids\\level_3\\Science\\life cycle of plans.ppt");
                    break;
                case "button9":
                    Process.Start("kids\\level_3\\Science\\Essential_Nutrients_of_Plants.ppt");
                    break;
                case "button10":
                    Process.Start("kids\\level_3\\Science\\Types_of_plant.ppt");
                    break;
                default:
                    return;
            }

        }
    }
}
