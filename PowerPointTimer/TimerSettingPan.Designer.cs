namespace PowerPointTimer
{
    partial class TimerSettingPan
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.labelContainer = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.btnSetPosForecolor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.positiveForecolorDialog = new System.Windows.Forms.ColorDialog();
            this.backcolorDialog = new System.Windows.Forms.ColorDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.edtMin = new System.Windows.Forms.NumericUpDown();
            this.edtSec = new System.Windows.Forms.NumericUpDown();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetNegForeground = new System.Windows.Forms.Button();
            this.negativeForecolorDialog = new System.Windows.Forms.ColorDialog();
            this.edtAlarmSec = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gbPreview.SuspendLayout();
            this.labelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSec)).BeginInit();
            this.gbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtAlarmSec)).BeginInit();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPreview
            // 
            this.gbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPreview.Controls.Add(this.labelContainer);
            this.gbPreview.Location = new System.Drawing.Point(0, 146);
            this.gbPreview.Margin = new System.Windows.Forms.Padding(2);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Padding = new System.Windows.Forms.Padding(2);
            this.gbPreview.Size = new System.Drawing.Size(437, 110);
            this.gbPreview.TabIndex = 0;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "预览";
            // 
            // labelContainer
            // 
            this.labelContainer.AutoSize = true;
            this.labelContainer.Controls.Add(this.labelTime);
            this.labelContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelContainer.Location = new System.Drawing.Point(2, 16);
            this.labelContainer.Margin = new System.Windows.Forms.Padding(2);
            this.labelContainer.Name = "labelContainer";
            this.labelContainer.Size = new System.Drawing.Size(433, 56);
            this.labelContainer.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("SimSun", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(0, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(164, 56);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00";
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(2, 2);
            this.btnSetFont.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(88, 24);
            this.btnSetFont.TabIndex = 1;
            this.btnSetFont.Text = "设置字体";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // btnSetPosForecolor
            // 
            this.btnSetPosForecolor.BackColor = System.Drawing.Color.Black;
            this.btnSetPosForecolor.FlatAppearance.BorderSize = 0;
            this.btnSetPosForecolor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPosForecolor.Location = new System.Drawing.Point(96, 34);
            this.btnSetPosForecolor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetPosForecolor.Name = "btnSetPosForecolor";
            this.btnSetPosForecolor.Size = new System.Drawing.Size(22, 24);
            this.btnSetPosForecolor.TabIndex = 3;
            this.btnSetPosForecolor.UseVisualStyleBackColor = false;
            this.btnSetPosForecolor.Click += new System.EventHandler(this.btnSetForecolor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "定时时间：";
            // 
            // edtMin
            // 
            this.edtMin.Location = new System.Drawing.Point(72, 92);
            this.edtMin.Margin = new System.Windows.Forms.Padding(2);
            this.edtMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.edtMin.Name = "edtMin";
            this.edtMin.Size = new System.Drawing.Size(34, 21);
            this.edtMin.TabIndex = 14;
            this.edtMin.ValueChanged += new System.EventHandler(this.edtMin_ValueChanged);
            // 
            // edtSec
            // 
            this.edtSec.Location = new System.Drawing.Point(125, 92);
            this.edtSec.Margin = new System.Windows.Forms.Padding(2);
            this.edtSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.edtSec.Name = "edtSec";
            this.edtSec.Size = new System.Drawing.Size(34, 21);
            this.edtSec.TabIndex = 15;
            this.edtSec.ValueChanged += new System.EventHandler(this.edtSec_ValueChanged);
            // 
            // gbLog
            // 
            this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLog.Controls.Add(this.listLog);
            this.gbLog.Location = new System.Drawing.Point(0, 260);
            this.gbLog.Margin = new System.Windows.Forms.Padding(2);
            this.gbLog.Name = "gbLog";
            this.gbLog.Padding = new System.Windows.Forms.Padding(2);
            this.gbLog.Size = new System.Drawing.Size(439, 278);
            this.gbLog.TabIndex = 18;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "定时记录";
            // 
            // listLog
            // 
            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 12;
            this.listLog.Location = new System.Drawing.Point(2, 16);
            this.listLog.Margin = new System.Windows.Forms.Padding(2);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(435, 260);
            this.listLog.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "正常字体颜色：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "警告字体颜色：";
            // 
            // btnSetNegForeground
            // 
            this.btnSetNegForeground.BackColor = System.Drawing.Color.Black;
            this.btnSetNegForeground.FlatAppearance.BorderSize = 0;
            this.btnSetNegForeground.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetNegForeground.Location = new System.Drawing.Point(96, 65);
            this.btnSetNegForeground.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetNegForeground.Name = "btnSetNegForeground";
            this.btnSetNegForeground.Size = new System.Drawing.Size(22, 24);
            this.btnSetNegForeground.TabIndex = 20;
            this.btnSetNegForeground.UseVisualStyleBackColor = false;
            this.btnSetNegForeground.Click += new System.EventHandler(this.btnSetNegForeground_Click);
            // 
            // edtAlarmSec
            // 
            this.edtAlarmSec.Location = new System.Drawing.Point(102, 118);
            this.edtAlarmSec.Margin = new System.Windows.Forms.Padding(2);
            this.edtAlarmSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edtAlarmSec.Name = "edtAlarmSec";
            this.edtAlarmSec.Size = new System.Drawing.Size(34, 21);
            this.edtAlarmSec.TabIndex = 26;
            this.edtAlarmSec.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.edtAlarmSec.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 23;
            this.label5.Text = "警告时间（s）：";
            // 
            // panelSetting
            // 
            this.panelSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSetting.Controls.Add(this.btnSetFont);
            this.panelSetting.Controls.Add(this.edtAlarmSec);
            this.panelSetting.Controls.Add(this.gbPreview);
            this.panelSetting.Controls.Add(this.label5);
            this.panelSetting.Controls.Add(this.label2);
            this.panelSetting.Controls.Add(this.btnSetNegForeground);
            this.panelSetting.Controls.Add(this.btnSetPosForecolor);
            this.panelSetting.Controls.Add(this.label1);
            this.panelSetting.Controls.Add(this.label4);
            this.panelSetting.Controls.Add(this.gbLog);
            this.panelSetting.Controls.Add(this.label6);
            this.panelSetting.Controls.Add(this.edtSec);
            this.panelSetting.Controls.Add(this.edtMin);
            this.panelSetting.Location = new System.Drawing.Point(3, 36);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(439, 540);
            this.panelSetting.TabIndex = 27;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.Text = "打开定时器";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TimerSettingPan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panelSetting);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimerSettingPan";
            this.Size = new System.Drawing.Size(445, 576);
            this.gbPreview.ResumeLayout(false);
            this.gbPreview.PerformLayout();
            this.labelContainer.ResumeLayout(false);
            this.labelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtSec)).EndInit();
            this.gbLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edtAlarmSec)).EndInit();
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.Button btnSetPosForecolor;
        private System.Windows.Forms.Panel labelContainer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog positiveForecolorDialog;
        private System.Windows.Forms.ColorDialog backcolorDialog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown edtMin;
        private System.Windows.Forms.NumericUpDown edtSec;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetNegForeground;
        private System.Windows.Forms.ColorDialog negativeForecolorDialog;
        private System.Windows.Forms.NumericUpDown edtAlarmSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSetting;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
