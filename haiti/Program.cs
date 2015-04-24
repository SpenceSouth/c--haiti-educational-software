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
                var dr = MessageBox.Show("Sure", "Some Title", MessageBoxButton.YesNo);

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
            start("C:\\Olltwit\\Addition\\addition.exe", "installers/addition.exe");
        }

    }
}
