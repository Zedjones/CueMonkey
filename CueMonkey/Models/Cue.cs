using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueMonkey.Models
{

    class Cue
    {
        public string Name { get; set; }
        public double Number { get; set; }
        public string Notes { get; set; }
        public Cue Target { get; set; }

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

    }
}
