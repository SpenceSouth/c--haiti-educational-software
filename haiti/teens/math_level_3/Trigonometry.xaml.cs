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

namespace haiti.teens.math_level_3
{
    /// <summary>
    /// Interaction logic for Trigonometry.xaml
    /// </summary>
    public partial class Trigonometry : Page
    {
        public Trigonometry()
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
                    if (Utils.Prompt("Description", "Introduction to Trigonometry.", 0))
                        Process.Start("teens\\level_3\\Math\\TRIGONOMETRY_LESSON.ppt");
                    break;
                case "button1":
                    if (Utils.Prompt("Description", "Introduction to Trigonometry - Continued", 0))
                        Process.Start("teens\\level_3\\Math\\TRIG_LESSON_.ppt");
                    break;
                case "button2":
                    if (Utils.Prompt("Description", "Introduction to Pythagorean Theorem.", 0))
                        Process.Start("teens\\level_3\\Math\\TRIG_PYTHAGOREAN_THEOREM.ppt");
                    break;
                case "button3":
                    if (Utils.Prompt("Description", "Learn about sin and cosines and how to work with them...", 0))
                        Process.Start("teens\\level_3\\Math\\TRIG______SINE__COSINE.ppt");
                    break;
                default:
                    return;
            }

        }
    }
}
