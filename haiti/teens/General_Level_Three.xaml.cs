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
    /// Interaction logic for General_Level_Three.xaml
    /// </summary>
    public partial class General_Level_Three : Page
    {
        public General_Level_Three()
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
                case "button0":
                    if(Utils.Prompt("Description", "100 page encyclopedia on politics.\nLearn about different terms used in science along with meaning, definition and pictures.", 0))
                        Process.Start("teens\\level_3\\GK\\akidsencyclopediaofpoliticalscience.pdf");
                    break;
                case "button1":
                    if(Utils.Prompt("Description", "258 page encyclopedia dictionary with pictures, definitons, and meanings on various subjects like robots, animals, skeleton, universe, music, sports and more.", 0))
                        Process.Start("teens\\level_3\\GK\\childrensillustrateddictionary.pdf");
                    break;
                case "button2":
                    if(Utils.Prompt("Description", "Causes of climate, winds, location, precipitation, deserts, mountain ranges - 28 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Climate.ppt");
                    break;
                case "button3":
                    if (Utils.Prompt("Description", "Factors influencing climate; weather versus climate; latitude, wind currents, ocean currents, El-Nino, Greenhouse Effect, more - 11 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Climate__Factors__definition.ppt");
                    break;
                case "button4":
                    if (Utils.Prompt("Description", "248 page book on flags, types of flags, country flags and history of flags.", 0))
                        Process.Start("teens\\level_3\\GK\\completeflagsoftheworldsmithsonianhandbooks.pdf");
                    break;
                case "button5":
                    if (Utils.Prompt("Description", "Slides and outlines of continents - 15 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Continents.doc");
                    break;
                case "button6":
                    if (Utils.Prompt("Description", "Seven continents, hemipsheres, exercises - 31 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Continents__Ocean.ppt");
                    break;
                case "button7":
                    if (Utils.Prompt("Description", "Country outlines, flags, spelling, and famous people/country icons - 12 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\countries.pdf");
                    break;
                case "button8":
                    if (Utils.Prompt("Description", "Definitions, types of deserts, desert climate, plants in the desert - 12 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Deserts.ppt");
                    break;
                case "button9":
                    if (Utils.Prompt("Description", "258 page book on everything about Earth, history of Earth, atmosphere, volcanoes, rivers, earthquakes, weather and more.", 0))
                        Process.Start("teens\\level_3\\GK\\everythingonearth.pdf");
                    break;
                case "button10":
                    if (Utils.Prompt("Description", "Flags and spelling of country on each slide - 45 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Flags_Europe.pdf");
                    break;
                case "button11":
                    if (Utils.Prompt("Description", "Floods; natural causes, man-made causes, consequences and examples - 9 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Floods.ppt");
                    break;
                case "button12":
                    if (Utils.Prompt("Description", " Friction and Gravity; Weight;  Air Resistance; Exercises;  Velocity, Formulas, Types of Friction - 17 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Gravity_and_Friction.ppt");
                    break;
                case "button13":
                    if (Utils.Prompt("Description", "12 page book for kids on the human body systems and skeleton", 0))
                        Process.Start("teens\\level_3\\GK\\humanbodysystemsforkids.pdf");
                    break;
                case "button14":
                    if (Utils.Prompt("Description", "145 page book on English grammar with examples and pictures.", 0))
                        Process.Start("teens\\level_3\\GK\\justenoughenglishgrammarillustrated.pdf");
                    break;
                case "button15":
                    if (Utils.Prompt("Description", "Major landforms: rivers, lakes, oceans, mountains, hills, valleys, plains, peninsulas, islands, icecaps - 15 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Landforms_.ppt");
                    break;
                case "button16":
                    if (Utils.Prompt("Description", "Hills versus mountains, valleys, waterfalls, oceans, lakes, isthmus, straits - 17 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Landforms_for_Kids_types.ppt");
                    break;
                case "button17":
                    if (Utils.Prompt("Description", "Dictionary for kids with alphabets, pictures, spellings and word meanings.", 0))
                        Process.Start("teens\\level_3\\GK\\lyoungchildrenspicturedictionary.pdf");
                    break;
                case "button18":
                    if (Utils.Prompt("Description", "Definition of mountains, famous mountains and their locations, temperatures, glaciers, climbing mountains, mount everest, aconcagua(Andes), more - 27 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Mountains.ppt");
                    break;
                case "button19":
                    if (Utils.Prompt("Description", "185 page activity books for children from grade pre-K to 2 with over a 100 activities and games to learn alphabets, numbers, spellings, counting and more.", 0))
                        Process.Start("teens\\level_3\\GK\\my-new-words-activity-book.pdf");
                    break;
                case "button20":
                    if (Utils.Prompt("Description", "Flags and Names of Countries(North and South America) on Separate Slide - 87 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\north & south america.pdf");
                    break;
                case "button21":
                    if (Utils.Prompt("Description", "Fun facts for kids to learn about the ocean and types of oceans - 22 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Oceans_Facts.ppt");
                    break;
                case "button22":
                    if (Utils.Prompt("Description", "Simple presentation for kids to learn about oxygen, its characteristics and formation - 9 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\OXYGEN.ppt");
                    break;
                case "button23":
                    if (Utils.Prompt("Description", "51 page book for kids to learn about grammar with pictures, examples, and activities. ", 0))
                        Process.Start("teens\\level_3\\GK\\picturegrammarforchildrenstarter.pdf");
                    break;
                case "button24":
                    if (Utils.Prompt("Description", "Presentation on rainbows; colors in a rainbow and how it's formed - 21 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Rainbows.ppt");
                    break;
                case "button25":
                    if (Utils.Prompt("Description", "Presentation of how we can save the environment by reusing and recycling daily - 18 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Save_Environment_Why__How.ppt");
                    break;
                case "button26":
                    if (Utils.Prompt("Description", "202 page book to answer all your questions about the universe, planet earth, world history, art and culture, science and technology, human body, animals and more.", 0))
                        Process.Start("teens\\level_3\\GK\\thegreatbookofquestionsandanswersover1000questionsandanswers.pdf");
                    break;
                case "button27":
                    if (Utils.Prompt("Description", "180 page atlas with pictures of earth, solar system, landscapes, citiies, continents and more.", 0))
                        Process.Start("teens\\level_3\\GK\\thevisualworldatlas-factsandmapsofthecurrentworld.pdf");
                    break;
                case "button28":
                    if (Utils.Prompt("Description", "Definitions, causes and facts - 10 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\tornadoes.ppt");
                    break;
                case "button29":
                    if (Utils.Prompt("Description", "Definition, causes, Tsunami safety; Tsunami in Japan - 8 slides.", 0))
                        Process.Start("teens\\level_3\\GK\\Tsunami_Safety.ppt");
                    break;
                default:
                    break;
            }
        }


    }
}
