using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using PowerPointTimer.Models;

namespace PowerPointTimer.ViewModels
{
    class TimerSettingWindowViewModel : WindowViewModel
    {
        private TimerSetting _timerSetting;

        public TimerSetting TimerSetting
        {
            get => _timerSetting;
            set => SetProperty(value, ref _timerSetting);
        }

        public TimerSettingWindowViewModel(Window window) : base(window)
        {
            TimerSetting = TimerSetting.Instance;
        }
    }
}
