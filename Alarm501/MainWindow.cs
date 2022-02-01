using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class uxMainWindow : Form
    {
        public static uxMainWindow instance;
        public static ListBox listBox;

        public uxMainWindow()
        {
            InitializeComponent();
            instance = this;
            listBox = uxAlarmList;


            if (File.Exists("..\\..\\AlarmData.txt"))
            {
                StreamReader sr = new StreamReader("..\\..\\AlarmData.txt");
                while (!sr.EndOfStream)
                {
                    string[] alarmData = sr.ReadLine().Split(',');
                    bool running = alarmData[3] == "Running";
                    //alarmList.Add(new Alarm())
                    
                }
                sr.Close();
            }
            //set the listbox/View's datasource to be alarm list
            uxAlarmList.DataSource = _alarms;

            var myTimer = new System.Timers.Timer(1000);
            // Define the event handler
            myTimer.Elapsed += CheckAlarms;
            // Synchronize the timer with the text box
            myTimer.SynchronizingObject = this;
            // Start the timer
            myTimer.AutoReset = true;
            myTimer.Start();


            if (uxAlarmList.SelectedItems != null) uxEdit.Enabled = true;
            
        }

        private void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime curr = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //foreach (Alarm a in alarmList)
            //{
            //    if (a.Status == "Running" && TimeSpan.Compare(a.setTime.TimeOfDay, curr.TimeOfDay) == 0)
            //    {
            //        //SignalAlarm(uxAlarmList.Items.IndexOf(a));
            //    }
            //}
        }

        private void SignalAlarm()
        {
            
        }





        ////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Private backing variable for the alarms list
        /// </summary>
        private List<Alarm> _alarms = new List<Alarm>();
        
        /// <summary>
        /// Property that holds all alarms
        /// </summary>
        public List<Alarm> alarmList
        {
            get
            {
                return _alarms;
            }
            set
            {
                _alarms = value;
            }
        }


        
        private void uxMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            AlarmEditor alarmPicker = new AlarmEditor();
            DialogResult TimePickDialog = alarmPicker.ShowDialog();
        }


        public void addToList(Alarm a)
        {
            _alarms.Add(a);
            uxAlarmList.Refresh();


            //Need to add the alarm to the list with
            //uxAlarmList.Items.Add(alarm);

        }



        //Timer Implementation

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
    }
}
