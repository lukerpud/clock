using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
            buttonRed.FlatStyle = FlatStyle.Flat;
            buttonPink.FlatStyle = FlatStyle.Flat;
            buttonBlue.FlatStyle = FlatStyle.Flat;
            buttonGreen.FlatStyle = FlatStyle.Flat;
            script.FlatStyle = FlatStyle.Flat;
            sansButton.FlatStyle = FlatStyle.Flat;
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
            if(clockLabel.Text == Alarm.time)
            {
                MessageBox.Show("IT is now "+Alarm.time);
            }
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockLabel_MouseDown(object sender, MouseEventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("MMMM d,yyyy");
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Green;

        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;
        }

        private void buttonPink_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Pink;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;
        }

        private void script_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Segoe Print", 80, FontStyle.Regular);
        }

        private void sansButton_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Microsoft Sans Serif", 90, FontStyle.Regular);
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            Alarm alarm = new Alarm();
            alarm.Show();
        }
    }
}
