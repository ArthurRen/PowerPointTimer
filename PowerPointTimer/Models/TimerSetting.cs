using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using PowerPointTimer.ViewModels;
using Brush = System.Windows.Media.Brush;
using Color = System.Windows.Media.Color;

namespace PowerPointTimer.Models
{
    class TimerSetting : ViewModelBase
    {
        private static readonly Lazy<TimerSetting> LazyInstance = new Lazy<TimerSetting>(() => new TimerSetting());
        public static TimerSetting Instance => LazyInstance.Value;

        private int _durationSecs;
        private int _durationMinutes;
        private Brush _normalForeground;
        private Color? _normalForeColor;
        private Color? _alarmForeColor;
        private Brush _alarmForeground;
        private int _fontSize;
        private int _alarmSec;
        private int _screenIndex;
        private int _screensCount;

        public int DurationSecs
        {
            get => _durationSecs;
            set => SetProperty(value, ref _durationSecs);
        }

        public int DurationMinutes
        {
            get => _durationMinutes;
            set => SetProperty(value, ref _durationMinutes);
        }

        public Color? NormalForeColor
        {
            get => _normalForeColor;
            set
            {
                if (SetProperty(value, ref _normalForeColor))
                    NormalForeground = new SolidColorBrush(value ?? Colors.Transparent);
            }
        }

        public Color? AlarmForeColor
        {
            get => _alarmForeColor;
            set
            {
                if (SetProperty(value, ref _alarmForeColor))
                    AlarmForeground = new SolidColorBrush(value ?? Colors.Transparent);
            }
        }

        public Brush NormalForeground
        {
            get => _normalForeground;
            set => SetProperty(value, ref _normalForeground);
        }

        public Brush AlarmForeground
        {
            get => _alarmForeground;
            set => SetProperty(value, ref _alarmForeground);
        }

        public int FontSize
        {
            get => _fontSize;
            set => SetProperty(value, ref _fontSize);
        }

        public int AlarmSec
        {
            get => _alarmSec;
            set => SetProperty(value, ref _alarmSec);
        }

        public int ScreenIndex
        {
            get => _screenIndex;
            set => SetProperty(value, ref _screenIndex);
        }

        public int ScreensCount
        {
            get => _screensCount;
            set => SetProperty(value, ref _screensCount);
        }
        

        private TimerSetting()
        {
            FontSize = 42;
            NormalForeColor = Colors.Blue;
            AlarmForeColor = Colors.Red;
            DurationMinutes = 5;
            DurationSecs = 0;
            AlarmSec = 2;
            ScreenIndex = 1;
            ScreensCount = Screen.AllScreens.Length;
        }
    }
}
