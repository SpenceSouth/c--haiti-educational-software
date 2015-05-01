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
    /// Interaction logic for Algebra.xaml
    /// </summary>
    public partial class Algebra : Page
    {
        public Algebra()
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
                    if (Utils.Prompt("Description", "Introduction to square root and cubes problems.", 0))
                        Process.Start("teens\\math_level_3\\Math\\ALGEBRA_SQUARE_ROOT__CUBES.ppt");
                    break;
                case "button1:":
                    if (Utils.Prompt("Description", "Introduction to area, perimeter, and circumference problems.", 0))
                        Process.Start("teens\\math_level_3\\Math\\AREA_PERIMETER_CIRCUMFERENC.ppt");
                    break;
                case "button2:":
                    if (Utils.Prompt("Description", "Introduction to decimals and fractions.", 0))
                        Process.Start("teens\\math_level_3\\Math\\DECIMALS____FRACTIONS.ppt");
                    break;
                case "button3:":
                    if (Utils.Prompt("Description", "Learn to solve equations and problems.", 0))
                        Process.Start("teens\\math_level_3\\Math\\EQUATIONS___PROBLEM_SOLVING.ppt");
                    break;
                case "button4:":
                    if (Utils.Prompt("Description", "Learn about mean, median, mode and range problems..", 0))
                        Process.Start("teens\\math_level_3\\Math\\MEAN_MEDIAN_MODE_RANGE.ppt");
                    break;
                case "button5:":
                    if (Utils.Prompt("Description", "Rounding and estimating.", 0))
                        Process.Start("teens\\math_level_3\\Math\\ROUNDING__ESTIMATING.ppt");
                    break;
                default:
                    return;
            }

        }
    }
}
