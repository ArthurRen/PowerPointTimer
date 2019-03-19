using System.Windows;
using System.Windows.Forms;
using PowerPointTimer.ViewModels;

namespace PowerPointTimer.Views
{
    /// <summary>
    /// Interaction logic for LogWindow.xaml
    /// </summary>
    public partial class LogWindow : Window
    {
        public LogWindow()
        {
            InitializeComponent();
            DataContext = new LogWindowViewModel(this);
        }
    }
}
