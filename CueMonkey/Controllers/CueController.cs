using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CueMonkey.Models;
using NAudio.Wave;

namespace CueMonkey.Controllers
{
    public class CueController
    {
        private List<CueMonkey.Models.Cue> Cues;

        public CueController(List<CueMonkey.Models.Cue> Cues) {
            this.Cues = Cues;
        }

        public void BeginPlayback(string filename) {
            WaveOutEvent player = new WaveOutEvent();
            Mp3FileReader reader = new Mp3FileReader(filename);
            player.Init(reader);
            player.Play();
        }

        public void ActivateCue(CueMonkey.Models.Cue Cue) {
            if (typeof(CueMonkey.Models.Cue) == typeof(AudioCue)) {
                BeginPlayback(((AudioCue)Cue).Source);
            }
        }
    }
}
