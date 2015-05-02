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
            string title = "";
            string prompt = "";

            switch (name)
            {
                case "button0":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the animals.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Animals-1.pps");
                    }
                    break;
                case "button1":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr1 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr1 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\colors-1.pps");
                    }
                    break;
                case "button2":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr2 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr2 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Dolch Phrase Cards.pdf");
                    }
                    break;
                case "button3":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr3 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr3 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Alphabet (Lowercase).pps");
                    }
                    break;
                case "button4":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr4 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr4 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Animals 2.pps");
                    }
                    break;
                case "button5":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr5 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr5 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Colors 2.pps");
                    }
                    break;
                case "button6":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr6 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr6 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Eating Time 1.pps");
                    }
                    break;
                case "button7":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr7 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr7 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Food 2.pps");
                    }
                    break;
                case "button8":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr8 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr8 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Food 3.pps");
                    }
                    break;
                case "button9":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr9 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr9 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Food 4.pps");
                    }
                    break;
                case "button10":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr10 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr10 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Fruits 2.pps");
                    }
                    break;
                case "button11":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr11 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr11 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Musical Instruments 1.pps");
                    }
                    break;
                case "button12":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr12 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr12 == MessageBoxResult.Yes)
                        {
                    Process.Start("kids\\level_1\\Phonics\\Flash Cards - Musical Instruments 2.pps");
                    }
                    break;
                case "button13":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr13 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr13 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Flash Cards - Musical Instruments 3.pps");
                    }
                    break;
                case "button14":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr14 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr14 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\fruits-1.pps");
                    }
                    break;
                case "button15":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr15 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr15 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\fruits and vegetables1.pps");
                    }
                    break;
                case "button16":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr16 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr16 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\Nature-1.pps");
                    }
                    break;
                case "button17":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr17 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr17 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\sea creatures-1.pps");
                    }
                    break;
                case "button18":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr18 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr18 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\shapes1.pps");
                    }
                    break;
                case "button19":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr19 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr19 == MessageBoxResult.Yes)
                    {
                     Process.Start("kids\\level_1\\Phonics\\Transport1.pps");
                    }
                    break;
                case "button20":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr20 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr20 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\vegetable-1.pps");
                    }
                    break;
                case "button21":
                    title = "Instructions";
                    prompt = "Press Page down Key to advance through the items.\nWould you like to start this activity?";
                    var dr21 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr21 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_1\\Phonics\\wild animal-1.pps");
                    }
                    break;
                default:
                    break;
            }
         }

       
    }
}
