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
    /// Interaction logic for Phonics_Level_One.xaml
    /// </summary>
    public partial class Phonics_Level_One : Page
    {
        public Phonics_Level_One()
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
                    Process.Start("kids\\level_1\\Phonics\\Animals-1.pps");
                    break;
                case "button1":
                    Process.Start("kids\\level_1\\Phonics\\colors-1.pps");
                    break;
                case "button2":
                    Process.Start("kids\\level_1\\Phonics\\Dolch Phrase Cards.pdf");
                    break;
                case "button3":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Alphabet (Lowercase).pps");
                    break;
                case "button4":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Animals 2.pps");
                    break;
                case "button5":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Colors 2.pps");
                    break;
                case "button6":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Eating Time 1.pps");
                    break;
                case "button7":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Food 2.pps");
                    break;
                case "button8":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Food 3.pps");
                    break;
                case "button9":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Food 4.pps");
                    break;
                case "button10":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Fruits 2.pps");
                    break;
                case "button11":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Musical Instruments 1.pps");
                    break;
                case "button12":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Musical Instruments 2.pps");
                    break;
                case "button13":
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Musical Instruments 3.pps");
                    break;
                case "button14":
                    Process.Start("kids\\level_1\\Phonics\\fruits-1.pps");
                    break;
                case "button15":
                    Process.Start("kids\\level_1\\Phonics\\fruits and vegetables.ppt");
                    break;
                case "button16":
                    Process.Start("kids\\level_1\\Phonics\\Nature-1.pps");
                    break;
                case "button17":
                    Process.Start("kids\\level_1\\Phonics\\sea creatures-1.pps");
                    break;
                case "button18":
                    Process.Start("kids\\level_1\\Phonics\\shapes.ppt");
                    break;
                case "button19":
                    Process.Start("kids\\level_1\\Phonics\\Transport.ppt");
                    break;
                case "button20":
                    Process.Start("kids\\level_1\\Phonics\\vegetable-1.pps");
                    break;
                case "button21":
                    Process.Start("kids\\level_1\\Phonics\\wild animal-1.pps");
                    break;
                default:
                    break;
            }
         }

       
    }
}
