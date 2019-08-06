﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorWOO.Pages
{
    public class ProjectsObj
    {
        public ProjectsObj(string usertitle, string usersubtitle, string userdescription)
        {
            Title = usertitle;
            Subtitle = usersubtitle;
            Description = userdescription;
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string subtitle;

        public string Subtitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}
