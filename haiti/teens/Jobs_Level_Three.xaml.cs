﻿using System;
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

namespace haiti.teens
{
    /// <summary>
    /// Interaction logic for Jobs_Level_Three.xaml
    /// </summary>
    public partial class Jobs_Level_Three : Page
    {
        public Jobs_Level_Three()
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
                case "careerChoices2Button":
                    Process.Start("teens\\level_3\\Jobs\\Career-Choices.ppt");
                    break;
                case "jobspptButton":
                    Process.Start("teens\\level_3\\Jobs\\jobs.ppt");
                    break;
                case "jobsAndProfessionsButton":
                    Process.Start("teens\\level_3\\Jobs\\jobsandprofessions.ppt");
                    break;
                case "careersButton":
                    Process.Start("teens\\level_3\\Jobs\\careers.ppt");
                    break;
                case "engineeringButton":
                    Process.Start("teens\\level_3\\Jobs\\Careers_in_Engineering_David_Jones.ppt");
                    break;
                case "majorsButton":
                    Process.Start("teens\\level_3\\Jobs\\MajorsandCareers.ppt");
                    break;
                default:
                    break;
            }
        }

       
    }
}
