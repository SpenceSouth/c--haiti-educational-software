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
            string title = "";
            string prompt = "";


            switch (name)
            {
                case "button0":
                    title = "Description";
                    prompt = "Learn about classification and characteristics of plants.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\Characteristics_of_Plants.pps");
                    }
                    break;
                case "button1":
                    title = "Description";
                    prompt = "Encyclopedic:  All about Earth, Weather, Oceans, Mammals, Birds.\nWould you like to start this activity?";
                    var dr1 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr1 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\everythingonearth.pdf");
                    }
                    break;
                case "button2":
                    title = "Description";
                    prompt = "Learn about water, its origin and uses.\nWould you like to start this activity?";
                    var dr2 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr2 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\Water.pps");
                    }
                    break;
                case "button5":
                    title = "Description";
                    prompt = "Learn about characteristics, components and working of the ecosystem.\nWould you like to start this activity?";
                    var dr5 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr5 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\ECOSYSTEM_for_kids.pps");
                    }
                    break;
                case "button6":
                    title = "Description";
                    prompt = "Learn about the living process and lifecycle of plants.\nWould you like to start this activity?";
                    var dr6 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr6 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\life cycle of plans.pps");
                    }
                    break;
                case "button9":
                    title = "Description";
                    prompt = "Learn about plans and what nutrients they need to survive.\nWould you like to start this activity?";
                    var dr9 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr9 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\Essential_Nutrients_of_Plants.pps");
                    }
                    break;
                case "button10":
                    title = "Description";
                    prompt = "Types of plants: Learn about three main types of plants and their characteristics.\nWould you like to start this activity?";
                    var dr10 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr10 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\Types_of_plant.pps");
                    }
                    break;
                default:
                    return;
            }

        }
    }
}
