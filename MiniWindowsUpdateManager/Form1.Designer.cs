namespace MiniWindowsUpdateManager
{
    partial class MiniWindowsUpdateManager
    {
        private System.ComponentModel.IContainer components = null;

    
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniWindowsUpdateManager));
            this.mainLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.applybutton = new System.Windows.Forms.Button();
            this.featureUpdateBox = new System.Windows.Forms.CheckBox();
            this.secondLabel = new System.Windows.Forms.Label();
            this.driverUpdateBox = new System.Windows.Forms.CheckBox();
            this.wuauservBox = new System.Windows.Forms.CheckBox();
            this.doSvcBox = new System.Windows.Forms.CheckBox();
            this.bitsBox = new System.Windows.Forms.CheckBox();
            this.updateMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.ForeColor = System.Drawing.Color.White;
            this.mainLabel.Location = new System.Drawing.Point(17, 13);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(144, 13);
            this.mainLabel.TabIndex = 0;
            this.mainLabel.Text = "Delay Windows Update until:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(212, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Advanced";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 32);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // applybutton
            // 
            this.applybutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.applybutton.FlatAppearance.BorderSize = 0;
            this.applybutton.ForeColor = System.Drawing.Color.White;
            this.applybutton.Location = new System.Drawing.Point(18, 203);
            this.applybutton.Name = "applybutton";
            this.applybutton.Size = new System.Drawing.Size(269, 23);
            this.applybutton.TabIndex = 7;
            this.applybutton.Text = "Apply";
            this.applybutton.UseVisualStyleBackColor = false;
            this.applybutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // featureUpdateBox
            // 
            this.featureUpdateBox.AutoSize = true;
            this.featureUpdateBox.ForeColor = System.Drawing.Color.White;
            this.featureUpdateBox.Location = new System.Drawing.Point(18, 314);
            this.featureUpdateBox.Name = "featureUpdateBox";
            this.featureUpdateBox.Size = new System.Drawing.Size(130, 17);
            this.featureUpdateBox.TabIndex = 9;
            this.featureUpdateBox.Text = "Block Feature Update";
            this.featureUpdateBox.UseVisualStyleBackColor = true;
            this.featureUpdateBox.CheckedChanged += new System.EventHandler(this.featureUpdateBox_CheckedChanged);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.ForeColor = System.Drawing.Color.White;
            this.secondLabel.Location = new System.Drawing.Point(15, 262);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(58, 13);
            this.secondLabel.TabIndex = 13;
            this.secondLabel.Text = "WU mode:";
            // 
            // driverUpdateBox
            // 
            this.driverUpdateBox.AutoSize = true;
            this.driverUpdateBox.ForeColor = System.Drawing.Color.White;
            this.driverUpdateBox.Location = new System.Drawing.Point(18, 337);
            this.driverUpdateBox.Name = "driverUpdateBox";
            this.driverUpdateBox.Size = new System.Drawing.Size(122, 17);
            this.driverUpdateBox.TabIndex = 15;
            this.driverUpdateBox.Text = "Block Driver Update";
            this.driverUpdateBox.UseVisualStyleBackColor = true;
            this.driverUpdateBox.CheckedChanged += new System.EventHandler(this.driverUpdateBox_CheckedChanged);
            // 
            // wuauservBox
            // 
            this.wuauservBox.AutoSize = true;
            this.wuauservBox.ForeColor = System.Drawing.Color.White;
            this.wuauservBox.Location = new System.Drawing.Point(18, 360);
            this.wuauservBox.Name = "wuauservBox";
            this.wuauservBox.Size = new System.Drawing.Size(188, 17);
            this.wuauservBox.TabIndex = 16;
            this.wuauservBox.Text = "Block System Service \"wuauserv\"";
            this.wuauservBox.UseVisualStyleBackColor = true;
            this.wuauservBox.CheckedChanged += new System.EventHandler(this.wuauservBox_CheckedChanged);
            // 
            // doSvcBox
            // 
            this.doSvcBox.AutoSize = true;
            this.doSvcBox.ForeColor = System.Drawing.Color.White;
            this.doSvcBox.Location = new System.Drawing.Point(18, 383);
            this.doSvcBox.Name = "doSvcBox";
            this.doSvcBox.Size = new System.Drawing.Size(175, 17);
            this.doSvcBox.TabIndex = 17;
            this.doSvcBox.Text = "Block System Service \"DoSvc\"";
            this.doSvcBox.UseVisualStyleBackColor = true;
            this.doSvcBox.CheckedChanged += new System.EventHandler(this.doSvcBox_CheckedChanged);
            // 
            // bitsBox
            // 
            this.bitsBox.AutoSize = true;
            this.bitsBox.ForeColor = System.Drawing.Color.White;
            this.bitsBox.Location = new System.Drawing.Point(18, 406);
            this.bitsBox.Name = "bitsBox";
            this.bitsBox.Size = new System.Drawing.Size(166, 17);
            this.bitsBox.TabIndex = 18;
            this.bitsBox.Text = "Block System Service \"BITS\"";
            this.bitsBox.UseVisualStyleBackColor = true;
            this.bitsBox.CheckedChanged += new System.EventHandler(this.bitsBox_CheckedChanged);
            // 
            // updateMode
            // 
            this.updateMode.BackColor = System.Drawing.Color.Black;
            this.updateMode.ForeColor = System.Drawing.Color.White;
            this.updateMode.FormattingEnabled = true;
            this.updateMode.Items.AddRange(new object[] {
            "Never check for updates",
            "Notify before downloading and installing",
            "Automatically download and notify for installation",
            "Automatically download and install at a scheduled time",
            "Required automatic updates (Windows Enterprise)"});
            this.updateMode.Location = new System.Drawing.Point(18, 278);
            this.updateMode.Name = "updateMode";
            this.updateMode.Size = new System.Drawing.Size(267, 21);
            this.updateMode.TabIndex = 19;
            this.updateMode.SelectedIndexChanged += new System.EventHandler(this.updateMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label1.Location = new System.Drawing.Point(171, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Created by NiordFresh <3";
            // 
            // MiniWindowsUpdateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(304, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateMode);
            this.Controls.Add(this.bitsBox);
            this.Controls.Add(this.doSvcBox);
            this.Controls.Add(this.wuauservBox);
            this.Controls.Add(this.driverUpdateBox);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.featureUpdateBox);
            this.Controls.Add(this.applybutton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mainLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MiniWindowsUpdateManager";
            this.Text = "MiniWUManager";
            this.Load += new System.EventHandler(this.MiniWindowsUpdateManager_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.CheckBox featureUpdateBox;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.CheckBox driverUpdateBox;
        private System.Windows.Forms.CheckBox wuauservBox;
        private System.Windows.Forms.CheckBox doSvcBox;
        private System.Windows.Forms.CheckBox bitsBox;
        private System.Windows.Forms.ComboBox updateMode;
        private System.Windows.Forms.Label label1;
    }
}

