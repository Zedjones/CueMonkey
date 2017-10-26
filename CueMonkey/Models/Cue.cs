using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueMonkey.Models
{

    public class Cue
    {
        public enum CueTypes {
            PLAY, STOP, PAUSE, GROUP, AUDIO
        };


        public string Name { get; set; }
        public double Number { get; set; }
        public string Notes { get; set; }
        public Cue Target { get; set; }

        public bool Selected;

        public Cue() {

        }

        public Cue(string Name) {
            this.Name = Name;
        }

        public Cue(string Name, double Number, string Notes, Cue Target) {
            this.Name = Name;
            this.Number = Number;
            this.Notes = Notes;
            this.Target = Target;
        }

        public void Select() {
            Selected = true;
        }

        public void Unselect()
        {
            Selected = false;
        }
    }
}
