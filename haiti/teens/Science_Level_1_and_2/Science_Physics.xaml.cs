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

namespace haiti.teens.Science_Level_1_and_2
{
    /// <summary>
    /// Interaction logic for Science_Physics.xaml
    /// </summary>
    public partial class Science_Physics : Page
    {
        public Science_Physics()
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
                case "atoms":
                    Process.Start("teens\\level_3\\Science\\Physics\\Atoms__Atomic_Structure.ppt");
                    break;
                case "electricity":
                    Process.Start("teens\\level_3\\Science\\Physics\\Basics_about_Electricity.ppt");
                    break;
                case "batteries":
                    Process.Start("teens\\level_3\\Science\\Physics\\Batteries.ppt");
                    break;
                case "electricSafety":
                    Process.Start("teens\\level_3\\Science\\Physics\\Electrical_safety.ppt");
                    break;
                case "forces":
                    Process.Start("teens\\level_3\\Science\\Physics\\Forces.ppt");
                    break;
                case "friction":
                    Process.Start("teens\\level_3\\Science\\Physics\\Friction.pdf");
                    break;
                case "gravity":
                    Process.Start("teens\\level_3\\Science\\Physics\\Gravity_Garvitational_Force_Newton.ppt");
                    break;
                case "magnetism":
                    Process.Start("teens\\level_3\\Science\\Physics\\Magnetism_Lesson_for_Kids.ppt");
                    break;
                case "solarSystem":
                    Process.Start("teens\\level_3\\Science\\Physics\\Our_Solar_System.ppt");
                    break;
                case "refraction":
                    Process.Start("teens\\level_3\\Science\\Physics\\Refraction.ppt");
                    break;
                case "machines":
                    Process.Start("teens\\level_3\\Science\\Physics\\Simple_Machines1.ppt");
                    break;
                default:
                    break;
            }
        }
    }
}
