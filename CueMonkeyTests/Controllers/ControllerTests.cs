using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CueMonkey.Controllers;
using CueMonkey.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CueMonkeyTests.Controllers
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod()]
        public void SoundTest()
        {
            CueController test = new CueController(new List<Cue>());
            test.BeginPlayback("TestingAudio/man-scream-01.mp3");
            System.Threading.Thread.Sleep(3000);
        }
    }
}
