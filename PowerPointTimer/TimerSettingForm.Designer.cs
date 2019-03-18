namespace PowerPointTimer
{
    partial class TimerSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.timerSettingPan1 = new PowerPointTimer.TimerSettingPan();
            this.SuspendLayout();
            // 
            // timerSettingPan1
            // 
            this.timerSettingPan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timerSettingPan1.Location = new System.Drawing.Point(0, 0);
            this.timerSettingPan1.Margin = new System.Windows.Forms.Padding(2);
            this.timerSettingPan1.Name = "timerSettingPan1";
            this.timerSettingPan1.Size = new System.Drawing.Size(324, 266);
            this.timerSettingPan1.TabIndex = 0;
            // 
            // TimerSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 266);
            this.Controls.Add(this.timerSettingPan1);
            this.Name = "TimerSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时器设置";
            this.ResumeLayout(false);

        }

        #endregion

        private TimerSettingPan timerSettingPan1;
    }
}