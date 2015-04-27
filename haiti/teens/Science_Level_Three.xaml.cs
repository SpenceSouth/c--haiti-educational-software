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
        private void Program_Click(object sender, RoutedEventArgs e)
        {
            string name = (string)((Button)sender).Name;

            switch (name)
            {
                case "button0":
                    Process.Start("");
                    break;
                case "button1":
                    Process.Start("");
                    break;
                case "button2":
                    Process.Start("");
                    break;
                case "button3":
                    Process.Start("");
                    break;
                case "button4":
                    Process.Start("");
                    break;
                case "button5":
                    Process.Start("");
                    break;
                case "button6":
                    Process.Start("");
                    break;
                case "button7":
                    Process.Start("");
                    break;
                case "button8":
                    Process.Start("");
                    break;
                case "button9":
                    Process.Start("");
                    break;
                case "button10":
                    Process.Start("");
                    break;
                case "button11":
                    Process.Start("");
                    break;
                case "button12":
                    Process.Start("");
                    break;
                case "button13":
                    Process.Start("");
                    break;
                case "button14":
                    Process.Start("");
                    break;
                case "button15":
                    Process.Start("");
                    break;
                case "button16":
                    Process.Start("");
                    break;
                case "button17":
                    Process.Start("");
                    break;
                case "button18":
                    Process.Start("");
                    break;
                case "button19":
                    Process.Start("");
                    break;
                case "button20":
                    Process.Start("");
                    break;
                case "button21":
                    Process.Start("");
                    break;
                case "button22":
                    Process.Start("");
                    break;
                case "button23":
                    Process.Start("");
                    break;
                case "button24":
                    Process.Start("");
                    break;
                case "button25":
                    Process.Start("");
                    break;
                case "button26":
                    Process.Start("");
                    break;
                case "button27":
                    Process.Start("");
                    break;
                case "button28":
                    Process.Start("");
                    break;
                case "button29":
                    Process.Start("");
                    break;
                case "button30":
                    Process.Start("");
                    break;
                case "button31":
                    Process.Start("");
                    break;
                case "button32":
                    Process.Start("");
                    break;
                case "button33":
                    Process.Start("");
                    break;
                case "button34":
                    Process.Start("");
                    break;
                case "button35":
                    Process.Start("");
                    break;
                case "button36":
                    Process.Start("");
                    break;
                case "button37":
                    Process.Start("");
                    break;
                case "button38":
                    Process.Start("");
                    break;
                case "button39":
                    Process.Start("");
                    break;
                case "button40":
                    Process.Start("");
                    break;
                case "button41":
                    Process.Start("");
                    break;
                case "button42":
                    Process.Start("");
                    break;
                case "button43":
                    Process.Start("");
                    break;
                case "button44":
                    Process.Start("");
                    break;
                case "button45":
                    Process.Start("");
                    break;
                case "button46":
                    Process.Start("");
                    break;
                case "button47":
                    Process.Start("");
                    break;
                case "button48":
                    Process.Start("");
                    break;
                case "button49":
                    Process.Start("");
                    break;
                case "button50":
                    Process.Start("");
                    break;
                case "button51":
                    Process.Start("");
                    break;
                case "button52":
                    Process.Start("");
                    break;
                case "button53":
                    Process.Start("");
                    break;
                case "button54":
                    Process.Start("");
                    break;
                case "button55":
                    Process.Start("");
                    break;
                case "button56":
                    Process.Start("");
                    break;
                case "button57":
                    Process.Start("");
                    break;
                default:
                    break;
            }
        }


       
    }
}
