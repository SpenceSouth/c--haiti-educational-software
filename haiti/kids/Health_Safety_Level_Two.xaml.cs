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
    /// Interaction logic for Health_Safety_Level_Two.xaml
    /// </summary>
    public partial class Health_Safety_Level_Two : Page
    {
        public Health_Safety_Level_Two()
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
                case "germsAwayButton":
                    Process.Start("kids\\level_2\\Health\\germsAway.ppt");
                    break;
                case "goodHabitsButton":
                    Process.Start("kids\\level_2\\Health\\goodhabits.ppt");
                    break;
                case "humanBodyButton":
                    Process.Start("kids\\level_2\\Health\\humanBody.ppt");
                    break;
                case "personalHygeineButton":
                    Process.Start("kids\\level_2\\Health\\personalhygiene.ppt");
                    break;
                case "safetyButton":
                    Process.Start("kids\\level_2\\Health\\personalhygieneandsunsafety.ppt");
                    break;
                case "phs1Button":
                    Process.Start("kids\\level_2\\Health\\phs1.pdf");
                    break;
                case "phs2Button":
                    Process.Start("kids\\level_2\\Health\\phs2.pdf");
                    break;
                case "phs3Button":
                    Process.Start("kids\\level_2\\Health\\phs3.pdf");
                    break;
                case "phs4Button":
                    Process.Start("kids\\level_2\\Health\\phs4.pdf");
                    break;
                case "phs5Button":
                    Process.Start("kids\\level_2\\Health\\phs5.pdf");
                    break;
                case "phs6Button":
                    Process.Start("kids\\level_2\\Health\\phs6.pdf");
                    break;
                default:
                    break;
            }
        }

       
    }
}
