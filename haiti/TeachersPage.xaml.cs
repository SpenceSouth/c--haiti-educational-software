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
    /// Interaction logic for TeachersPage.xaml
    /// </summary>
    public partial class TeachersPage : Page
    {
        public TeachersPage()
        {
            InitializeComponent();
            //Add images to existing xaml buttons
            addImageToButton(wordButton, "/assets/microsoftWord.png");
            addImageToButton(powerpointButton, "/assets/microsoftPowerPoint.png");
            addImageToButton(excelButton, "/assets/microsoftExcel.png");  
            addImageToButton(computerButton, "/assets/computer.png");
            addImageToButton(activitySheetsButton, "/assets/activitySheets.png");
            addImageToButton(clsAppDocumentsButton, "/assets/clsApps.png");
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
                case "wordButton":
                    this.NavigationService.Navigate(new Uri("/teachers/Word_Page.xaml", UriKind.Relative));
                    break;
                case "powerpointButton":
                    this.NavigationService.Navigate(new Uri("/teachers/PowerPoint_Page.xaml", UriKind.Relative));
                    break;
                case "computerButton":
                    this.NavigationService.Navigate(new Uri("/teachers/Computer_Page.xaml", UriKind.Relative));
                    break;
                case "activitySheetsButton":
                    this.NavigationService.Navigate(new Uri("/kids/Activitybook_Level_Two.xaml", UriKind.Relative));
                    break;
                case "clsAppDocumentsButton":
                    Process.Start("teachers\\teacher assets\\CLS Learning Apps\\Dishi_EducationalResourcesandBookletsdocumentation.docx.docx");
                    break;
                case "excelButton":
                    this.NavigationService.Navigate(new Uri("/teachers/Excel_Docs_Page.xaml", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }
    }
}
