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
    /// Interaction logic for TeensPage.xaml
    /// </summary>
    public partial class TeensPage : Page
    {
        public TeensPage()
        {
            InitializeComponent();
            //Add images to existing xaml buttons level 1
            addImageToButton(mathOneButton, "/assets/math.png");
            addImageToButton(scienceOneButton, "/assets/science.png");
            addImageToButton(englishOneButton, "/assets/english.png");
            addImageToButton(generalOneButton, "/assets/generalKnowledge.png");

            //Add images to level 2
            addImageToButton(mathTwoButton, "/assets/math.png");
            addImageToButton(scienceTwoButton, "/assets/science.png");
            addImageToButton(englishTwoButton, "/assets/english.png");
            addImageToButton(generalTwoButton, "/assets/generalKnowledge.png");

            //Add images to level 3
            addImageToButton(mathThreeButton, "/assets/math.png");
            addImageToButton(scienceThreeButton, "/assets/science.png");
            addImageToButton(englishThreeButton, "/assets/english.png");
            addImageToButton(generalThreeButton, "/assets/generalKnowledge.png");
            addImageToButton(jobsButton, "/assets/jobs.png");
        }

        private void addImageToButton(Button b, String src)
        {

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(src, UriKind.RelativeOrAbsolute));

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.Margin = new Thickness(10);
            stackPnl.Children.Add(img);

            b.Content = stackPnl;
            b.Background = Brushes.White;

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
                case "mathOneButton":
                    this.NavigationService.Navigate(new Uri("/teens/Math_Level_One.xaml", UriKind.Relative));
                    break;
                case "scienceOneButton":
                    this.NavigationService.Navigate(new Uri("/teens/Science_Level_One.xaml", UriKind.Relative));
                    break;
                case "englishOneButton":
                    this.NavigationService.Navigate(new Uri("/teens/English_Level_One.xaml", UriKind.Relative));
                    break;
                case "generalOneButton":
                    this.NavigationService.Navigate(new Uri("/teens/General_Level_One.xaml", UriKind.Relative));
                    break;
                case "mathTwoButton":
                    this.NavigationService.Navigate(new Uri("/teens/Math_Level_Two.xaml", UriKind.Relative));
                    break;
                case "scienceTwoButton":
                    this.NavigationService.Navigate(new Uri("/teens/Science_Level_Two.xaml", UriKind.Relative));
                    break;
                case "englishTwoButton":
                    this.NavigationService.Navigate(new Uri("/teens/English_Level_Two.xaml", UriKind.Relative));
                    break;
                case "generalTwoButton":
                    this.NavigationService.Navigate(new Uri("/teens/General_Level_Two.xaml", UriKind.Relative));
                    break;
                case "mathThreeButton":
                    this.NavigationService.Navigate(new Uri("/teens/Math_Level_Three.xaml", UriKind.Relative));
                    break;
                case "scienceThreeButton":
                    this.NavigationService.Navigate(new Uri("/teens/Science_Level_Three.xaml", UriKind.Relative));
                    break;
                case "englishThreeButton":
                    this.NavigationService.Navigate(new Uri("/teens/English_Level_Three.xaml", UriKind.Relative));
                    break;
                case "generalThreeButton":
                    this.NavigationService.Navigate(new Uri("/teens/General_Level_Three.xaml", UriKind.Relative));
                    break;
                case "jobsButton":
                    this.NavigationService.Navigate(new Uri("/teens/Jobs_Level_Three.xaml", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }
    }
}
