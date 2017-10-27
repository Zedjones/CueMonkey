using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CueMonkey.Models;

namespace CueMonkey.Controllers
{
    public class CueController
    {
        private List<Cue> Cues;

        public CueController(List<Cue> Cues) {
            this.Cues = Cues;
        }

        public void ActivateCue(Cue Cue) {

        }

    }
}
