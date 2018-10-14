using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;

namespace PowerPointTimer
{
    public partial class ThisAddIn
    {
        private TimerForm _timerForm = null;
        public static CustomTaskPane SettingPan { get; set; } = null;
        public static TimerSettingPan SettingPanel { get; set; } = null;

        public static bool Enable { get; set; } = false;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            Application.SlideShowBegin += Application_SlideShowBegin;
            Application.SlideShowEnd += Application_SlideShowEnd;
            SettingPanel = AddPan();
        }

        private TimerSettingPan AddPan()
        {
            var control = new TimerSettingPan();
            SettingPan = this.CustomTaskPanes.Add(control, "定时器设置");
            SettingPan.Visible = true;
            SettingPan.Width = control.Width;
            SettingPan.Visible = false;
            return control;
        }

        private void Application_SlideShowEnd(PowerPoint.Presentation Pres)
        {
            if (!Enable)
            {
                return;
            }
            _timerForm.StopTimer();
            _timerForm.Close();
            SettingPanel.AddLog(_timerForm.CurrentTime);
        }

        private void Application_SlideShowBegin(PowerPoint.SlideShowWindow Wn)
        {
            if (!Enable)
            {
                return;
            }
            _timerForm = CreateTimerForm();
            _timerForm.GotFocus += (_, __) =>
            {
                Wn.Activate();
            };
            _timerForm.TopMost = true;
            _timerForm.Show();
            _timerForm.StartTimer();
        }
        
        private TimerForm CreateTimerForm()
        {
            return new TimerForm();
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {

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
            this.Shutdown += ThisAddIn_Shutdown;
        }

        #endregion
    }
}
