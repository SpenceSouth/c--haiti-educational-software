using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace haiti
{
    class Utils
    {
        //Decs

        public static bool Prompt(String title, String prompt)
        {
            var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

            if (dr0 == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }
        
        public static bool Prompt(String title, String prompt, int flag)
        {

            if(flag == 0){
                prompt += "\nWould you like to start this activity?";
            }
            if (flag == 1)
            {
                prompt += "\nWould you like to open this file?";
            }

            var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

            if (dr0 == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }
        public static void addImageToButton(Button b, String src)
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

        public static void addImageToButton(Button b, String src, String text)
        {

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(src, UriKind.RelativeOrAbsolute));

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.Margin = new Thickness(10);
            stackPnl.Children.Add(img);
            TextBlock t = new TextBlock();
            t.Text = text;
            //stackPnl.Children.Add(t);

            b.Content = stackPnl;
            b.Background = Brushes.White;

        }
    }
}
