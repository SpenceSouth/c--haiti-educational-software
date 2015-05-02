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
    /// Interaction logic for Counting.xaml
    /// </summary>
    public partial class Counting : Page
    {
        public Counting()
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
                    prompt = "Learn to count numbers with pictures.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\NumbersPowerPoint_1_.pps");
                    }
                    break;
                case "button1":
                    title = "Description";
                    prompt = "Counting Worksheet #1.\nWould you like to start this activity?";
                    var dr1 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr1 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-2.pdf");
                    }
                    break;
                case "button2":
                    title = "Description";
                    prompt = "Counting Worksheet #2.\nWould you like to start this activity?";
                    var dr2 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr2 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-3.pdf");
                    }
                    break;
                case "button3":
                    title = "Description";
                    prompt = "Counting Worksheet #8.\nWould you like to start this activity?";
                    var dr3 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr3 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-4.pdf");
                    }
                    break;
                case "button4":
                    title = "Description";
                    prompt = "Counting Worksheet #3.\nWould you like to start this activity?";
                    var dr4 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr4 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-4.pdf");
                    }
                    break;                
                case "button5":
                    title = "Description";
                    prompt = "Counting Worksheet #4.\nWould you like to start this activity?";
                    var dr5 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr5 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-6.pdf");
                    }
                    break;
                case "button6":
                    title = "Description";
                    prompt = "Counting Worksheet #5.\nWould you like to start this activity?";
                    var dr6 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr6 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-7.pdf");
                    }
                    break;
                case "button7":
                    title = "Description";
                    prompt = "Counting Worksheet #6.\nWould you like to start this activity?";
                    var dr7 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr7 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-8.pdf");
                    }
                    break;
                case "button8":
                    title = "Description";
                    prompt = "Counting Worksheet #7.\nWould you like to start this activity?";
                    var dr8 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr8 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_3\\Math\\count-pictures-1.pdf");
                    }
                    break;


                default:
                    return;
            }

        }
    }
}
