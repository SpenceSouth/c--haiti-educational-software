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
            string title = "";
            string prompt = "";  

            switch (name)
            {
                case "button0":
                    title = "Description";
                    prompt = "Learn to write and spell Colors.\nWould you like to start this activity?";
                    var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr0 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (1).pdf");
                    }
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
                    title = "Description";
                    prompt = "Learn to write and spell days of the week (Saturday and Sunday).\nWould you like to start this activity?";
                    var dr6 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr6 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (7).pdf");
                    }
                    break;
                case "button7":
                    title = "Description";
                    prompt = "Learn to write and spell days of the week (Thursday and Friday).\nWould you like to start this activity?";
                    var dr7 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr7 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (8).pdf");
                    }
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
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize, count and write Numbers.\nWould you like to start this activity?";
                    var dr11 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr11 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (2).gif");
                    }
                    break;
                case "button12":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 1.\nWould you like to start this activity?";
                    var dr12 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr12 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (3).gif");
                    }
                    break;
                case "button13":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 2.\nWould you like to start this activity?";
                    var dr13 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr13 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (4).gif");
                    }
                    break;
                case "button14":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 3.\nWould you like to start this activity?";
                    var dr14 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr14 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (5).gif");
                    }
                    break;
                case "button15":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 4.\nWould you like to start this activity?";
                    var dr15 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr15 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (6).gif");
                    }
                    break;
                case "button16":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 5.\nWould you like to start this activity?";
                    var dr16 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr16 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (7).gif");
                    }
                    break;
                case "button17":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 5.\nWould you like to start this activity?";
                    var dr17 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr17 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (8).gif");
                    }
                    break;
                case "button18":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 6.\nWould you like to start this activity?";
                    var dr18 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr18 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (9).gif");
                    }
                    break;
                case "button19":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 7.\nWould you like to start this activity?";
                    var dr19 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr19 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (10).gif");
                    }
                    break;
                case "button20":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 8.\nWould you like to start this activity?";
                    var dr20 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr20 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (11).gif");
                    }
                    break;
                case "button21":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 9.\nWould you like to start this activity?";
                    var dr21 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr21 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (12).gif");
                    }
                    break;
                case "button22":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 10.\nWould you like to start this activity?";
                    var dr22 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr22 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (13).gif");
                    }
                    break;
                case "button23":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize spell 3 letter words.\nWould you like to start this activity?";
                    var dr23 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr23 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (1).jpg");
                    }
                    break;
                case "button27":
                    title = "Description";
                    prompt = "Simple exercise to learn to count numbers.\nWould you like to start this activity?";
                    var dr27 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr27 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (5).jpg");
                    }
                    break;
                case "button28":
                    title = "Description";
                    prompt = "Match the pictures on the left to the correct word on the right.\nWould you like to start this activity?";
                    var dr28 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr28 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (6).jpg");
                    }
                    break;
                case "button29":
                    title = "Description";
                    prompt = "Simple exercise to learn about animals.\nWould you like to start this activity?";
                    var dr29 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr29 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (7).jpg");
                    }
                    break;
                case "button30":
                    title = "Description";
                    prompt = "Simple exercise to learn to count numbers.\nWould you like to start this activity?";
                    var dr30= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr30 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (8).jpg");
                    }
                    break;
                case "button31":
                    title = "Description";
                    prompt = "Simple exercise to recognize shapes and sizes.\nWould you like to start this activity?";
                    var dr31= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr31 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (9).jpg");
                    }
                    break;
                case "button32":
                    title = "Description";
                    prompt = "Simple exercise to learn about where plants, fruits and vegetables grow.\nWould you like to start this activity?";
                    var dr32= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr32 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (10).jpg");
                    }
                    break;
                case "button33":
                    title = "Description";
                    prompt = "Simple exercise to learn about animals.\nWould you like to start this activity?";
                    var dr33= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr33 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (11).jpg");
                    }
                    break;
                case "button34":
                    title = "Description";
                    prompt = "Simple exercise to recognize the difference between objects.\nWould you like to start this activity?";
                    var dr34= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr34 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (1).png");
                    }
                    break;
                case "button35":
                    title = "Description";
                    prompt = "Simple exercise to learn about animals and the food they eat.\nWould you like to start this activity?";
                    var dr35 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr35 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (2).png");
                    }
                    break;
                case "button36":
                    title = "Description";
                    prompt = "Simple exercise to learn to write and arrange numbers.\nWould you like to start this activity?";
                    var dr36= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr36 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (3).png");
                    }
                    break;
                case "button40":
                    title = "Description";
                    prompt = "Simple exercise to learn to count numbers.\nWould you like to start this activity?";
                    var dr40= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr40 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (7).png");
                    }
                    break;
                case "button41":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize, count and write Numbers.\nWould you like to start this activity?";
                    var dr41= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr41 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (8).png");
                    }
                    break;
                case "button42":
                    Process.Start("kids\\level_2\\activity_books\\ab (9).png");
                    break;
                case "button43":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize, count and write Numbers.\nWould you like to start this activity?";
                    var dr43= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr43 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (10).png");
                    }
                    break;
                case "button47":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize, count and write Numbers.\nWould you like to start this activity?";
                    var dr47= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr47 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (14).png");
                    }
                    break;
                case "button48":
                    title = "Description";
                    prompt = "Simple exercise to learn to write and arrange numbers.\nWould you like to start this activity?";
                    var dr48= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr48 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (15).png");
                    }
                    break;
                case "button49":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize, count and write Numbers.\nWould you like to start this activity?";
                    var dr49= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr49 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (16).png");
                    }
                    break;
                case "button50":
                    title = "Description";
                    prompt = "Simple exercise to recognize the difference between objects.\nWould you like to start this activity?";
                    var dr50= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr50 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (17).png");
                    }
                    break;
                case "button51":
                    title = "Description";
                    prompt = "Find the difference between two pictures.\nWould you like to start this activity?";
                    var dr51= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr51 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (18).png");
                    }
                    break;
                case "button52":
                    title = "Description";
                    prompt = "Simple exercise to learn to count numbers.\nWould you like to start this activity?";
                    var dr52= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr52 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (19).png");
                    }
                    break;
                case "button53":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize, count and read Numbers.\nWould you like to start this activity?";
                    var dr53= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr53 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (20).png");
                    }
                    break;
                case "button54":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr54= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr54 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (21).png");
                    }
                    break;
                case "button56":
                    title = "Instructions";
                    prompt = "Draw lines from the princess to her castle.\nWould you like to start this activity?";
                    var dr56= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr56 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (23).png");
                    }
                    break;
                case "button57":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr57= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr57 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (24).png");
                    }
                    break;
                case "button58":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr58= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr58 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (25).png");
                    }
                    break;
                case "button59":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr59= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr59 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (26).png");
                    }
                    break;
                case "button60":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr60= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr60 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (27).png");
                    }
                    break;
                case "button61":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr61= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr61 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (28).png");
                    }
                    break;
                case "button62":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr62= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr62 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (29).png");
                    }
                    break;
                case "button63":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr63= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr63 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (30).png");
                    }
                    break;
                case "button64":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr64= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr64 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (31).png");
                    }
                    break;
                case "button65":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr65= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr65 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (32).png");
                    }
                    break;
                case "button66":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr66= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr66 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (33).png");
                    }
                    break;
                case "button67":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr67= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr67 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (34).png");
                    }
                    break;
                case "button68":
                    title = "Instructions";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr68= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr68 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (35).png");
                    }
                    break;
                case "button69":
                    title = "Description";
                    prompt = " Simple exercise to recognize the difference between objects.\nWould you like to start this activity?";
                    var dr69= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr69 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (36).png");
                    }
                    break;
                case "button70":
                    title = "Description";
                    prompt = "Simple exercise to learn about plants and fruits.\nWould you like to start this activity?";
                    var dr70= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr70 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (37).png");
                    }
                    break;
                case "button71":
                    title = "Description";
                    prompt = "Draw lines from the object to its shadow.\nWould you like to start this activity?";
                    var dr71= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr71 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (38).png");
                    }
                    break;
                case "button72":
                    title = "Instructions";
                    prompt = "Draw lines from the object to its shadow.\nWould you like to start this activity?";
                    var dr72= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr72 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (39).png");
                    }
                    break;
                case "button73":
                    title = "Instructions";
                    prompt = "Draw lines from the object to its shadow.\nWould you like to start this activity?";
                    var dr73= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr73 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (40).png");
                    }
                    break;
                case "button74":
                    title = "Description";
                    prompt = "Simple exercise to recognize the difference between objects.\nWould you like to start this activity?";
                    var dr74= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr74 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (41).png");
                    }
                    break;
                case "button75":
                    title = "Description";
                    prompt = "Find the difference between 5 pictures.\nWould you like to start this activity?";
                    var dr75= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr75 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (42).png");
                    }
                    break;
                case "button76":
                    title = "Description";
                    prompt = "Learn to recognize patterns and shapes.\nWould you like to start this activity?";
                    var dr76= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr76 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (43).png");
                    }
                    break;
                case "button77":
                    title = "Description";
                    prompt = "Learn to recognize patterns and shapes.\nWould you like to start this activity?";
                    var dr77= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr77 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (44).png");
                    }
                    break;
                case "button78":
                    title = "Description";
                    prompt = "Simple exercise to recognize shapes and sizes.\nWould you like to start this activity?";
                    var dr78= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr78 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (45).png");
                    }
                    break;
                case "button79":
                    title = "Description";
                    prompt = "Simple exercise to recognize shapes and sizes.\nWould you like to start this activity?";
                    var dr79= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr79 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (46).png");
                    }
                    break;
                case "button80":
                    title = "Description";
                    prompt = "Trace lines to match the starting point to the destination.\nWould you like to start this activity?";
                    var dr80= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr80 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (47).png");
                    }
                    break;
                case "button81":
                    title = "Description";
                    prompt = "Simple exercise to learn to count numbers.\nWould you like to start this activity?";
                    var dr81= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr81 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (48).png");
                    }
                    break;
                case "button82":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 3.\nWould you like to start this activity?";
                    var dr82= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr82 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (49).png");
                    }
                    break;
                case "button83":
                    title = "Description";
                    prompt = "Simple exercise to learn to recognize and write Number 5.\nWould you like to start this activity?";
                    var dr83= MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                    if (dr83 == MessageBoxResult.Yes)
                    {
                        Process.Start("kids\\level_2\\activity_books\\ab (50).png");
                    }
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