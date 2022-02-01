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

        public AlarmEditor()
        {
            InitializeComponent();
            InitializeTimePick();
            instance = this;
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

        /// <summary>
        /// Sets alarm and adds it to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSet_Click(object sender, EventArgs e)
        {
            String time = timePicker.Value.ToString();
            Alarm alarmToAdd = createAlarm();
            uxMainWindow.instance.addToList(alarmToAdd);
            Close();
        }

        private Alarm createAlarm()
        {
            DateTime currAlarmTime = timePicker.Value;
            String timeValue = timePicker.Value.ToString();
            Alarm a = new Alarm(timePicker.Value);
            a.setTime = currAlarmTime;
            if (uxToggle.Checked) a.Toggle = true;
            else { a.Toggle = false; }
            

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
