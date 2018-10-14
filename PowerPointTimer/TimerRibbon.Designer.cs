namespace PowerPointTimer
{
    partial class TimerRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public TimerRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTimer = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnOpenTimerSetting = this.Factory.CreateRibbonButton();
            this.ckbOpenTimer = this.Factory.CreateRibbonCheckBox();
            this.tabTimer.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTimer
            // 
            this.tabTimer.Groups.Add(this.group1);
            this.tabTimer.Label = "定时器设置";
            this.tabTimer.Name = "tabTimer";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnOpenTimerSetting);
            this.group1.Items.Add(this.ckbOpenTimer);
            this.group1.Label = "设置";
            this.group1.Name = "group1";
            // 
            // btnOpenTimerSetting
            // 
            this.btnOpenTimerSetting.Label = "打开设置面板";
            this.btnOpenTimerSetting.Name = "btnOpenTimerSetting";
            this.btnOpenTimerSetting.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOpenTimerSetting_Click);
            // 
            // ckbOpenTimer
            // 
            this.ckbOpenTimer.Label = "使能定时器";
            this.ckbOpenTimer.Name = "ckbOpenTimer";
            this.ckbOpenTimer.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ckbOpenTimer_Click);
            // 
            // TimerRibbon
            // 
            this.Name = "TimerRibbon";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tabTimer);
            this.tabTimer.ResumeLayout(false);
            this.tabTimer.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tabTimer;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenTimerSetting;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ckbOpenTimer;
    }

    partial class ThisRibbonCollection
    {
        internal TimerRibbon Ribbon1
        {
            get { return this.GetRibbon<TimerRibbon>(); }
        }
    }
}
