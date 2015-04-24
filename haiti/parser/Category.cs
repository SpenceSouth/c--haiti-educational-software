using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haiti
{

    class Category
    {

        //Decs
        private string title;
        private List<Subject> subjects = new List<Subject>();
        private string image;

        public Category()
        {

        }

        public Category(string title)
        {
            this.title = title;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return title;
        }

        public int size()
        {
            return subjects.Count;
        }

        public Subject subject(int key)
        {
            return subjects.ElementAt(key);
        }

        public void addSubject(Subject subject)
        {
            subjects.Add(subject);
        }

        public List<Subject> getSubjects()
        {
            return subjects;
        }

        public void addImage(String image)
        {
            this.image = image;
        }

        public string getImage()
        {
            return image;
        }

    }
}
