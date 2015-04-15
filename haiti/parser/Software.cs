using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haiti
{
    class Software
    {

        //Decs
        private string title;
        private string description;
        private string programLink;
        private string icon;

        public Software()
        {

        }

        public Software(string title)
        {
            this.title = title;
        }

        public Software(string title, string description)
        {
            this.title = title;
            this.description = description;
        }

        public Software(string title, string description, string programLink)
        {
            this.title = title;
            this.description = description;
            this.programLink = programLink;
        }

        public string getTitle()
        {
            return title;
        }

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public string getLink()
        {
            return programLink;
        }

        public void setLink(string link)
        {
            programLink = link;
        }

        public void setIcon(string icon)
        {
            this.icon = icon;
        }

        public string getIcon()
        {
            return icon;
        }

    }
}
