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
    /// Interaction logic for English_Level_Three.xaml
    /// </summary>
    public partial class English_Level_Three : Page
    {
        public English_Level_Three()
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
                case "button0":
                    Process.Start("kids\\level_3\\English\\picturegrammarforchildrenstarter.pdf");
                    break;
                case "button1":
                    Process.Start("kids\\level_3\\English\\childrensillustrateddictionary.pdf");
                    break;
                case "button2":
                    Process.Start("kids\\level_3\\English\\lyoungchildrenspicturedictionary.pdf");
                    break;
                case "button3":
                    Process.Start("kids\\level_3\\English\\childrensillustrateddictionary.pdf");
                    break;
              /*  case "button4":
                    Process.Start("kids\\level_3\\Math\\count-pictures-5.pdf");
                    break;
                case "button5":
                    Process.Start("kids\\level_3\\Math\\count-pictures-6.pdf");
                    break;
                case "button6":
                    Process.Start("kids\\level_3\\Math\\count-pictures-7.pdf");
                    break;
                case "button7":
                    Process.Start("kids\\level_3\\Math\\count-pictures-8.pdf");
                    break;
                case "button8":
                    Process.Start("kids\\level_3\\Math\\count-pictures-1.pdf");
                    break;*/


                default:
                    return;
            }

        }

    }
}
