namespace CSGO_CM_per_360Degree_Calculator_WF
{
    partial class MainForm
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
            this.DPILabel = new System.Windows.Forms.Label();
            this.WinSensiLabel = new System.Windows.Forms.Label();
            this.InGameSensiLabel = new System.Windows.Forms.Label();
            this.YawLabel = new System.Windows.Forms.Label();
            this.PitchLabel = new System.Windows.Forms.Label();
            this.DPITextBox = new System.Windows.Forms.TextBox();
            this.WinSensiCombobox = new System.Windows.Forms.ComboBox();
            this.InGameSensiTextbox = new System.Windows.Forms.TextBox();
            this.YawTextbox = new System.Windows.Forms.TextBox();
            this.PitchTextbox = new System.Windows.Forms.TextBox();
            this.RawInputCheckBox = new System.Windows.Forms.CheckBox();
            this.EffectiveDPILabel = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.EffectiveDPITextbox = new System.Windows.Forms.TextBox();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DPILabel
            // 
            this.DPILabel.AutoSize = true;
            this.DPILabel.Location = new System.Drawing.Point(267, 126);
            this.DPILabel.Name = "DPILabel";
            this.DPILabel.Size = new System.Drawing.Size(28, 12);
            this.DPILabel.TabIndex = 0;
            this.DPILabel.Text = "DPI:";
            // 
            // WinSensiLabel
            // 
            this.WinSensiLabel.AutoSize = true;
            this.WinSensiLabel.Location = new System.Drawing.Point(181, 94);
            this.WinSensiLabel.Name = "WinSensiLabel";
            this.WinSensiLabel.Size = new System.Drawing.Size(114, 12);
            this.WinSensiLabel.TabIndex = 1;
            this.WinSensiLabel.Text = "Window Sensitivity:";
            // 
            // InGameSensiLabel
            // 
            this.InGameSensiLabel.AutoSize = true;
            this.InGameSensiLabel.Location = new System.Drawing.Point(175, 162);
            this.InGameSensiLabel.Name = "InGameSensiLabel";
            this.InGameSensiLabel.Size = new System.Drawing.Size(120, 12);
            this.InGameSensiLabel.TabIndex = 2;
            this.InGameSensiLabel.Text = "In-Game Sensitivity:";
            // 
            // YawLabel
            // 
            this.YawLabel.AutoSize = true;
            this.YawLabel.Location = new System.Drawing.Point(245, 207);
            this.YawLabel.Name = "YawLabel";
            this.YawLabel.Size = new System.Drawing.Size(50, 12);
            this.YawLabel.TabIndex = 3;
            this.YawLabel.Text = "m_yaw:";
            // 
            // PitchLabel
            // 
            this.PitchLabel.AutoSize = true;
            this.PitchLabel.Location = new System.Drawing.Point(242, 249);
            this.PitchLabel.Name = "PitchLabel";
            this.PitchLabel.Size = new System.Drawing.Size(53, 12);
            this.PitchLabel.TabIndex = 4;
            this.PitchLabel.Text = "m_pitch:";
            // 
            // DPITextBox
            // 
            this.DPITextBox.Location = new System.Drawing.Point(301, 123);
            this.DPITextBox.MaxLength = 6;
            this.DPITextBox.Name = "DPITextBox";
            this.DPITextBox.Size = new System.Drawing.Size(145, 21);
            this.DPITextBox.TabIndex = 6;
            this.DPITextBox.Text = "0";
            this.DPITextBox.WordWrap = false;
            this.DPITextBox.TextChanged += new System.EventHandler(this.ValueChangedEvent);
            // 
            // WinSensiCombobox
            // 
            this.WinSensiCombobox.DisplayMember = "1,2,3,4,5,6,7,8,9,10,11";
            this.WinSensiCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WinSensiCombobox.FormattingEnabled = true;
            this.WinSensiCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.WinSensiCombobox.Location = new System.Drawing.Point(301, 91);
            this.WinSensiCombobox.Name = "WinSensiCombobox";
            this.WinSensiCombobox.Size = new System.Drawing.Size(145, 20);
            this.WinSensiCombobox.TabIndex = 7;
            this.WinSensiCombobox.SelectedIndexChanged += new System.EventHandler(this.ValueChangedEvent);
            // 
            // InGameSensiTextbox
            // 
            this.InGameSensiTextbox.Location = new System.Drawing.Point(301, 159);
            this.InGameSensiTextbox.MaxLength = 6;
            this.InGameSensiTextbox.Name = "InGameSensiTextbox";
            this.InGameSensiTextbox.Size = new System.Drawing.Size(145, 21);
            this.InGameSensiTextbox.TabIndex = 8;
            this.InGameSensiTextbox.Text = "0";
            this.InGameSensiTextbox.WordWrap = false;
            this.InGameSensiTextbox.TextChanged += new System.EventHandler(this.ValueChangedEvent);
            // 
            // YawTextbox
            // 
            this.YawTextbox.Location = new System.Drawing.Point(301, 204);
            this.YawTextbox.MaxLength = 6;
            this.YawTextbox.Name = "YawTextbox";
            this.YawTextbox.Size = new System.Drawing.Size(145, 21);
            this.YawTextbox.TabIndex = 9;
            this.YawTextbox.Text = "0";
            this.YawTextbox.WordWrap = false;
            this.YawTextbox.TextChanged += new System.EventHandler(this.ValueChangedEvent);
            // 
            // PitchTextbox
            // 
            this.PitchTextbox.Location = new System.Drawing.Point(301, 246);
            this.PitchTextbox.MaxLength = 6;
            this.PitchTextbox.Name = "PitchTextbox";
            this.PitchTextbox.Size = new System.Drawing.Size(145, 21);
            this.PitchTextbox.TabIndex = 10;
            this.PitchTextbox.Text = "0";
            this.PitchTextbox.WordWrap = false;
            this.PitchTextbox.TextChanged += new System.EventHandler(this.ValueChangedEvent);
            // 
            // RawInputCheckBox
            // 
            this.RawInputCheckBox.AutoSize = true;
            this.RawInputCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RawInputCheckBox.Checked = true;
            this.RawInputCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RawInputCheckBox.Location = new System.Drawing.Point(221, 287);
            this.RawInputCheckBox.Name = "RawInputCheckBox";
            this.RawInputCheckBox.Size = new System.Drawing.Size(93, 16);
            this.RawInputCheckBox.TabIndex = 11;
            this.RawInputCheckBox.Text = "m_rawinput:";
            this.RawInputCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RawInputCheckBox.UseVisualStyleBackColor = true;
            this.RawInputCheckBox.CheckedChanged += new System.EventHandler(this.ValueChangedEvent);
            // 
            // EffectiveDPILabel
            // 
            this.EffectiveDPILabel.AutoSize = true;
            this.EffectiveDPILabel.Location = new System.Drawing.Point(140, 371);
            this.EffectiveDPILabel.Name = "EffectiveDPILabel";
            this.EffectiveDPILabel.Size = new System.Drawing.Size(75, 12);
            this.EffectiveDPILabel.TabIndex = 12;
            this.EffectiveDPILabel.Text = "EffectiveDPI:";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(382, 371);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(72, 12);
            this.ResultLabel.TabIndex = 13;
            this.ResultLabel.Text = "Result(x,y):";
            // 
            // EffectiveDPITextbox
            // 
            this.EffectiveDPITextbox.Location = new System.Drawing.Point(221, 367);
            this.EffectiveDPITextbox.MaxLength = 1000;
            this.EffectiveDPITextbox.Name = "EffectiveDPITextbox";
            this.EffectiveDPITextbox.ReadOnly = true;
            this.EffectiveDPITextbox.Size = new System.Drawing.Size(145, 21);
            this.EffectiveDPITextbox.TabIndex = 14;
            this.EffectiveDPITextbox.Text = "0";
            this.EffectiveDPITextbox.WordWrap = false;
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(460, 367);
            this.ResultTextbox.MaxLength = 1000;
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.ReadOnly = true;
            this.ResultTextbox.Size = new System.Drawing.Size(192, 21);
            this.ResultTextbox.TabIndex = 15;
            this.ResultTextbox.Text = "(0,0) cm/360 °";
            this.ResultTextbox.WordWrap = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSGO_CM_per_360Degree_Calculator_WF.Properties.Resources.csgogo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(738, 482);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(722, 443);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.EffectiveDPITextbox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.EffectiveDPILabel);
            this.Controls.Add(this.RawInputCheckBox);
            this.Controls.Add(this.PitchTextbox);
            this.Controls.Add(this.YawTextbox);
            this.Controls.Add(this.InGameSensiTextbox);
            this.Controls.Add(this.WinSensiCombobox);
            this.Controls.Add(this.DPITextBox);
            this.Controls.Add(this.PitchLabel);
            this.Controls.Add(this.YawLabel);
            this.Controls.Add(this.InGameSensiLabel);
            this.Controls.Add(this.WinSensiLabel);
            this.Controls.Add(this.DPILabel);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(738, 482);
            this.Name = "MainForm";
            this.Opacity = 0.92D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CS:GO Calculate CM/360Degree";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DPILabel;
        private System.Windows.Forms.Label WinSensiLabel;
        private System.Windows.Forms.Label InGameSensiLabel;
        private System.Windows.Forms.Label YawLabel;
        private System.Windows.Forms.Label PitchLabel;
        private System.Windows.Forms.TextBox DPITextBox;
        private System.Windows.Forms.ComboBox WinSensiCombobox;
        private System.Windows.Forms.TextBox InGameSensiTextbox;
        private System.Windows.Forms.TextBox YawTextbox;
        private System.Windows.Forms.TextBox PitchTextbox;
        private System.Windows.Forms.CheckBox RawInputCheckBox;
        private System.Windows.Forms.Label EffectiveDPILabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox EffectiveDPITextbox;
        private System.Windows.Forms.TextBox ResultTextbox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

