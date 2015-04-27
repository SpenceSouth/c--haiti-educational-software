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

namespace haiti.kids
{
    /// <summary>
    /// Interaction logic for Activitybook_Level_Two.xaml
    /// </summary>
    public partial class Activitybook_Level_Two : Page
    {
        public Activitybook_Level_Two()
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
                case "button0":
                    Process.Start("kids\\level_2\\activity_books\\ab (1).pdf");
                    break;
                case "button1":
                    Process.Start("kids\\level_2\\activity_books\\ab (2).pdf");
                    break;
                case "button2":
                    Process.Start("kids\\level_2\\activity_books\\ab (3).pdf");
                    break;
                case "button3":
                    Process.Start("kids\\level_2\\activity_books\\ab (4).pdf");
                    break;
                case "button4":
                    Process.Start("kids\\level_2\\activity_books\\ab (5).pdf");
                    break;
                case "button5":
                    Process.Start("kids\\level_2\\activity_books\\ab (6).pdf");
                    break;
                case "button6":
                    Process.Start("kids\\level_2\\activity_books\\ab (7).pdf");
                    break;
                case "button7":
                    Process.Start("kids\\level_2\\activity_books\\ab (8).pdf");
                    break;
                case "button8":
                    Process.Start("kids\\level_2\\activity_books\\ab (9).pdf");
                    break;
                case "button9":
                    Process.Start("kids\\level_2\\activity_books\\ab (10).pdf");
                    break;
                case "button10":
                    Process.Start("kids\\level_2\\activity_books\\ab (1).gif");
                    break;
                case "button11":
                    Process.Start("kids\\level_2\\activity_books\\ab (2).gif");
                    break;
                case "button12":
                    Process.Start("kids\\level_2\\activity_books\\ab (3).gif");
                    break;
                case "button13":
                    Process.Start("kids\\level_2\\activity_books\\ab (4).gif");
                    break;
                case "button14":
                    Process.Start("kids\\level_2\\activity_books\\ab (5).gif");
                    break;
                case "button15":
                    Process.Start("kids\\level_2\\activity_books\\ab (6).gif");
                    break;
                case "button16":
                    Process.Start("kids\\level_2\\activity_books\\ab (7).gif");
                    break;
                case "button17":
                    Process.Start("kids\\level_2\\activity_books\\ab (8).gif");
                    break;
                case "button18":
                    Process.Start("kids\\level_2\\activity_books\\ab (9).gif");
                    break;
                case "button19":
                    Process.Start("kids\\level_2\\activity_books\\ab (10).gif");
                    break;
                case "button20":
                    Process.Start("kids\\level_2\\activity_books\\ab (11).gif");
                    break;
                case "button21":
                    Process.Start("kids\\level_2\\activity_books\\ab (12).gif");
                    break;
                case "button22":
                    Process.Start("kids\\level_2\\activity_books\\ab (13).gif");
                    break;
                case "button23":
                    Process.Start("kids\\level_2\\activity_books\\ab (1).jpg");
                    break;
                case "button24":
                    Process.Start("kids\\level_2\\activity_books\\ab (2).jpg");
                    break;
                case "button25":
                    Process.Start("kids\\level_2\\activity_books\\ab (3).jpg");
                    break;
                case "button26":
                    Process.Start("kids\\level_2\\activity_books\\ab (4).jpg");
                    break;
                case "button27":
                    Process.Start("kids\\level_2\\activity_books\\ab (5).jpg");
                    break;
                case "button28":
                    Process.Start("kids\\level_2\\activity_books\\ab (6).jpg");
                    break;
                case "button29":
                    Process.Start("kids\\level_2\\activity_books\\ab (7).jpg");
                    break;
                case "button30":
                    Process.Start("kids\\level_2\\activity_books\\ab (8).jpg");
                    break;
                case "button31":
                    Process.Start("kids\\level_2\\activity_books\\ab (9).jpg");
                    break;
                case "button32":
                    Process.Start("kids\\level_2\\activity_books\\ab (10).jpg");
                    break;
                case "button33":
                    Process.Start("kids\\level_2\\activity_books\\ab (11).jpg");
                    break;
                case "button34":
                    Process.Start("kids\\level_2\\activity_books\\ab (1).png");
                    break;
                case "button35":
                    Process.Start("kids\\level_2\\activity_books\\ab (2).png");
                    break;
                case "button36":
                    Process.Start("kids\\level_2\\activity_books\\ab (3).png");
                    break;
                case "button37":
                    Process.Start("kids\\level_2\\activity_books\\ab (4).png");
                    break;
                case "button38":
                    Process.Start("kids\\level_2\\activity_books\\ab (5).png");
                    break;
                case "button39":
                    Process.Start("kids\\level_2\\activity_books\\ab (6).png");
                    break;
                case "button40":
                    Process.Start("kids\\level_2\\activity_books\\ab (7).png");
                    break;
                case "button41":
                    Process.Start("kids\\level_2\\activity_books\\ab (8).png");
                    break;
                case "button42":
                    Process.Start("kids\\level_2\\activity_books\\ab (9).png");
                    break;
                case "button43":
                    Process.Start("kids\\level_2\\activity_books\\ab (10).png");
                    break;
                case "button44":
                    Process.Start("kids\\level_2\\activity_books\\ab (11).png");
                    break;
                case "button45":
                    Process.Start("kids\\level_2\\activity_books\\ab (12).png");
                    break;
                case "button46":
                    Process.Start("kids\\level_2\\activity_books\\ab (13).png");
                    break;
                case "button47":
                    Process.Start("kids\\level_2\\activity_books\\ab (14).png");
                    break;
                case "button48":
                    Process.Start("kids\\level_2\\activity_books\\ab (15).png");
                    break;
                case "button49":
                    Process.Start("kids\\level_2\\activity_books\\ab (16).png");
                    break;
                case "button50":
                    Process.Start("kids\\level_2\\activity_books\\ab (17).png");
                    break;
                case "button51":
                    Process.Start("kids\\level_2\\activity_books\\ab (18).png");
                    break;
                case "button52":
                    Process.Start("kids\\level_2\\activity_books\\ab (19).png");
                    break;
                case "button53":
                    Process.Start("kids\\level_2\\activity_books\\ab (20).png");
                    break;
                case "button54":
                    Process.Start("kids\\level_2\\activity_books\\ab (21).png");
                    break;
                case "button55":
                    Process.Start("kids\\level_2\\activity_books\\ab (22).png");
                    break;
                case "button56":
                    Process.Start("kids\\level_2\\activity_books\\ab (23).png");
                    break;
                case "button57":
                    Process.Start("kids\\level_2\\activity_books\\ab (24).png");
                    break;
                case "button58":
                    Process.Start("kids\\level_2\\activity_books\\ab (25).png");
                    break;
                case "button59":
                    Process.Start("kids\\level_2\\activity_books\\ab (26).png");
                    break;
                case "button60":
                    Process.Start("kids\\level_2\\activity_books\\ab (27).png");
                    break;
                case "button61":
                    Process.Start("kids\\level_2\\activity_books\\ab (28).png");
                    break;
                case "button62":
                    Process.Start("kids\\level_2\\activity_books\\ab (29).png");
                    break;
                case "button63":
                    Process.Start("kids\\level_2\\activity_books\\ab (30).png");
                    break;
                case "button64":
                    Process.Start("kids\\level_2\\activity_books\\ab (31).png");
                    break;
                case "button65":
                    Process.Start("kids\\level_2\\activity_books\\ab (32).png");
                    break;
                case "button66":
                    Process.Start("kids\\level_2\\activity_books\\ab (33).png");
                    break;
                case "button67":
                    Process.Start("kids\\level_2\\activity_books\\ab (34).png");
                    break;
                case "button68":
                    Process.Start("kids\\level_2\\activity_books\\ab (35).png");
                    break;
                case "button69":
                    Process.Start("kids\\level_2\\activity_books\\ab (36).png");
                    break;
                case "button70":
                    Process.Start("kids\\level_2\\activity_books\\ab (37).png");
                    break;
                case "button71":
                    Process.Start("kids\\level_2\\activity_books\\ab (38).png");
                    break;
                case "button72":
                    Process.Start("kids\\level_2\\activity_books\\ab (39).png");
                    break;
                case "button73":
                    Process.Start("kids\\level_2\\activity_books\\ab (40).png");
                    break;
                case "button74":
                    Process.Start("kids\\level_2\\activity_books\\ab (41).png");
                    break;
                case "button75":
                    Process.Start("kids\\level_2\\activity_books\\ab (42).png");
                    break;
                case "button76":
                    Process.Start("kids\\level_2\\activity_books\\ab (43).png");
                    break;
                case "button77":
                    Process.Start("kids\\level_2\\activity_books\\ab (44).png");
                    break;
                case "button78":
                    Process.Start("kids\\level_2\\activity_books\\ab (45).png");
                    break;
                case "button79":
                    Process.Start("kids\\level_2\\activity_books\\ab (46).png");
                    break;
                case "button80":
                    Process.Start("kids\\level_2\\activity_books\\ab (47).png");
                    break;
                case "button81":
                    Process.Start("kids\\level_2\\activity_books\\ab (48).png");
                    break;
                case "button82":
                    Process.Start("kids\\level_2\\activity_books\\ab (49).png");
                    break;
                case "button83":
                    Process.Start("kids\\level_2\\activity_books\\ab (50).png");
                    break;
                default:
                    MessageBox.Show("Not registered");
                    break;
            }
        }

        private void start(string path)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(path);
            startInfo.Verb = "edit";

            Process.Start(startInfo);
        }

    }
}
