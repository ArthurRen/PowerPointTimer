using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using PowerPointTimer.Models;

namespace PowerPointTimer.ViewModels
{
    class TimerWindowViewModel : WindowViewModel , IAwareViewLoadedAndUnloaded
    {
        private static readonly TimeSpan Sec = TimeSpan.FromSeconds(1);
        private TimeSpan _leftTime;
        private bool _isWarning;
        private TimerSetting _timerSetting;
        private bool _closed;

        public TimeSpan LeftTime
        {
            get => _leftTime;
            set => SetProperty(value, ref _leftTime);
        }

        public bool IsWarning
        {
            get => _isWarning;
            set => SetProperty(value, ref _isWarning);
        }

        public TimerSetting TimerSetting
        {
            get => _timerSetting;
            set => SetProperty(value, ref _timerSetting);
        }

        public TimerWindowViewModel(Window window) : base(window)
        {
            TimerSetting = TimerSetting.Instance;
            LeftTime = TimeSpan.FromSeconds(TimerSetting.DurationMinutes * 60 + TimerSetting.DurationMinutes);
        }

        private async Task StartCountingDown()
        {
            while (true)
            {
                if (_closed) return;
                LeftTime = LeftTime.Subtract(Sec);
                if (LeftTime.TotalMilliseconds < TimerSetting.AlarmSec)
                    IsWarning = true;
                await Task.Delay(1000);
            }
        }

        public async void ViewLoaded(object view) => await StartCountingDown();

        void IAwareViewLoadedAndUnloaded.ViewUnloaded(object view)
        {
            _closed = true;
            TimerLog.AddLog(LeftTime);
        }
    }
}
