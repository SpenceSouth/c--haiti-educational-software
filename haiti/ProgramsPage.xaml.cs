using System;
using System.Collections.Generic;
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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class ProgramsPage : Page
    {
        public ProgramsPage()
        {
            MessageBox.Show("Number of categories found by parser " + DataSheetParser.getSize().ToString());
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
                case "Programs":
                    Uri programsUri = new Uri("ProgramsPage.xaml", UriKind.Relative);
                    this.NavigationService.Navigate(programsUri);
                    break;
            }

        }

        private void program1(object sender, RoutedEventArgs e)
        {
            //Find all the program content for grades 1-4
            List<Category> local = new List<Category>();

            foreach (Category cat in DataSheetParser.getCategories())
            {
                foreach(Subject sub in cat.getSubjects()){

                    if (sub.getGrade().Contains("1") || sub.getGrade().Contains("2") || sub.getGrade().Contains("3") || sub.getGrade().Contains("4"))
                    {
                        local.Add(cat);
                    }

                }
            }

            MessageBox.Show("There are " + local.Count + " categories suitable for this grade level");

        }

        private void program2(object sender, RoutedEventArgs e)
        {
            //Find all the program content for grades 5-8
            List<Category> local = new List<Category>();

            foreach (Category cat in DataSheetParser.getCategories())
            {
                foreach (Subject sub in cat.getSubjects())
                {

                    if (sub.getGrade().Contains("5") || sub.getGrade().Contains("6") || sub.getGrade().Contains("7") || sub.getGrade().Contains("8"))
                    {
                        local.Add(cat);
                    }

                }
            }

            MessageBox.Show("There are " + local.Count + " categories suitable for this grade level");

        }

        private void program3(object sender, RoutedEventArgs e)
        {
            //Find all the program content for grades 9-12
            List<Category> local = new List<Category>();

            foreach (Category cat in DataSheetParser.getCategories())
            {
                foreach (Subject sub in cat.getSubjects())
                {

                    if (sub.getGrade().Contains("9") || sub.getGrade().Contains("10") || sub.getGrade().Contains("11") || sub.getGrade().Contains("12"))
                    {
                        local.Add(cat);
                    }

                }
            }

            MessageBox.Show("There are " + local.Count + " categories suitable for this grade level");

        }
    }
}
