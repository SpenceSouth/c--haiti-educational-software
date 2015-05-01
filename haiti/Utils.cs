using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

            var dr0 = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

            if (dr0 == MessageBoxResult.Yes)
                return true;
            else
                return false;
        }
    }
}
