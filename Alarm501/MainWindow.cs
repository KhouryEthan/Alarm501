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
    public partial class uxMainWindow : Form
    {
        public static uxMainWindow instance;
        public static ListView listView;

        public uxMainWindow()
        {
            InitializeComponent();
            instance = this;
            listView = uxAlarmList;
            uxSnooze.Enabled = false;
            uxStop.Enabled = false;
            uxEdit.Enabled = false;
        }

        /// <summary>
        /// Private backing variable for the alarms list
        /// </summary>
        private List<Alarm> _alarms;
        
        /// <summary>
        /// Property that holds all alarms
        /// </summary>
        public List<Alarm> Alarms
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

            var item = new ListViewItem(a.AlarmDisplay);
            uxAlarmList.Items.Add(item);
            uxAlarmList.Items.Add("Test Alarm");
            uxAlarmList.Refresh();


            //Need to add the alarm to the list with
            //uxAlarmList.Items.Add(alarm);

        }
    }
}
