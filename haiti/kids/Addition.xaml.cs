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

namespace haiti
{
    /// <summary>
    /// Interaction logic for Addition.xaml
    /// </summary>
    public partial class Addition : Page
    {
        public Addition()
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
            string title = "";
            string prompt = "";  

            switch (name)
            {
                case "button0":
                    title = "Instructions";
                    prompt = "Simple program with many addition problems.\nSelect from level 1, 2, 3 based on the difficulty level.\nSolve the problem and select the correct option.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Program.runOlliwitAddition();
                    }
                    break;
                case "button5":
                    title = "Description";
                    prompt = "Learn about addition, subtraction and word problems.\nWould you like to start this activity?";
                    var dr1 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr1 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\add_sub.ppt");
                    }
                    break;
                default:
                    return;
            }

        }
    }
}
