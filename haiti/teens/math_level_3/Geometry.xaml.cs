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
    /// Interaction logic for Geometry.xaml
    /// </summary>
    public partial class Geometry : Page
    {
        public Geometry()
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
                    if (Utils.Prompt("Description", "Learn how to plot slope on a graph.", 0))
                        Process.Start("teens\\level_3\\Math\\GRAPHING__POINT___SLOPE.ppt");
                    break;
                case "button1":
                    if (Utils.Prompt("Description", "Graphing variables; Learn how to plot variables on a graph.", 0))
                        Process.Start("teens\\level_3\\Math\\GRAPH___2___VARIABLES.ppt");
                    break;
                case "button2":
                    if (Utils.Prompt("Description", "Learn about different types of triangles.", 0))
                        Process.Start("teens\\level_3\\Math\\TRIANGLE_CLASSIFICATION.ppt");
                    break;
                default:
                    return;
            }

        }
    }
}
