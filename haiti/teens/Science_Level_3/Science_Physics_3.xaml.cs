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
    /// Interaction logic for Science_Physics_3.xaml
    /// </summary>
    public partial class Science_Physics_3 : Page
    {
        public Science_Physics_3()
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
                    if (Utils.Prompt("Description", "Introduction to atomic structure.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Atoms__Atomic_Structure.ppt");
                    break;
                case "electricity":
                    if (Utils.Prompt("Description", "Basics About Electricity.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Basics_about_Electricity.ppt");
                    break;
                case "batteries":
                    if (Utils.Prompt("Description", "Introduction to batteries.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Batteries.ppt");
                    break;
                case "electricSafety":
                    if (Utils.Prompt("Description", "Introduction to electrical safety.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Electrical_safety.ppt");
                    break;
                case "forces":
                    if (Utils.Prompt("Description", "Introduction to forces.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Forces.ppt");
                    break;
                case "friction":
                    if (Utils.Prompt("Description", "Introduction to friction.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Friction.pdf");
                    break;
                case "gravity":
                    if (Utils.Prompt("Description", "Introduction to gravity.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Gravity_Garvitational_Force_Newton.ppt");
                    break;
                case "magnetism":
                    if (Utils.Prompt("Description", "Introduction to magnetism.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Magnetism_Lesson_for_Kids.ppt");
                    break;
                case "solarSystem":
                    if (Utils.Prompt("Description", "Introduction to our solar system.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Our_Solar_System.ppt");
                    break;
                case "refraction":
                    if (Utils.Prompt("Description", "Introduction to refraction.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Refraction.ppt");
                    break;
                case "machines":
                    if (Utils.Prompt("Description", "Introduction to simple machines.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\Simple_Machines1.ppt");
                    break;
                case "b1":
                    if (Utils.Prompt("Description", "Introduction to Atomic structure.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\ATOMIC_STRUCTURE.ppt");
                    break;
                case "b2":
                    if (Utils.Prompt("Description", "Introduction to Static Electricity in Atoms.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\ATOM__STATIC_ELECTRICITY.ppt");
                    break;
                case "b3":
                    if (Utils.Prompt("Description", "Introduction to Bhor Model of Atoms.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\BOHR_MODEL_OF_THE_ATOM.ppt");
                    break;
                case "b4":
                    if (Utils.Prompt("Description", "Introduction to Electricity.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\ELECTRICITY__2.ppt");
                    break;
                case "b5":
                    if (Utils.Prompt("Description", " Introduction to Green House Effect.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\ES_GREENHOUSE_EFFECT.ppt");
                    break;
                case "b6":
                    if (Utils.Prompt("Description", "Introduction to Minerals.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\ES_MINERALS.ppt");
                    break;
                case "b8":
                    if (Utils.Prompt("Description", "Introduction to Equilibrium Forces.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\FORCES__EQUILIBRIUM.ppt");
                    break;
                case "b9":
                    if (Utils.Prompt("Description", "Introduction to Gravity.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\FORCES_________GRAVITY.ppt");
                    break;
                case "b10":
                    if (Utils.Prompt("Description", "Introduction to Matter.", 0))
                        Process.Start("teens\\level_3\\Science\\Physics\\MATTER_INTRODUCTION__2.ppt");
                    break;
                default:
                    break;
            }
        }
    }
}
