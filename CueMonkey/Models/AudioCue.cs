using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CueMonkey.Models
{

    class AudioCue : Cue
    {
        public string Source { get; set; }
        public TimeSpan Length { get; set; }


    }
}
