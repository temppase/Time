using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerApp
{
    internal class TimeSetups
    {
        public bool run = false;
        public TimeSpan swap = TimeSpan.Zero;
        public TimeSpan set = TimeSpan.Zero;
        // time = videon kesto... Määritys vielä harkittava 
        //                      jos ei ole tiedostoa käytössä
        //                      esim käyttäjä voisi myös syöttää...
        public TimeSpan time = TimeSpan.Zero;
        public TimeSpan settime = TimeSpan.Zero;
        public TimeSpan i = TimeSpan.FromMilliseconds(10);
        public TimeSpan a = TimeSpan.FromMilliseconds(-10);
        public TimeSpan m = TimeSpan.FromSeconds(1);
        public TimeSpan l = TimeSpan.FromSeconds(-1);
        public int tbValue = 0;
    }
}
