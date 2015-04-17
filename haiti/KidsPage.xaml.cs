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
    public partial class KidsPage : Page
    {

        //Decs
        List<Category> local = new List<Category>();

        public KidsPage()
        {
            InitializeComponent();
            //Get all of the categories that contain subject appropriate for this grade level.
            getCategories();

            //Dynamically create buttons for each category
            createCategoryButtons();
        }

        private void getCategories()
        {
            MessageBox.Show("Number of categories found by parser " + DataSheetParser.getSize().ToString());
            //Find all the program content for grades 1-4

            foreach (Category cat in DataSheetParser.getCategories())
            {
                foreach (Subject sub in cat.getSubjects())
                {

                    if (sub.getGrade().Contains("K") || sub.getGrade().Contains("1") || sub.getGrade().Contains("2") || sub.getGrade().Contains("3") ||
                        sub.getGrade().Contains("4") || sub.getGrade().Contains("5") || sub.getGrade().Contains("6"))
                    {
                        local.Add(cat);
                    }

                }
            }

            MessageBox.Show("There are " + local.Count + " categories suitable for this grade level");

        }

        private void createCategoryButtons()
        {
            int index = 0;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    //Stops us from going out of bounds
                    if (index+1 > local.Count)
                    {
                        return;
                    }

                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri(local.ElementAt(index).getImage(), UriKind.RelativeOrAbsolute));

                    StackPanel stackPnl = new StackPanel();
                    stackPnl.Orientation = Orientation.Horizontal;
                    stackPnl.Margin = new Thickness(10);
                    stackPnl.Children.Add(img);

                    Button button = new Button();
                    //button.Source = new BitmapImage(new Uri(local.ElementAt(index).getImage(), UriKind.Relative));
                    button.Content = stackPnl;
                    button.Click += new RoutedEventHandler(createPage);
                    button.Background = Brushes.White;
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    ProgramField.Children.Add(button);

                    index++;
                }
            }
        }

        private void createPage(object sender, EventArgs e)
        {
            MessageBox.Show("clicked");
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
            }

        }
    }
}
