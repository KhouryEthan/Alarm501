using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public class Alarm : AlarmEditor
    {
        //System.Timers.Timer timer;

        //private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        //{
        //    DateTime currentTime = DateTime.Now;

        //    if (currentTime.Hour == setTime.Hour && currentTime.Minute == setTime.Minute && currentTime.Second == setTime.Second)
        //    {
        //        timer.Stop();
        //        Status = "TIMER GOING OFF!";
                
        //        //Set off timer
        //    }
        //}


        public Alarm(DateTime t, String s)
        {
            DateTime setTime = t.ToLocalTime();
            String Status = s;
        }


        DateTime _setTime;
        bool _toggle;


        public int Minutes { get; set; }

        public int Hours { get; set; }

        public int Seconds { get; set; }


        DateTime currentTime { get { return DateTime.Now; } }

        public DateTime setTime
        {
            get { return _setTime; }
            set { _setTime = value; }
        }

        public String Status 
        {
            get;
            set;
        }

        public bool Toggle
        {
            get { return _toggle; }
            set { _toggle = value;  }
        }

        public String AlarmDisplay 
        {
            get
            {
                if (Toggle == true)
                {
                    return (setTime.TimeOfDay + "     On");

                }
                else
                {
                    return (setTime.TimeOfDay + "    Off");

                }
            }
        }
    }
}
