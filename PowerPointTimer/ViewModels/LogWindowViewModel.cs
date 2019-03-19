using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using PowerPointTimer.Commands;
using PowerPointTimer.Models;

namespace PowerPointTimer.ViewModels
{
    class LogWindowViewModel : WindowViewModel
    {
        private ObservableCollection<TimerLog> _logs;

        public ObservableCollection<TimerLog> Logs
        {
            get => _logs;
            set => SetProperty(value, ref _logs);
        }

        public ICommand ClearCommand { get; } 

        public LogWindowViewModel(Window window) : base(window)
        {
            Logs = new ObservableCollection<TimerLog>(TimerLog.Logs);
            ClearCommand = new RelayCommand(() =>
            {
                if (MessageBox.Show("是否确定清除所有记录？清除后无法恢复 ！", "提示" , MessageBoxButton.OKCancel) == MessageBoxResult.OK)
                {
                    TimerLog.ClearLogs();
                    Logs.Clear();
                }
            });
        }
    }
}
