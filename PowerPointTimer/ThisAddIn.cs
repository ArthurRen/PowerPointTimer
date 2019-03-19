using PowerPointTimer.Models;
using PowerPointTimer.Views;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;

namespace PowerPointTimer
{
    public partial class ThisAddIn
    {
        private TimerWindow _timerWindow;

        public static bool Enable { get; set; } = false;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.SlideShowBegin += Application_SlideShowBegin;
            Application.SlideShowEnd += Application_SlideShowEnd;
        }

        private void Application_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            if (!Enable) return;
            _timerWindow.Close();
        }

        private void Application_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            if (!Enable) return;
            _timerWindow = new TimerWindow();
            _timerWindow.GotFocus += (_, __) => Wn.Activate();
            _timerWindow.Topmost = true;
            _timerWindow.ShowActivated = true;
            _timerWindow.Show();
        }

        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon();
        }
        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
        }

        #endregion
    }
}
