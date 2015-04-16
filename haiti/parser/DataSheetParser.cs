using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace haiti
{
    class DataSheetParser
    {

        //Decs
        private static List<Category> categories = new List<Category>();
        private static bool parsed = false;
        private static bool debug = false;

        private DataSheetParser()
        {

        }

        public static void parse(){

            //Gets all of the files in the folder to begin parsing
            string[] listOfFiles = Directory.GetFiles(@"C:\\UNF\\datasheets");

            foreach(string file in listOfFiles){
                Category category = extrapolateData(file);

                if(category != null){
                    categories.Add(category);
                }
            }

            parsed = true;
        }

        /**Gets the data out of each sudo-XML and adds it to the arraylist of categories */
        private static Category extrapolateData(string file){

            Category category = new Category();
            int subjectMarker = -1;
            int softwareMarker = -1;

            string[] lines = System.IO.File.ReadAllLines(file);

            foreach(string line in lines) {
                // process the line.

                if(line.Contains("<Category>")){
                    string[] title = line.Split(new string[] { ">" }, StringSplitOptions.None);
                    category.setTitle(title[1]);
                    if (debug) MessageBox.Show("Setting title of category to " + title[1]);

                }
                else if(line.Contains("<Subject>")){

                    subjectMarker++;
                    string[] title = line.Split(new string[] { ">" }, StringSplitOptions.None);
                    category.addSubject(new Subject(title[1]));
                    if (debug) MessageBox.Show("Adding subject " + title[1]);

                }
                else if (line.Contains("<Grade>"))
                {
                    string[] title = line.Split(new string[] { ">" }, StringSplitOptions.None);
                    category.subject(subjectMarker).setGrade(title[1]);
                    if (debug) MessageBox.Show("Setting " + category.subject(subjectMarker).getTitle() + " grade to " + title[1]);
                }
                else if(line.Contains("<Software>")){
                    softwareMarker++;
                    string[] title = line.Split(new string[] { ">" }, StringSplitOptions.None);
                    category.subject(subjectMarker).addSoftware(new Software(title[1]));
                    if (debug) MessageBox.Show("Adding software " + title[1] + " to subject " + category.subject(subjectMarker).getTitle());
                }
                else if (line.Contains("<Description>"))
                {
                    string[] title = line.Split(new string[] { ">" }, StringSplitOptions.None);
                    category.subject(subjectMarker).software(softwareMarker).setDescription(title[1]);
                }
                else if (line.Contains("<Link>"))
                {
                    string[] title = line.Split(new string[] { ">" }, StringSplitOptions.None);
                    category.subject(subjectMarker).software(softwareMarker).setLink(title[1]);
                }


            }

        return category;
    }

        public static List<Category> getCategories()
        {
            return categories;
        }

        public static int getSize()
        {
            return categories.Count;
        }

        public static bool hasBeenParsed()
        {
            return parsed;
        }

    }
}
