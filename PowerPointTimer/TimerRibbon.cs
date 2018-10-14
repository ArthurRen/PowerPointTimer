using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace PowerPointTimer
{
    public partial class TimerRibbon
    {

        private void btnOpenTimerSetting_Click(object sender, RibbonControlEventArgs e)
        {
            if (!ThisAddIn.SettingPan.Visible)
            {
                ThisAddIn.SettingPan.Visible = true;
            }
        }

        private void ckbOpenTimer_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.Enable = true;
        }
    }
}
