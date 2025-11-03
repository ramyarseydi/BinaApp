
namespace binaiisanji
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExite = new System.Windows.Forms.Button();
            this.pbxUserLogo = new System.Windows.Forms.PictureBox();
            this.pbxPassLogo = new System.Windows.Forms.PictureBox();
            this.btnStartFormFirst = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.cbxShowpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPassword.Font = new System.Drawing.Font("B Roya", 16F);
            this.tbxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPassword.Location = new System.Drawing.Point(608, 366);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPassword.Size = new System.Drawing.Size(340, 60);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.Text = "رمز عبور";
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(823, 479);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 42);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ورود";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExite
            // 
            this.btnExite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExite.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExite.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Bold);
            this.btnExite.ForeColor = System.Drawing.Color.White;
            this.btnExite.Location = new System.Drawing.Point(630, 479);
            this.btnExite.Name = "btnExite";
            this.btnExite.Size = new System.Drawing.Size(110, 42);
            this.btnExite.TabIndex = 3;
            this.btnExite.Text = "خروج";
            this.btnExite.UseVisualStyleBackColor = false;
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // pbxUserLogo
            // 
            this.pbxUserLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxUserLogo.Image")));
            this.pbxUserLogo.Location = new System.Drawing.Point(987, 267);
            this.pbxUserLogo.Name = "pbxUserLogo";
            this.pbxUserLogo.Size = new System.Drawing.Size(51, 54);
            this.pbxUserLogo.TabIndex = 8;
            this.pbxUserLogo.TabStop = false;
            // 
            // pbxPassLogo
            // 
            this.pbxPassLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxPassLogo.Image")));
            this.pbxPassLogo.Location = new System.Drawing.Point(987, 366);
            this.pbxPassLogo.Name = "pbxPassLogo";
            this.pbxPassLogo.Size = new System.Drawing.Size(51, 52);
            this.pbxPassLogo.TabIndex = 9;
            this.pbxPassLogo.TabStop = false;
            this.pbxPassLogo.Click += new System.EventHandler(this.pbxPassLogo_Click);
            // 
            // btnStartFormFirst
            // 
            this.btnStartFormFirst.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartFormFirst.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStartFormFirst.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Bold);
            this.btnStartFormFirst.ForeColor = System.Drawing.Color.White;
            this.btnStartFormFirst.Location = new System.Drawing.Point(698, 543);
            this.btnStartFormFirst.Name = "btnStartFormFirst";
            this.btnStartFormFirst.Size = new System.Drawing.Size(154, 46);
            this.btnStartFormFirst.TabIndex = 4;
            this.btnStartFormFirst.Text = "شروع مجدد ";
            this.btnStartFormFirst.UseVisualStyleBackColor = false;
            this.btnStartFormFirst.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // tbxUsername
            // 
            this.tbxUsername.AccessibleName = "tbxUsername";
            this.tbxUsername.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxUsername.Font = new System.Drawing.Font("B Roya", 16F);
            this.tbxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.tbxUsername.Location = new System.Drawing.Point(608, 269);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxUsername.Size = new System.Drawing.Size(340, 60);
            this.tbxUsername.TabIndex = 0;
            this.tbxUsername.Text = "نام کاربری";
            this.tbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter_1);
            this.tbxUsername.Leave += new System.EventHandler(this.tbxUsername_Leave);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(59, 62);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(399, 573);
            this.picBoxLogo.TabIndex = 10;
            this.picBoxLogo.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAppName.Font = new System.Drawing.Font("B Roya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAppName.Location = new System.Drawing.Point(638, 94);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(433, 66);
            this.lblAppName.TabIndex = 26;
            this.lblAppName.Text = "مدیریت کلینیک چشم پزشکی ";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblAppName.Click += new System.EventHandler(this.lblResptionMenu2_Click);
            // 
            // cbxShowpassword
            // 
            this.cbxShowpassword.AutoSize = true;
            this.cbxShowpassword.Font = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbxShowpassword.Location = new System.Drawing.Point(841, 433);
            this.cbxShowpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxShowpassword.Name = "cbxShowpassword";
            this.cbxShowpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxShowpassword.Size = new System.Drawing.Size(155, 39);
            this.cbxShowpassword.TabIndex = 66;
            this.cbxShowpassword.Text = "نمایش رمز عبور ";
            this.cbxShowpassword.UseVisualStyleBackColor = true;
            this.cbxShowpassword.CheckedChanged += new System.EventHandler(this.cbxShowpassword_CheckedChanged);
            // 
            // formLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CancelButton = this.btnExite;
            this.ClientSize = new System.Drawing.Size(1137, 703);
            this.Controls.Add(this.cbxShowpassword);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnStartFormFirst);
            this.Controls.Add(this.pbxPassLogo);
            this.Controls.Add(this.pbxUserLogo);
            this.Controls.Add(this.btnExite);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سامانه ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxUserLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExite;
        private System.Windows.Forms.PictureBox pbxUserLogo;
        private System.Windows.Forms.PictureBox pbxPassLogo;
        private System.Windows.Forms.Button btnStartFormFirst;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblAppName;
        public System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.CheckBox cbxShowpassword;
    }
}