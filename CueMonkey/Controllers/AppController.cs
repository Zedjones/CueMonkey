 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CueMonkey.Models;

namespace CueMonkey.Controllers
{
    public class AppController
    {
        private Project project;

        private CueController cueController;

        /// <summary>
        /// Constructor for new project
        /// </summary>
        public AppController() {
            project = new Project();
            cueController = new CueController(project.Cues);
        }


        public void SaveProject(string Destination) {
            //TODO
        }

        public void LoadProject(string Source) {
            //TODO
        }


    }
}
