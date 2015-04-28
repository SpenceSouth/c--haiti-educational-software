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

        public static void runBookwormAdventure()
        {
            start("C:\\Program Files (x86)\\PopCap Games\\Bookworm Adventures Deluxe\\BookwormAdventures.exe", "installers\\BWASetup.exe");
        }

        public static void runTuxMath()
        {
            start("C:\\Program Files (x86)\\TuxMath\\TuxMath.exe", "installers\\tuxmath-2.0.2-win32-installer.exe");
        }
        public static void runTuxPaint()
        {
            start("C:\\Program Files (x86)\\TuxPaint\\TuxPaint.exe", "installers\\tuxpaint-0.9.22-win32-installer.exe");
        }
        public static void runTuxType()
        {
            start("C:\\Program Files (x86)\\TuxType\\TuxType.exe", "installers\\tuxtype-1.8.1-win32-installer.exe");
        }
        public static void runPeriodicTable()
        {
            start("C:\\Program Files (x86)\\freshney.org\\Periodic Table\\ADPT.exe", "installers\\ptinstaller.exe");
                //todo need .exe
        }
        public static void runSeTerra()
        {
            start("C:\\Program Files (x86)\\Seterra\\Seterra.exe", "installers\\seterra.exe");
        }

        public static void runEurope()
        {
            start("C:\\Program Files\\7Jag\\Europe!\\europewin.exe", "installers\\europe-setup.exe");
        }

        public static void runEducationalGames()
        {
            start("C:\\Program Files\\CrazySoft\\Smart Educational Games\\CrazySoft.exe", "installers\\SmartEg-Setup_Demo.exe");
        }

        public static void runKeaColor()
        {
            start("C:\\Program Files (x86)\\Kea\\ColoringBook\\ColoringBook4.exe", "installers\\dl41colorsetup.exe");
        }

        public static void runDrawForChild()
        {
            start("C:\\Program Files (x86)\\Drawing for Children\\Drawing.exe", "installers\\draw4ch2.exe");
        }

        public static void runMagicBook()
        {
            start("C:\\Program Files (x86)\\The MagicBook V7.5\\The MagicBook V7.5.exe", "installers\\tmb.exe");
        }

        public static void runCarsColor()
        {
            start("C:\\Program Files (x86)\\Cars 2 Color\\cars-2-color-game.exe", "installers\\cars-2-color-game.exe");
        }

    }
}
