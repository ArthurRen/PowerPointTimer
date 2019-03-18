namespace PowerPointTimer
{
    partial class TimerSettingRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TimerSettingRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.settingGroup = this.Factory.CreateRibbonGroup();
            this.ckbEnabled = this.Factory.CreateRibbonCheckBox();
            this.btnTimerSetting = this.Factory.CreateRibbonButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.logGroup = this.Factory.CreateRibbonGroup();
            this.btnViewLog = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.settingGroup.SuspendLayout();
            this.logGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.settingGroup);
            this.tab1.Groups.Add(this.logGroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // settingGroup
            // 
            this.settingGroup.Items.Add(this.ckbEnabled);
            this.settingGroup.Items.Add(this.btnTimerSetting);
            this.settingGroup.Label = "设置";
            this.settingGroup.Name = "settingGroup";
            // 
            // ckbEnabled
            // 
            this.ckbEnabled.Label = "打开定时器";
            this.ckbEnabled.Name = "ckbEnabled";
            this.ckbEnabled.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ckbEnabled_Click);
            // 
            // btnTimerSetting
            // 
            this.btnTimerSetting.Label = "定时器设置";
            this.btnTimerSetting.Name = "btnTimerSetting";
            this.btnTimerSetting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnTimerSetting_Click);
            // 
            // logGroup
            // 
            this.logGroup.Items.Add(this.btnViewLog);
            this.logGroup.Label = "定时记录";
            this.logGroup.Name = "logGroup";
            // 
            // btnViewLog
            // 
            this.btnViewLog.Label = "查看定时记录";
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnViewLog_Click);
            // 
            // TimerSettingRibbon
            // 
            this.Name = "TimerSettingRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.settingGroup.ResumeLayout(false);
            this.settingGroup.PerformLayout();
            this.logGroup.ResumeLayout(false);
            this.logGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup settingGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckbEnabled;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnTimerSetting;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup logGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnViewLog;
    }

    partial class ThisRibbonCollection
    {
        internal TimerSettingRibbon TimerSettingRibbon
        {
            get { return this.GetRibbon<TimerSettingRibbon>(); }
        }
    }
}
