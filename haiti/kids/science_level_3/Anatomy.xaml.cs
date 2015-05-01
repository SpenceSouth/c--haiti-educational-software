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

namespace haiti.kids.science_level_3
{
    /// <summary>
    /// Interaction logic for Anatomy.xaml
    /// </summary>
    public partial class Anatomy : Page
    {
        public Anatomy()
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
                    title = "Description";
                    prompt = "Learn about the human body and important organs.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\Human body.ppt");
                    }
                    break;
                case "button5":
                    title = "Description";
                    prompt = "Systems in the Human Body, such as respiration, circulation, etc.\nWould you like to start this activity?";
                    var dr5 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr5 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Science\\humanbodysystemsforkids.pdf");
                    }
                    break;
                default:
                    return;
            }

        }
    }
}
