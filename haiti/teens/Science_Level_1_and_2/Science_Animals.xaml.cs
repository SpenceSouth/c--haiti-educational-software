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
                    if(Utils.Prompt("Description", "Facts about lions.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\allAboutLions.ppt");
                    break;
                case "b2":
                    if(Utils.Prompt("Description", "Pictures and descriptions of frogs, toads, and other salamanders - 9 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Amphibians.ppt");
                    break;
                case "b3":
                    if (Utils.Prompt("Description", "Animal Life.", 0))
                    Process.Start("teens\\level_3\\Science\\Animals\\Animal_Life.pdf");
                    break;
                case "b4":
                    if(Utils.Prompt("Description", "Birth, growth, reproduction, death, life span, classification, and anatomy - 14 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Animal_Life_Cycle.ppt");
                    break;
                case "b5":
                    if(Utils.Prompt("Description", "How animals adapt to their environment."))
                        Process.Start("teens\\level_3\\Science\\Animals\\animalAdaptations.ppt");
                    break;
                case "b6":
                    if(Utils.Prompt("Description", "Learn about the classifications of many animals.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\animalClassfications.pdf");
                    break;
                case "b7":
                    if (Utils.Prompt("Description", "All about penguins - 11 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\animalFacts.ppt");
                    break;
                case "b8":
                    if(Utils.Prompt("Description", "Tigers, whales, panda bears, hippos, and more - 12 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\animalFacts2.ppt");
                    break;
                case "b9":
                    if(Utils.Prompt("Description", "Learn about kinds of animals that live in groups.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\animalGroups.pdf");
                    break;
                case "b10":
                    if(Utils.Prompt("Description", "Description of animals in hibernation, migration, and adapting - 10 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\animals_winter.ppt");
                    break;
                case "b11":
                    if(Utils.Prompt("Description", "All about birds.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\brids.ppt");
                    break;
                case "b12":
                    if(Utils.Prompt("Description", "The butterfly lifecycle - 9 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Butterfly.ppt");
                    break;
                case "b13":
                    if(Utils.Prompt("Description", "Pictures and characteristics of a few dinosaurs - 9 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Dinosaur_.ppt");
                    break;
                case "b14":
                    if(Utils.Prompt("Description", "All about dolphins.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Dolbhin.ppt");
                    break;
                case "b15":
                    if (Utils.Prompt("Description", "All about the ecosystem.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\ecosystem.ppt");
                    break;
                case "b16":
                    if(Utils.Prompt("Description", "All about the lifecycle of elephants - 14 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\elephant.ppt");
                    break;
                case "b17":
                    if(Utils.Prompt("Description", "Pictures and description of a few forest animals such as Tigers, Leopards, and Pandas - 10 slides. "))
                        Process.Start("teens\\level_3\\Science\\Animals\\forestAnimals.ppt");
                    break;
                case "b18":
                    if(Utils.Prompt("Description", "All about a frog's metamorphosis - 15 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\frogLifeCycle.ppt");
                    break;
                case "b19":
                    if(Utils.Prompt("Description", "Interesting facts about Giraffes.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\giraffe.pdf");
                    break;
                case "b20":
                    if (Utils.Prompt("Description", "Glow worms and Fire Flies.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Glow_Worms_Fire_Fly.ppt");
                    break;
                case "b21":
                    if(Utils.Prompt("Description", "Pictures and descriptions of several insects - 12 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Insects.ppt");
                    break;
                case "b22":
                    if(Utils.Prompt("Description", "Descriptions of dogs, cats, butterflies(metamorphosis), and frogs(metamorphosis) - 25 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Interesting_Animals.ppt");
                    break;
                case "b23":
                    if(Utils.Prompt("Description", "All about monkeys; their intelligence and grooming - 11 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Monkeys.ppt");
                    break;
                case "b24":
                    if (Utils.Prompt("Description", "All about mosquitos and different species - 15 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Mosquitoes.ppt");
                    break;
                case "b25":
                    if(Utils.Prompt("Description", "All about a Panda's habitat, what they eat, and what they do - 11 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\pandaBear.ppt");
                    break;
                case "b26":
                    if(Utils.Prompt("Description", "Polar bears; what they eat and how they live - 8 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\polarBears.ppt");
                    break;
                case "b27":
                    if(Utils.Prompt("Description", "All about fish, amphibians, reptiles, mammals, and birds -17 slides.", 0))
                        Process.Start("teens\\level_3\\Science\\Animals\\Vertebrates.ppt");
                    break;
                default:
                    break;
            }
        }
    }
}
