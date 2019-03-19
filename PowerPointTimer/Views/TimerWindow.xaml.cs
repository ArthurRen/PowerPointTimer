using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PowerPointTimer.Models;
using PowerPointTimer.ViewModels;

namespace PowerPointTimer.Views
{
    /// <summary>
    /// Interaction logic for TimerWindow.xaml
    /// </summary>
    public partial class TimerWindow : Window
    {
        public TimerWindow()
        {
            InitializeComponent();
            DataContext = new TimerWindowViewModel(this);
            if (DataContext is IAwareViewLoadedAndUnloaded iAwareViewLoadedAndUnloaded)
            {
                Loaded += (view, __) => iAwareViewLoadedAndUnloaded.ViewLoaded(view);
                Unloaded += (view, __) => iAwareViewLoadedAndUnloaded.ViewUnloaded(view);
            }
        }

        protected override void OnRenderSizeChanged(SizeChangedInfo sizeInfo)
        {
            base.OnRenderSizeChanged(sizeInfo);
            var screen = Screen.AllScreens[TimerSetting.Instance.ScreenIndex];
            Top = 0;
            Left = screen.WorkingArea.Left + screen.Bounds.Width - Width;
        }
    }
}
