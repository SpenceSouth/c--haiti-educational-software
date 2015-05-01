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

namespace haiti.teens.Science_Level_3
{
    /// <summary>
    /// Interaction logic for Science_Anatomy.xaml
    /// </summary>
    public partial class Science_Anatomy : Page
    {
        public Science_Anatomy()
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
                case "humanBodyPDF":
                    if (Utils.Prompt("Description", "Physical systems: Skeletal, Muscular, Digestive, Circulatory, Respiratory, etc.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\Human Body-7th grade.pdf");
                    break;
                case "humanBodyPPT":
                    if (Utils.Prompt("Description", "Pictures and functions of major human organs.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\Human body.ppt");
                    break;
                case "circulationSystems":
                    if (Utils.Prompt("Description", "Learn about the circulation systems, organs and how it works.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\BIO_LE_BODY_SYSTEMS_CIRCULATORY_3.ppt");
                    break;
                case "cells":
                    if (Utils.Prompt("Description", "Learn about the cells and types of cells.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\BODY_SYSTEMS__CELLS.ppt");
                    break;
                case "partsOfACell":
                    if (Utils.Prompt("Description", "Introduction to the various parts of a cell.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\CELL_PARTS__THEORY.ppt");
                    break;
                case "circulatorySystem1":
                    if (Utils.Prompt("Description", "Learn about the circulatory system of the human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\CIRCULATORY1_2.PPT");
                    break;
                case "circulatorySystem2":
                    if (Utils.Prompt("Description", "Learn about the circulatory system of the human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\CIRCULATORY_2.PPT");
                    break;
                case "cAndR":
                    if (Utils.Prompt("Description", "Learn about the circulatory and respiratory systems of the human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\CIRCULATORY__RESPIRATORY.ppt");
                    break;
                case "dig3":
                    if (Utils.Prompt("Description", "Learn about the digestive system of the human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\DIGESTION_2.ppt");
                    break;
                case "dig2":
                    if (Utils.Prompt("Description", "Learn about the digestive systems of human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\DIGESTIVE1_2.PPT");
                    break;
                case "dig1":
                    if (Utils.Prompt("Description", "Learn about the digestive systems of human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\DIGESTIVE_2.ppt");
                    break;
                case "skeleton":
                    if (Utils.Prompt("Description", "Learn about the skeleton of human body.", 0))
                        Process.Start("teens\\level_3\\Science\\People\\SKELETAL_1.ppt");
                    break;
                default:
                    break;
            }
        }
    }
}