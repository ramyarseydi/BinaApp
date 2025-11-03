
namespace binaiisanji
{
    partial class formSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSetting));
            this.lblSetting = new System.Windows.Forms.Label();
            this.btnChangeUsername = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.btnBackSetting = new System.Windows.Forms.Button();
            this.pbxSettingLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettingLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSetting.Font = new System.Drawing.Font("B Roya", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSetting.Location = new System.Drawing.Point(980, 35);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(115, 55);
            this.lblSetting.TabIndex = 23;
            this.lblSetting.Text = "تنظیمات";
            this.lblSetting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnChangeUsername
            // 
            this.btnChangeUsername.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangeUsername.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChangeUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangeUsername.Location = new System.Drawing.Point(754, 181);
            this.btnChangeUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeUsername.Name = "btnChangeUsername";
            this.btnChangeUsername.Size = new System.Drawing.Size(257, 52);
            this.btnChangeUsername.TabIndex = 56;
            this.btnChangeUsername.Text = "تغییر نام کاربری ";
            this.btnChangeUsername.UseVisualStyleBackColor = false;
            this.btnChangeUsername.Click += new System.EventHandler(this.btnChangeUsername_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangePassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChangePassword.Location = new System.Drawing.Point(754, 304);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(257, 52);
            this.btnChangePassword.TabIndex = 58;
            this.btnChangePassword.Text = "تغییر رمز عبور  ";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // cmbFont
            // 
            this.cmbFont.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cmbFont.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbFont.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Items.AddRange(new object[] {
            "Arial",
            "B Roya",
            "B Nasim",
            "B yekan ",
            "Nastaliq"});
            this.cmbFont.Location = new System.Drawing.Point(754, 432);
            this.cmbFont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbFont.Size = new System.Drawing.Size(257, 46);
            this.cmbFont.TabIndex = 59;
            this.cmbFont.Text = "                    فونت  ";
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveSetting.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveSetting.Location = new System.Drawing.Point(60, 600);
            this.btnSaveSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(143, 52);
            this.btnSaveSetting.TabIndex = 60;
            this.btnSaveSetting.Text = "ذخیره";
            this.btnSaveSetting.UseVisualStyleBackColor = false;
            // 
            // btnBackSetting
            // 
            this.btnBackSetting.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackSetting.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackSetting.ForeColor = System.Drawing.SystemColors.Info;
            this.btnBackSetting.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackSetting.Location = new System.Drawing.Point(930, 600);
            this.btnBackSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackSetting.Name = "btnBackSetting";
            this.btnBackSetting.Size = new System.Drawing.Size(143, 52);
            this.btnBackSetting.TabIndex = 61;
            this.btnBackSetting.Text = "بازگشت";
            this.btnBackSetting.UseVisualStyleBackColor = false;
            this.btnBackSetting.Click += new System.EventHandler(this.btnBackSetting_Click);
            // 
            // pbxSettingLogo
            // 
            this.pbxSettingLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxSettingLogo.BackgroundImage")));
            this.pbxSettingLogo.Location = new System.Drawing.Point(79, 24);
            this.pbxSettingLogo.Name = "pbxSettingLogo";
            this.pbxSettingLogo.Size = new System.Drawing.Size(521, 524);
            this.pbxSettingLogo.TabIndex = 62;
            this.pbxSettingLogo.TabStop = false;
            this.pbxSettingLogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.pbxSettingLogo);
            this.Controls.Add(this.btnBackSetting);
            this.Controls.Add(this.btnSaveSetting);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnChangeUsername);
            this.Controls.Add(this.lblSetting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSetting_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formSetting_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettingLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Button btnChangeUsername;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.Button btnBackSetting;
        private System.Windows.Forms.PictureBox pbxSettingLogo;
    }
}