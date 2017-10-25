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
    }
}
