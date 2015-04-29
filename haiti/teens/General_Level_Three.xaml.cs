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
                    Process.Start("teens\\level_3\\GK\\akidsencyclopediaofpoliticalscience.pdf");
                    break;
                case "button1":
                    Process.Start("teens\\level_3\\GK\\childrensillustrateddictionary.pdf");
                    break;
                case "button2":
                    Process.Start("teens\\level_3\\GK\\Climate.ppt");
                    break;
                case "button3":
                    Process.Start("teens\\level_3\\GK\\Climate__Factors__definition.ppt");
                    break;
                case "button4":
                    Process.Start("teens\\level_3\\GK\\completeflagsoftheworldsmithsonianhandbooks.pdf");
                    break;
                case "button5":
                    Process.Start("teens\\level_3\\GK\\Continents.doc");
                    break;
                case "button6":
                    Process.Start("teens\\level_3\\GK\\Continents__Ocean.ppt");
                    break;
                case "button7":
                    Process.Start("teens\\level_3\\GK\\countries.pdf");
                    break;
                case "button8":
                    Process.Start("teens\\level_3\\GK\\Deserts.ppt");
                    break;
                case "button9":
                    Process.Start("teens\\level_3\\GK\\everythingonearth.pdf");
                    break;
                case "button10":
                    Process.Start("teens\\level_3\\GK\\Flags_Europe.pdf");
                    break;
                case "button11":
                    Process.Start("teens\\level_3\\GK\\Floods.ppt");
                    break;
                case "button12":
                    Process.Start("teens\\level_3\\GK\\Gravity_and_Friction.ppt");
                    break;
                case "button13":
                    Process.Start("teens\\level_3\\GK\\humanbodysystemsforkids.pdf");
                    break;
                case "button14":
                    Process.Start("teens\\level_3\\GK\\justenoughenglishgrammarillustrated.pdf");
                    break;
                case "button15":
                    Process.Start("teens\\level_3\\GK\\Landforms_.ppt");
                    break;
                case "button16":
                    Process.Start("teens\\level_3\\GK\\Landforms_for_Kids_types.ppt");
                    break;
                case "button17":
                    Process.Start("teens\\level_3\\GK\\lyoungchildrenspicturedictionary.pdf");
                    break;
                case "button18":
                    Process.Start("teens\\level_3\\GK\\Mountains.ppt");
                    break;
                case "button19":
                    Process.Start("teens\\level_3\\GK\\my-new-words-activity-book.pdf");
                    break;
                case "button20":
                    Process.Start("teens\\level_3\\GK\\north & south america.pdf");
                    break;
                case "button21":
                    Process.Start("teens\\level_3\\GK\\Oceans_Facts.ppt");
                    break;
                case "button22":
                    Process.Start("teens\\level_3\\GK\\OXYGEN.ppt");
                    break;
                case "button23":
                    Process.Start("teens\\level_3\\GK\\picturegrammarforchildrenstarter.pdf");
                    break;
                case "button24":
                    Process.Start("teens\\level_3\\GK\\Rainbows.ppt");
                    break;
                case "button25":
                    Process.Start("teens\\level_3\\GK\\Save_Environment_Why__How.ppt");
                    break;
                case "button26":
                    Process.Start("teens\\level_3\\GK\\thegreatbookofquestionsandanswersover1000questionsandanswers.pdf");
                    break;
                case "button27":
                    Process.Start("teens\\level_3\\GK\\thevisualworldatlas-factsandmapsofthecurrentworld.pdf");
                    break;
                case "button28":
                    Process.Start("teens\\level_3\\GK\\tornadoes.ppt");
                    break;
                case "button29":
                    Process.Start("teens\\level_3\\GK\\Tsunami_Safety.ppt");
                    break;
                case "button30":
                    Process.Start("teens\\level_3\\GK\\");
                    break;
                case "button31":
                    Process.Start("teens\\level_3\\GK\\");
                    break;
                case "button32":
                    Process.Start("teens\\level_3\\GK\\");
                    break;
                default:
                    break;
            }
        }


    }
}
