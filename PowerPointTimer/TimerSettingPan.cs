using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;

namespace PowerPointTimer
{
    public partial class TimerSettingPan : UserControl
    {
        public TimerSettingPan()
        {
            InitializeComponent();

            // font
            labelTime.Font = TimerForm.TimeFont;
            fontDialog.Font = TimerForm.TimeFont;

            // foreground
            positiveForecolorDialog.Color = TimerForm.PositiveForeground;
            negativeForecolorDialog.Color = TimerForm.NegativeForeground;
            labelTime.ForeColor = TimerForm.PositiveForeground;
            btnSetPosForecolor.BackColor = TimerForm.PositiveForeground;
            btnSetNegForeground.BackColor = TimerForm.NegativeForeground;

            // time
            var time = TimerForm.TickTime;
            labelTime.Text =
                $"{time.Minutes:d2}:{time.Seconds:d2}";
            edtMin.Value = time.Minutes;
            edtSec.Value = time.Seconds;

            labelTime.BackColor = Color.Transparent;
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            fontDialog.Font = TimerForm.TimeFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                ApplyTimeFont(fontDialog.Font);
            }
        }
        
        private void ApplyTimeFont(System.Drawing.Font font)
        {
            labelTime.Font = font;
            TimerForm.TimeFont = font;
        }

        private void btnSetForecolor_Click(object sender, EventArgs e)
        {
            if (positiveForecolorDialog.ShowDialog() == DialogResult.OK)
            {
                ApplyPositiveForeground(positiveForecolorDialog.Color);
            }
        }

        private void ApplyPositiveForeground(Color color)
        {
            btnSetPosForecolor.BackColor = color;
            labelTime.ForeColor = color;
            TimerForm.PositiveForeground = color;
        }

        private void ApplyNegativeForeground(Color color)
        {
            btnSetNegForeground.BackColor = color;
            TimerForm.NegativeForeground = color;
        }

        private TimeSpan GetTime()
        {
            var min = (int)edtMin.Value;
            var sec = (int)edtSec.Value;
            return new TimeSpan(0, min, sec);
        }

        private void ApplyTime(TimeSpan time)
        {
            labelTime.Text =
                $"{time.Minutes:d2}:{time.Seconds:d2}";
            TimerForm.TickTime = time;
        }

        private void edtMin_ValueChanged(object sender, EventArgs e)
        {
            ApplyTime(GetTime());
        }

        private void edtSec_ValueChanged(object sender, EventArgs e)
        {
            ApplyTime(GetTime());
        }

        private void btnSetNegForeground_Click(object sender, EventArgs e)
        {
            if (negativeForecolorDialog.ShowDialog() == DialogResult.OK)
            {
                ApplyNegativeForeground(negativeForecolorDialog.Color);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            TimerForm.AlarmSec = (int)edtAlarmSec.Value;
        }
    }
}