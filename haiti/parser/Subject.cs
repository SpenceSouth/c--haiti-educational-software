using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haiti
{
    class Subject
    {

        //Decs
        private string title;
        private string grade;
        private List<Software> sw = new List<Software>();
        private string image;

        public Subject()
        {
            
        }

        public Subject(string title)
        {
            this.title = title;
        }

        public String getTitle()
        {
            return title;
        }

        public String getGrade()
        {
            return grade;
        }

        public void setGrade(String grade)
        {
            this.grade = grade;
        }

        public int size()
        {
            return sw.Count;
        }

        public Software software(int key)
        {
            return sw.ElementAt(key);
        }

        public void setImage(String image)
        {
            this.image = image;
        }

        public String getImage()
        {
            return image;
        }

        public void addSoftware(Software s)
        {
            sw.Add(s);
        }

    }

}
