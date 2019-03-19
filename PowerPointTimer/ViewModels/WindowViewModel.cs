using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using PowerPointTimer.Commands;

namespace PowerPointTimer.ViewModels
{
    abstract class WindowViewModel : ViewModelBase
    {
        private readonly Window _window;
        private Dispatcher Dispatcher => _window.Dispatcher;

        public ICommand CloseCommand { get; }

        protected WindowViewModel(Window window)
        {
            _window = window;
            CloseCommand = new RelayCommand(() => _window.Close());
        }

        protected override bool SetProperty<T>(T newValue, ref T oldValue, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(newValue, oldValue))
                return false;
            oldValue = newValue;
            Dispatcher.Invoke(() => OnPropertyChanged(propertyName));
            return true;
        }
    }
}
