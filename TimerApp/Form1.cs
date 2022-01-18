using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TimerApp
{
    public partial class Form1 : Form
    {
        TimeSetups TS = new TimeSetups();
        string[] MSet = { "Basic", "Hundredts", "Hours", "All" };
        string Mode = "";
        int[] TSet = {0,5,10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90 };
        double X = 1;
        int Mc = 0;
        int Hc = 0;
        string[] speed = { "Full", "Half", "Third", "Quater" };
        Regex rg = new Regex("^[0-9]+$");
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10;
            SetMode.DataSource = MSet;
            TimeSet.DataSource = TSet;
            SpeedSet.DataSource = speed;
            lblTimer.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            ActionClick();
        }
        private void ActionClick()
        {
            if (!TS.run)
            {
                Debug.WriteLine("Start");
                timer1.Start();
                TS.run = true;
                btnAct.Text = "II";
                btnAct.ForeColor = Color.LightBlue;
            }
            else
            {
                Debug.WriteLine("Stop");
                TS.run = false;
                timer1.Stop();
                btnAct.Text = ">";
                btnAct.ForeColor = Color.YellowGreen;
            }
        }
        private void Reset()
        {
            if (!Invert.Checked)
            {
                Debug.WriteLine("Stop and reset");
                timer1.Stop();
                TS.run = false;
                TS.swap = new TimeSpan();
                TS.set = new TimeSpan();
                lblTimer.Text = TS.set.ToString(Mode);
                btnAct.Text = ">";
                btnAct.ForeColor = Color.YellowGreen;
            }
            else
            {
                Debug.WriteLine("Stop and reset");
                timer1.Stop();
                TS.run = false;
                TS.swap = new TimeSpan();
                TS.set = TS.time;
                lblTimer.Text = TS.set.ToString(Mode);
                btnAct.Text = ">";
                btnAct.ForeColor = Color.YellowGreen;
            }
        }
        private void Show_CheckedChanged(object sender, EventArgs e)
        {
            if (!Show.Checked)
            {
                lblTimer.Text = "";
            }
            else
            {
                lblTimer.Text = TS.set.ToString(Mode);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Invert.Checked)
            { 
                TS.set += TS.swap.Add(TS.a * X);
                if (TS.set.ToString(Mode) == TimeSpan.Zero.ToString(Mode))
                {
                    timer1.Stop();
                    Reset();
                }
            }
            else
            {
                TS.set += TS.swap.Add(TS.i * X);
                if (TS.set.ToString(Mode) == TS.time.ToString(Mode))
                {
                    timer1.Stop();
                    Reset();
                }
            }
            
        }

        private void Invert_CheckedChanged(object sender, EventArgs e)
        {
            if (Invert.Checked)
            {
                lblTimer.Text = TS.time.ToString(Mode);
                TS.set = TS.time;
            }
            else
            {
                lblTimer.Text = TimeSpan.Zero.ToString(Mode);
                TS.set = TimeSpan.Zero;
            }
        }

        private void SetMode_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((string)SetMode.SelectedItem == MSet[0])
            {
                Mode = @"mm\:ss";
                lblTimer.Text = TS.set.ToString(Mode);
            }
            if ((string)SetMode.SelectedItem == MSet[1])
            {
                Mode = @"mm\:ss\.ff";
                lblTimer.Text = TS.set.ToString(Mode);
            }
            if ((string)SetMode.SelectedItem == MSet[2])
            {
                Mode = @"hh\:mm\:ss";
                lblTimer.Text = TS.set.ToString(Mode);
            }
            if ((string)SetMode.SelectedItem == MSet[3])
            {
                Mode = @"hh\:mm\:ss\.ff";
                lblTimer.Text = TS.set.ToString(Mode);
            }
        }

        private void TimeSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            TS.time = TS.settime.Add(new TimeSpan(0,0,(int)TimeSet.SelectedItem,0));
            if (Invert.Checked)
            {
                TS.set = TS.time;
                lblTimer.Text = TS.set.ToString(Mode);
            }
        }

        private void SpeedSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)SpeedSet.SelectedItem == speed[0])
            {
                X = 1;
                Debug.WriteLine(X);
            }
            if ((string)SpeedSet.SelectedItem == speed[1])
            {
                X = 1;
                X = X / 2;
                Debug.WriteLine(X);
            }
            if ((string)SpeedSet.SelectedItem == speed[2])
            {
                X = 1;
                X = X / 3;
                Debug.WriteLine(X);
            }
            if ((string)SpeedSet.SelectedItem == speed[3])
            {
                X = 1;
                X = X / 4;
                Debug.WriteLine(X);
            }
        }

        private void Less_Click(object sender, EventArgs e)
        {
            TS.time += TS.settime.Add(TS.l);
            if (Invert.Checked)
            {
                TS.set = TS.time;
                lblTimer.Text = TS.set.ToString(Mode);
            }
        }

        private void More_Click(object sender, EventArgs e)
        {
            TS.time += TS.settime.Add(TS.m);
            if (Invert.Checked)
            {
                TS.set = TS.time;
                lblTimer.Text = TS.set.ToString(Mode);
            }
        }

        private void Set_Click(object sender, EventArgs e)
        {
            TimeSpan v = new TimeSpan(0, 0, 0, 0 ,0);
            int H = 0;
            int M = 0;
            int S = 0;
            int F = 0;
            if (HH.Text != "" && HH.Text != "hh")
            {
                Debug.WriteLine(HH.Text);
                string h = HH.Text;
                H = int.Parse(h);
            }
            if (mm.Text != "" && mm.Text != "mm")
            {
                Debug.WriteLine(mm.Text);
                string m = mm.Text;
                M = int.Parse(m);
            }
            if (ss.Text != "" && ss.Text != "ss")
            {
                Debug.WriteLine(ss.Text);
                string s = ss.Text;
                S = int.Parse(s);
            }
            if (ff.Text != "" && ff.Text != "ff")
            {
                Debug.WriteLine(ff.Text);
                string f = ff.Text;
                F = int.Parse(f) *10;
            }
            v += new TimeSpan(0, H, M, S, F);
            Debug.WriteLine(v.ToString());
            TS.time = v;
            if (Invert.Checked)
            {
                TS.set = TS.time;
                lblTimer.Text = TS.set.ToString(Mode);
            }
        }

        private void mm_TextChanged(object sender, EventArgs e)
        {
            Mc = 0;
            if (rg.IsMatch(mm.Text))
            {
                string m = mm.Text;
                Mc = int.Parse(m);
            }
            else
            {
                mm.Text = "NaN";
            }
            if (Mc > 60)
            {
                if (rg.IsMatch(HH.Text))
                {
                    string h = HH.Text;
                    Hc = int.Parse(h);
                    mm.Text = (Hc + Mc / 60).ToString();
                    ss.Text = (Mc % 60).ToString();
                }
                else
                {
                    mm.Text = (Mc / 60).ToString();
                    ss.Text = (Mc % 60).ToString();
                }
            }
        }

        private void ss_TextChanged(object sender, EventArgs e)
        {
            int S = 0;
            if (rg.IsMatch(ss.Text))
            {
                string s = ss.Text;
                S = int.Parse(s);
            }
            else
            {
                ss.Text = "NaN";
            }
            if (S > 60)
            {
                if (rg.IsMatch(mm.Text))
                {
                    mm.Text = (Mc + S / 60).ToString();
                    ss.Text = (S % 60).ToString();
                }
                else
                {
                    mm.Text = (S / 60).ToString();
                    ss.Text = (S % 60).ToString();
                }
            }
        }
    }
}