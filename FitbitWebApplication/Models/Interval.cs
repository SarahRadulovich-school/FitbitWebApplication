using System;

namespace FitbitWebApplication.Models
{
    public class Interval
    {
        //using the Rate of Perceived Exertion scale
        public int RPE { get; set; }
        //message to tell user how hard to push (ex. Hard breathing, can only say one or two words, comfortable walk)
        public string Desc { get; set; }
        public int Secs { get; set; }

        public Interval(int rpe, string desc, int secs)
        {
            RPE = rpe;
            Desc = desc;
            Secs = secs;
        }
    }
}
