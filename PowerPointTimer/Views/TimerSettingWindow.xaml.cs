using System.Windows;
using PowerPointTimer.ViewModels;

namespace PowerPointTimer.Views
{
    /// <summary>
    /// Interaction logic for TimerSettingWindow.xaml
    /// </summary>
    public partial class TimerSettingWindow : Window
    {
        public TimerSettingWindow()
        {
            InitializeComponent();
            DataContext = new TimerSettingWindowViewModel(this);
        }
    }
}
