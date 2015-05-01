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
                    if (Utils.Prompt("Description", "Full color atlas of the universe, galaxies, contellations, planets, more.", 0))
                        Process.Start("teens\\level_1\\GK\\colouratlasoftheuniverse.pdf");
                    break;
                case "b2":
                    if (Utils.Prompt("Description", "Flags of all countires, history and meaning of each flag, brief country histories, coat of arms, more.", 0))
                        Process.Start("teens\\level_1\\GK\\completeflagsoftheworldsmithsonianhandbooks.pdf");
                    break;
                case "b3":
                    if (Utils.Prompt("Description", "Continents and countries in each continent outlines", 0))
                        Process.Start("teens\\level_1\\GK\\Continents.doc");
                    break;
                case "b4":
                    if (Utils.Prompt("Description", "Flags, geographical location in the world, recognized leader of the country.", 0))
                        Process.Start("teens\\level_1\\GK\\countries.pdf");
                    break;
                case "b5":
                    if (Utils.Prompt("Description", "Flags and country name.", 0))
                        Process.Start("teens\\level_1\\GK\\Flags_Europe.pdf");
                    break;
                case "b6":
                    if (Utils.Prompt("Description", "Taught in 7th grade.  Major bodily systems: Respiration, circulation, nervous, more.", 0))
                        Process.Start("teens\\level_1\\GK\\humanbodysystemsforkids.pdf");
                    break;
                case "b7":
                    if (Utils.Prompt("Description", "Flags and names of countries on seperate slides.", 0))
                        Process.Start("teens\\level_1\\GK\\north & south america.pdf");
                    break;
                case "b8":
                    if (Utils.Prompt("Description", "Exercises in telling time and adding / subtracting from displayed time.", 0))
                        Process.Start("teens\\level_1\\GK\\read-clocks-and-write-the-time-1.pdf");
                    break;
                case "b9":
                    if (Utils.Prompt("Description", "Exercises in telling time and adding / subtracting from displayed time.", 0))
                        Process.Start("teens\\level_1\\GK\\read-clocks-and-write-the-time-2.pdf");
                    break;
                case "b10":
                    if (Utils.Prompt("Description", "Shows Clock; Tests ability to read clock; three exercises", 0))
                        Process.Start("teens\\level_1\\GK\\read-time-1.pdf");
                    break;
                case "b11":
                    if (Utils.Prompt("Description", "Shows Clock; Tests ability to read clock; three exercises", 0))
                        Process.Start("teens\\level_1\\GK\\read-time-2.pdf");
                    break;
                case "b12":
                    if (Utils.Prompt("Description", "Shows Clock; Tests ability to read clock; four exercises", 0))
                        Process.Start("teens\\level_1\\GK\\read-time-3.pdf");
                    break;
                case "b13":
                    if (Utils.Prompt("Description", "Shows Clock; Tests ability to read clock; four exercises", 0))
                        Process.Start("teens\\level_1\\GK\\read-time-4.pdf");
                    break;
                default:
                    break;
            }
        }
    }
}
