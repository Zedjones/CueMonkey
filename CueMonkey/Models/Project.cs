using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueMonkey.Models
{
    public class Project
    {
        public string Title { get; set; }

        public Project() { }

        public Project(string Title) {
            this.Title = Title;

        }


    }
}
