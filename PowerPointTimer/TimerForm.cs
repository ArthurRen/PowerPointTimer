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
    public partial class TimerForm : Form
    {
        private static TimeSpan _tickTime = TimeSpan.FromMinutes(5);
        protected static event Action<TimeSpan> TickTimeChanged = null;
        public static TimeSpan TickTime
        {
            get => _tickTime;
            set
            {
                if(_tickTime != value)
                {
                    _tickTime = value;
                    TickTimeChanged?.Invoke(value);
                }
            }
        }

        private static Color _positiveForeground = Color.Black;
        protected static event Action<Color> PosotiveForegroundChanged = null;
        public static Color PositiveForeground
        {
            get => _positiveForeground; 
            set
            {
                if (_positiveForeground != value)
                {
                    _positiveForeground = value;
                    PosotiveForegroundChanged?.Invoke(value);
                }
            }
        }

        private static Color _negativeForeground = Color.Red;
        protected static event Action<Color> NegativeForegroundChanged = null;
        public static Color NegativeForeground
        {
            get => _negativeForeground;
            set
            {
                if (_negativeForeground != value)
                {
                    _negativeForeground = value;
                    NegativeForegroundChanged?.Invoke(value);
                }
            }
        }

        private static Font _timeFont = new System.Drawing.Font("微软雅黑", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        protected static event Action<Font> TimeFontChanged = null;
        public static Font TimeFont
        {
            get => _timeFont;
            set
            {
                if(_timeFont != value)
                {
                    _timeFont = value;
                    TimeFontChanged?.Invoke(value);
                }
            }
        }

        public static int AlarmSec { get; set; } = 2;

        private static TimeSpan _second = TimeSpan.FromSeconds(1);

        private System.Timers.Timer _timer = null;

        public TimeSpan CurrentTime { get; private set; }

        public TimerForm()
        {
            InitializeComponent();
            AdjustFormLocation();
            _timer = new System.Timers.Timer
            {
                Interval = 1000,
                AutoReset = true
            };
            _timer.Elapsed += (obj, arg) =>
            {
                CurrentTime = CurrentTime.Subtract(_second);
                var time = CurrentTime.Duration();
                var text =
                    $"{(CurrentTime.TotalSeconds < 0 ? "-" : "")}{time.Minutes.ToString("d2")}:{time.Seconds.ToString("d2")}";
                BeginInvoke(new Action(() =>
                {
                    labelTime.Text = text;
                }));
                // if time is positive and totalsec near AlarmSec , or time is negative and sec near alarmSec , start shinning
                var totalSec = CurrentTime.TotalSeconds;
                if ((totalSec <= AlarmSec && totalSec >= 0) ||
                    (totalSec < 0 && (60 - Math.Abs(CurrentTime.Seconds)) < AlarmSec))
                {
                    Console.WriteLine("begin shine");
                    BeginInvoke(new Action(() =>
                    {
                        StartShinning();
                        labelTime.ForeColor = NegativeForeground;
                    }));
                }
            };

            PosotiveForegroundChanged += foreground =>
            {
                labelTime.ForeColor = foreground;
            };
            TimeFontChanged += font => labelTime.Font = font;
            TickTimeChanged += time => CurrentTime = time;

            labelTime.ForeColor = PositiveForeground;
            labelTime.Font = TimeFont;
            labelTime.BackColor = Color.Transparent;
            
            BackColor = Color.FromArgb(255 ,1 ,1 , 1);
            TransparencyKey = BackColor;

            CurrentTime = TickTime;
        }

        public void StartTimer()
        {
            CurrentTime = TickTime;
            if (_timer.Enabled)
            {
                return;
            }
            _timer.Enabled = true;
        }

        public void StopTimer()
        {
            if (_timer.Enabled)
            {
                _timer.Enabled = false;
            }
        }

        private void labelTime_SizeChanged(object sender, EventArgs e)
        {
            if (!_isShining)
            {
                AdjustFormLocation();
            }
        }

        private void AdjustFormLocation()
        {
            this.Size = labelTime.Size;
            var resolution = Screen.GetBounds(labelTime);
            Left = resolution.Width - labelTime.Width;
            Top = 0;
        }

        private void labelTime_Click(object sender, EventArgs e)
        {
            if (_timer.Enabled)
            {
                YieldTimer();
            }
            else
            {
                ResumeTimer();
            }
        }

        private void ResumeTimer()
        {
            if (_timer.Enabled)
            {
                return;
            }
            _timer.Start();
        }

        private void YieldTimer()
        {
            if (_timer.Enabled)
            {
                _timer.Stop();
            }
        }

        private bool _isShining = false;
        private void StartShinning()
        {
            if (_isShining)
            {
                return;
            }
            _isShining = true;
            var resolution = Screen.GetBounds(labelTime);
            Left = (resolution.Width - Width) / 2;
            Top = (resolution.Height - Height) / 2;
            System.Timers.Timer timer = new System.Timers.Timer
            {
                Interval = 500,
                AutoReset = true , 
                Enabled = true
            };
            timer.Elapsed += (obj, e) =>
            {
                BeginInvoke(new Action(() =>
                {
                    if (CurrentTime.Seconds == 0)
                    {
                        labelTime.Visible = true;
                        AdjustFormLocation();
                        timer.Enabled = false;
                        _isShining = false;
                    }
                    else
                    {
                        labelTime.Visible = !labelTime.Visible;
                    }
                }));
            };
        }

        private void TimerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

            }
        }
    }
}
