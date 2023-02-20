using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
        }

        public static string time;
        private string hour, min, sec;


        private void button1_Click(object sender, EventArgs e)
        {
            hour = tbHour.Text;
            min = tbMins.Text;
            sec = tbSecs.Text;
            time = hour+":"+min+":"+sec;
            Close();
        }
    }
}
