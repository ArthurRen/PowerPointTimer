using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PowerPointTimer
{
    public partial class LogForm : Form
    {
        private static readonly List<string> Logs = new List<string>();
        
        public static void AddLog(TimeSpan time)
        {
            Logs.Add(
                item: $"{Logs.Count + 1} : {time.Hours:d2}:{time.Minutes:d2}:{time.Seconds:d2}");
        }

        static LogForm()
        {
            for (int i = 0; i < 100; i++)
            {
                AddLog(TimeSpan.FromMinutes(i));
            }
        }

        public LogForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            listLog.Items.AddRange(Logs.Cast<object>().ToArray());
        }
    }
}
