using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace haiti
{
    class Program
    {

        //Decs

        private Program()
        {

        }

        private static void start(String url, String installation){

            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {

                String title = "Installation Needed";
                String prompt = "It appears you are missing some necessary files required to run this program.  Would you like to install them?";

                var dr = MessageBox.Show(prompt, title, MessageBoxButton.YesNo);

                if (dr == MessageBoxResult.Yes)
                {
                    Process.Start(installation);
                }
                else
                {
                    //Do Nothing
                }
            }
        }

        public static void runOlliwitAddition()
        {
            start("C:\\Olltwit\\Addition\\addition.exe", "installers\\addition.exe");
        }

    }
}
