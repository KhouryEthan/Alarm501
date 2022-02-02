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


        public uxMainWindow()
        {
            InitializeComponent();
            instance = this;
            uxAlarmList.FormattingEnabled = false;
            uxAlarmList.DataSource = MyAlarms;

            var myTimer = new System.Timers.Timer(1000);
            // Define the event handler
            myTimer.Elapsed += CheckAlarms;
            // Synchronize the timer with the text box
            myTimer.SynchronizingObject = this;
            // Start the timer
            myTimer.AutoReset = true;
            myTimer.Start();
        }

        private void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime curr = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            foreach (Alarm a in MyAlarms)
            {
                if (a.Toggle && TimeSpan.Compare(a.SetTime.TimeOfDay, curr.TimeOfDay) == 0)
                {
                    SignalAlarm(uxAlarmList.Items.IndexOf(a), a);
                }
            }
        }

        private void SignalAlarm(int i, Alarm a)
        {

        }





        //////////////////////////////////////////////////////////////////////////
        private BindingList<Alarm> MyAlarms = new BindingList<Alarm>();
        
        private void uxMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            Alarm a = new Alarm(dt);
            AlarmEditor alarmPicker = new AlarmEditor(false, a);
            DialogResult TimePickDialog = alarmPicker.ShowDialog();
        }


        public void addToList(Alarm a)
        {
            MyAlarms.Add(a);
            uxAlarmList.Refresh();

            uxEdit.Enabled = true;
        }

        private void uxAlarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //(uxAlarmList.SelectedItem as Alarm)
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            AlarmEditor alarmEditor = new AlarmEditor(true, (uxAlarmList.SelectedItem as Alarm));
            DialogResult EditorDialog = alarmEditor.ShowDialog();

        }
    }
}
