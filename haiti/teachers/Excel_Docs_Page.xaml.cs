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
    /// Interaction logic for CLS_App_Docs_Page.xaml
    /// </summary>
    public partial class CLS_App_Docs_Page : Page
    {
        public CLS_App_Docs_Page()
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
                case "IntroExcel":
                    Process.Start("teachers\\teacher assets\\MS Excel\\Lecture 5-BeginnerLevel1_IntroExcel.ppt");
                    break;
                case "ExcelBasics":
                    Process.Start("teachers\\teacher assets\\MS Excel\\Lecture 6-BeginnerLevel2-ExcelBasics.ppt");
                    break;
                case "IntermediateExcel":
                    Process.Start("teachers\\teacher assets\\MS Excel\\Lecture 7-Advanced level1-ExcelFormulas.ppt");
                    break;
                case "AdvancedExcel":
                    Process.Start("teachers\\teacher assets\\MS Excel\\Lecture 8-AdvancedLevel2-ExcelFormatting.ppt");
                    break;

            }

        }

    }

}
