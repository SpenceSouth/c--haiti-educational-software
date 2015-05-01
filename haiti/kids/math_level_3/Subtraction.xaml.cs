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

namespace haiti.kids.math_level_3
{
    /// <summary>
    /// Interaction logic for Subtraction.xaml
    /// </summary>
    public partial class Subtraction : Page
    {
        public Subtraction()
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
            String d = "Description";
            String i = "Instructions";

            switch (name)
            {
                case "button0":
                    if(Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-1.pdf");
                    break;
                case "button1":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-2.pdf");
                    break;
                case "button2":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-3.pdf");
                    break;
                case "button3":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0)) 
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-4.pdf");
                    break;
                case "button4":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-5.pdf");
                    break;
                case "button5":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-6.pdf");
                    break;
                case "button6":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-7.pdf");
                    break;
                case "button7":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-8.pdf");
                    break;
                case "button8":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-9.pdf");
                    break;
                case "button9":
                    if (Utils.Prompt(d, "Exercises with subtraction.", 0))
                        Process.Start("kids\\level_3\\Math\\subtract-one-digit-numbers-10.pdf");
                    break;
                default:
                    return;
            }

        }
    }
}
