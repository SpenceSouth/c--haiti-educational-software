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
    /// Interaction logic for Science_Level_Three.xaml
    /// </summary>
    public partial class Science_Level_Three : Page
    {
        public Science_Level_Three()
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
                case "PeopleButton":
                    this.NavigationService.Navigate(new Uri("teens\\Science_Level_3\\Science_Anatomy.xaml", UriKind.Relative));
                    break;
                case "AnimalsButton":
                    this.NavigationService.Navigate(new Uri("teens\\Science_Level_3\\Science_Zoology.xaml", UriKind.Relative));
                    break;
                case "PlantsButton":
                    this.NavigationService.Navigate(new Uri("teens\\Science_Level_3\\Science_Botany.xaml", UriKind.Relative));
                    break;
                case "PhysicsButton":
                    this.NavigationService.Navigate(new Uri("teens\\Science_Level_3\\Science_Physics_3.xaml", UriKind.Relative));
                    break;
                default:
                    break;

            }
        }       
    }
}
