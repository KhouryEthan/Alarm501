using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public class Alarm : INotifyPropertyChanged
    {
        ////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// INotifyPropertyChanged Implementation
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(s));

        //////////////////////////////////////////////////////////////////////
        private bool _IsSnoozed;
        DateTime _SetTime;
        bool _toggle;


        //Constructor
        public Alarm(DateTime t)
        {
            DateTime setTime = t;
        }


        public DateTime SetTime
        {
            get { return _SetTime; }
            set 
            { 
                  _SetTime = value; 
                  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SetTime")); 
            }
        }

        //What I want to populate ListBox
        public override string ToString()
        {
            if (Toggle)
            {
                return SetTime.ToString("hh:mm tt      ") + "       On"  ;
            }
            else
            {
                return SetTime.ToString("hh:mm tt      ") + "        Off";
            }
            
        }

        //Adds 3 Seconds if snoozed
        public bool IsSnoozed
        {
            get { return _IsSnoozed; }
            set
            {
                if (IsSnoozed)
                {
                    _IsSnoozed = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSnoozed"));
                }
            }
        }

        //      On/Off Function
        public bool Toggle
        {
            get { return _toggle; }
            set { _toggle = value;
                this.ToString();
            }
        }
    }
}
