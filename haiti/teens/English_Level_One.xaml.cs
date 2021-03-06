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
    /// Interaction logic for English_Level_One.xaml
    /// </summary>
    public partial class English_Level_One : Page
    {
        public English_Level_One()
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
                case "picGrammarButton":
                    if(Utils.Prompt("Description","Similar to Children Picture Dictionary",0))
                        Process.Start("teens\\level_3\\English\\picturegrammarforchildrenstarter.pdf");
                    break;
                case "illustratedDictionaryButton":
                    if (Utils.Prompt("Description", "Dictionary with many pictures.  Ideal for children.", 0))
                        Process.Start("teens\\level_3\\English\\childrensillustrateddictionary.pdf");
                    break;
                case "picDictionaryButton":
                    if (Utils.Prompt("Description", "Many illustrated scenes with pictures and spelling.  Also contains alphabet, numbers, weather, songs, and chants.", 0))
                        Process.Start("teens\\level_3\\English\\lyoungchildrenspicturedictionary.pdf");
                    break;
                case "englishGrammarButton":
                    if (Utils.Prompt("Description", "Lengthy book of parts of speech; Illustrated.", 0))
                        Process.Start("teens\\level_3\\English\\justenoughenglishgrammarillustrated.pdf");
                    break;
                default:
                    return;
            }

        }
    }
}
