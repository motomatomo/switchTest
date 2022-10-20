using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class TimeRun : Form
    {
        public TimeRun()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            labTimer.Text = nowTime.ToString();
            CultureInfo ci = new CultureInfo("zh-tw");
            showWeek(ci);
            //TODO
            //labTimer.Text = $"{DateTime.Now.Hour:00}:{DateTime.Now.Minute}:{DateTime.Now.Second:00}\n";
        }

        private void showWeek(CultureInfo ci)
        {
            string DWName = ci.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            labWeek.Text = DWName;
        }

        private void TimeRun_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            string nowTime = DateTime.Now.ToShortDateString();
            CultureInfo ci = new CultureInfo("zh-tw");
            //string DWShortName = ci.DateTimeFormat.GetShortestDayName(DateTime.Today.DayOfWeek);
            //string DWName = ci.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            showWeek(ci);

            string full = "";

            full += $"{DateTime.Now.Hour:00}:{DateTime.Now.Minute}:{DateTime.Now.Second:00}\n";

            labTimer.Text = full.ToString();
            //labWeek.Text = $"{ DWName}";
        
            MessageBox.Show($"{DateTime.Today.ToString("yyyy/MM/dd")}");
            
        }

        private void labTimer_TextChanged(object sender, EventArgs e)
        {
        //    DateTime nowTime = DateTime.Now;
        //    labTimer.Text = nowTime.ToString();
        }
    }
}
