using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alarm501
{
    public partial class AlarmEditor : Form
    {
        public static AlarmEditor instance;
        private bool IsEditing;
        private Alarm alarm;

        public AlarmEditor(bool e, Alarm a)
        {
            InitializeComponent();
            InitializeTimePick();
            instance = this;
            bool IsEditing = e;
            alarm = a;
            if (IsEditing)
            {
                uxToggle.Checked = alarm.Toggle;
                timePicker.Value = alarm.SetTime;

            }

        }




        private DateTimePicker _timePicker;

        public DateTimePicker timePicker
        {
            get { return _timePicker; }
            set {_timePicker = value;}
        }


        private void InitializeTimePick()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(20, 30);
            timePicker.Width = 150;
            timePicker.Height = 20;
            Controls.Add(timePicker);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (uxToggle.Checked) 
            //{
            //    isChecked = true;
            //}
            //else
            //{
            //    isChecked = false;
            //}
        }


        /// Sets alarm and adds it to the list
        private void uxSet_Click(object sender, EventArgs e)
        {  
                Alarm alarmToAdd = createAlarm();
                uxMainWindow.instance.addToList(alarmToAdd);
                Close();
        }

        private Alarm createAlarm()
        {
            DateTime currAlarmTime = timePicker.Value;
            Alarm a = new Alarm(timePicker.Value);
            a.SetTime = currAlarmTime;
            
            if (uxToggle.Checked)
            {
                a.Toggle = true;
            }
            else
            {
                a.Toggle = false;
            }

            return a;
        }

        /// <summary>
        /// Click event that causes form to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
