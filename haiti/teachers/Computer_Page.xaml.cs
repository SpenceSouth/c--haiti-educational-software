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

namespace haiti.teachers
{
    /// <summary>
    /// Interaction logic for Computer_Page.xaml
    /// </summary>
    public partial class Computer_Page : Page
    {
        public Computer_Page()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = (string) ((Button) sender).Content;

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
            string name = (string) ((Button) sender).Name;

            switch (name)
            {
                case "Computer_Basics_1":
                    Process.Start("teachers\\teacher assets\\Computer\\Lecture 1-Basics of computer.ppt");
                    break;
                case "Computer_Basics_2":
                    Process.Start("teachers\\teacher assets\\Computer\\ComputerBasics-2.pdf");
                    break;
                case "Lecture_1":
                    Process.Start("teachers\\teacher assets\\Computer\\Lecture 1-Basics of computer.ppt");
                    break;
                case "Lecture_2":
                    Process.Start("teachers\\teacher assets\\Computer\\Lecture 2-Computer-Basics--Windows and internet.ppt");
                    break;
                case "Computer_fundementals":
                    Process.Start("teachers\\teacher assets\\Computer\\computer_fundamentals_tutorial_Textbook.pdf");
                    break;
                case "Computer_and_Internet":
                    Process.Start("teachers\\teacher assets\\Computer\\Computer and Internet_Lecture2_Print.pdf");
                    break;


                /*
                case "Multiplication":
                    Program.openMultiplicationPPT();
                    break;
                 */
            }

        }

    }
}