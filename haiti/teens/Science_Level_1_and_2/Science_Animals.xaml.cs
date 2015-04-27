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

namespace haiti.teens.Science_Level_1_and_2
{
    /// <summary>
    /// Interaction logic for Science_Animals.xaml
    /// </summary>
    public partial class Science_Animals : Page
    {
        public Science_Animals()
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
                    Process.Start("teens\\level_3\\Science\\Animals\\allAboutLions.ppt");
                    break;
                case "b2":
                    Process.Start("teens\\level_3\\Science\\Animals\\Amphibians.ppt");
                    break;
                case "b3":
                    Process.Start("teens\\level_3\\Science\\Animals\\Animal_Life.pdf");
                    break;
                case "b4":
                    Process.Start("teens\\level_3\\Science\\Animals\\Animal_Life_Cycle.ppt");
                    break;
                case "b5":
                    Process.Start("teens\\level_3\\Science\\Animals\\animalAdaptations.ppt");
                    break;
                case "b6":
                    Process.Start("teens\\level_3\\Science\\Animals\\animalClassfications.pdf");
                    break;
                case "b7":
                    Process.Start("teens\\level_3\\Science\\Animals\\animalFacts.ppt");
                    break;
                case "b8":
                    Process.Start("teens\\level_3\\Science\\Animals\\animalFacts2.ppt");
                    break;
                case "b9":
                    Process.Start("teens\\level_3\\Science\\Animals\\animalGroups.pdf");
                    break;
                case "b10":
                    Process.Start("teens\\level_3\\Science\\Animals\\animals_winter.ppt");
                    break;
                case "b11":
                    Process.Start("teens\\level_3\\Science\\Animals\\birds.ppt");
                    break;
                case "b12":
                    Process.Start("teens\\level_3\\Science\\Animals\\Butterfly.ppt");
                    break;
                case "b13":
                    Process.Start("teens\\level_3\\Science\\Animals\\Dinosaur_.ppt");
                    break;
                case "b14":
                    Process.Start("teens\\level_3\\Science\\Animals\\Dolbhin.ppt");
                    break;
                case "b15":
                    Process.Start("teens\\level_3\\Science\\Animals\\ecosystem.ppt");
                    break;
                case "b16":
                    Process.Start("teens\\level_3\\Science\\Animals\\elephant.ppt");
                    break;
                case "b17":
                    Process.Start("teens\\level_3\\Science\\Animals\\forestAnimals.ppt");
                    break;
                case "b18":
                    Process.Start("teens\\level_3\\Science\\Animals\\frogLifeCycle.ppt");
                    break;
                case "b19":
                    Process.Start("teens\\level_3\\Science\\Animals\\giraffe.pdf");
                    break;
                case "b20":
                    Process.Start("teens\\level_3\\Science\\Animals\\Glow_Worms_Fire_Fly.ppt");
                    break;
                case "b21":
                    Process.Start("teens\\level_3\\Science\\Animals\\Insects.ppt");
                    break;
                case "b22":
                    Process.Start("teens\\level_3\\Science\\Animals\\Interesting_Animals.ppt");
                    break;
                case "b23":
                    Process.Start("teens\\level_3\\Science\\Animals\\Monkeys.ppt");
                    break;
                case "b24":
                    Process.Start("teens\\level_3\\Science\\Animals\\Mosquitoes.ppt");
                    break;
                case "b25":
                    Process.Start("teens\\level_3\\Science\\Animals\\pandaBear.ppt");
                    break;
                case "b26":
                    Process.Start("teens\\level_3\\Science\\Animals\\polarBears.ppt");
                    break;
                case "b27":
                    Process.Start("teens\\level_3\\Science\\Animals\\Vertebrates.ppt");
                    break;
                default:
                    break;
            }
        }
    }
}
