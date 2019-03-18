using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace PowerPointTimer
{
    public partial class TimerSettingRibbon
    {
        private TimerSettingForm _settingForm;
        private LogForm _logForm;
        
        private void ckbEnabled_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void btnTimerSetting_Click(object sender, RibbonControlEventArgs e)
        {
            if (_settingForm == null || _settingForm.IsDisposed)
                _settingForm = new TimerSettingForm();
            _settingForm.ShowDialog();
        }

        private void btnViewLog_Click(object sender, RibbonControlEventArgs e)
        {
            if (_logForm == null || _logForm.IsDisposed)
                _logForm = new LogForm();
            _logForm.ShowDialog();
        }
    }
}
