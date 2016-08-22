using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace clock
{
    public partial class frmClock : Form
    {

        public frmClock()
        {
            InitializeComponent();
            initControls();
            timer_Tick(null, null);
        }

        private void initControls()
        {
            cboxInterval.SelectedIndex = 3;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //update display every second
            lblTime.Text = System.DateTime.Now.ToString("t");
            lblDate.Text = System.DateTime.Now.ToString("D");

            //only update on the 00 sec
            int secTrigger;

            secTrigger = DateTime.Now.Second;
            if (secTrigger == 0) { updateControls(); }
            
        }

        private void updateControls()
        {

            if (chkSayTime.Checked == false) { return; }

            int interval;
            int.TryParse(cboxInterval.SelectedItem.ToString(), out interval);
            int minuteNow = DateTime.Now.Minute;

            if (interval == 60 & minuteNow == 0)

            {
                sayThis("the time is " + lblTime.Text);
            }
            else if (minuteNow % interval == 0)
            {
                sayThis("the time is " + lblTime.Text);
            }
        }

        private void sayThis(string whatToSay)
        {

            SpeechSynthesizer syn = new SpeechSynthesizer();

            syn.Volume = 100;  // 0...100
            syn.Rate = -2;     // -10...10

            // Synchronous
            //syn.Speak("Hello World");
            syn.Speak(whatToSay);

            // Asynchronous
            //syn.SpeakAsync(whatToSay);


        }

        private void chkOnTop_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = chkOnTop.Checked;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {

            sayThis("the time is " + lblTime.Text);
            sayThis("the date is " + lblDate.Text);

        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {

            try {
                if (Clipboard.GetText().Length > 0)

                    sayThis(Clipboard.GetText());

            }

            catch { }
        }
    }
}
