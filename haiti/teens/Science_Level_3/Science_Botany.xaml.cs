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

namespace haiti.teens.Science_Level_3
{
    /// <summary>
    /// Interaction logic for Science_Botany.xaml
    /// </summary>
    public partial class Science_Botany : Page
    {
        public Science_Botany()
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
                case "b1":
                    Process.Start("teens\\level_3\\Science\\Plants\\Characteristics_of_Plants.ppt");
                    break;
                case "b2":
                    Process.Start("teens\\level_3\\Science\\Plants\\Essential_Nutrients_of_Plants.ppt");
                    break;
                case "b3":
                    Process.Start("teens\\level_3\\Science\\Plants\\life cycle of plans.ppt");
                    break;
                case "b4":
                    Process.Start("teens\\level_3\\Science\\Plants\\Need_of_Growing_Plants.ppt");
                    break;
                case "b5":
                    Process.Start("teens\\level_3\\Science\\Plants\\Photosynthesis.ppt");
                    break;
                case "b6":
                    Process.Start("teens\\level_3\\Science\\Plants\\Plans science.ppt");
                    break;
                case "b7":
                    Process.Start("teens\\level_3\\Science\\Plants\\Plant cells.ppt");
                    break;
                case "b8":
                    Process.Start("teens\\level_3\\Science\\Plants\\Plant_Process.ppt");
                    break;
                case "b9":
                    Process.Start("teens\\level_3\\Science\\Plants\\Types_of_plant.ppt");
                    break;
                case "b10":
                    Process.Start("teens\\level_3\\Science\\Plants\\Water.ppt");
                    break;
                case "b11":
                    Process.Start("teens\\level_3\\Science\\Plants\\Water_Cycle.ppt");
                    break;
                default:
                    break;
            }
        }
    }
}