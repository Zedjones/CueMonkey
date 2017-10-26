using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CueMonkey.Models
{

    public class AudioCue : PlayCue
    {
        public string Source { get; set; }
        public TimeSpan Length { get; set; }


    }
}
