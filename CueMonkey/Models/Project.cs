using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CueMonkey.Models
{
    public class Project
    {   
        // Default Values
        public static double DEFAULT_START_CUE = 1;


        //Member Variables
        public string Title { get; set; }
        public List<Cue> Cues;


        //Blank Constructor
        public Project() {
            Cues = new List<Cue>();
        }
        
        //Constructor of a New Project With a Title
        public Project(string Title) {
            this.Title = Title;
            Cues = new List<Cue>();
        }
        

        //Adds a cue to the list of cues
        private void AddCue(Cue cue) {
            Cues.Add(cue);
        }
           
        //Determine what the next number of a cue should be
        private double GetNextCueNumber() {
            if (!Cues.Any())
            {
                return DEFAULT_START_CUE;
            }
            else {
                Cue LastCue = Cues.Last();
                double LastNumber = LastCue.Number;

                return Math.Floor(LastNumber) + 1;
            }
        }
        
        //Creates a new cue and stores the information
        public void CreateNewCue(Cue.CueTypes CueType, [Optional]double target, [Optional]string Source){
            Cue NewCue;

            

            if (CueType.Equals(Cue.CueTypes.PLAY)) {
                NewCue = new PlayCue(CueType);
                NewCue.Number = GetNextCueNumber();
            }


        }
        


    }
}
