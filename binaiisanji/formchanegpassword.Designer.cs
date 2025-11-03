
namespace binaiisanji
{
    partial class formchanegpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formchanegpassword));
            this.tbxnewpassword = new System.Windows.Forms.TextBox();
            this.tbxreenterpassword = new System.Windows.Forms.TextBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.btnBackChangePassword = new System.Windows.Forms.Button();
            this.btnSavePassword = new System.Windows.Forms.Button();
            this.pbxPassChangeLgo = new System.Windows.Forms.PictureBox();
            this.cbxShowpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassChangeLgo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxnewpassword
            // 
            this.tbxnewpassword.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxnewpassword.Font = new System.Drawing.Font("B Roya", 15F);
            this.tbxnewpassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxnewpassword.Location = new System.Drawing.Point(538, 219);
            this.tbxnewpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxnewpassword.Name = "tbxnewpassword";
            this.tbxnewpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxnewpassword.Size = new System.Drawing.Size(382, 57);
            this.tbxnewpassword.TabIndex = 2;
            this.tbxnewpassword.Text = "  رمز عبور جدید ";
            this.tbxnewpassword.Enter += new System.EventHandler(this.tbxnewpassword_Enter);
            this.tbxnewpassword.Leave += new System.EventHandler(this.tbxnewpassword_Leave);
            // 
            // tbxreenterpassword
            // 
            this.tbxreenterpassword.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxreenterpassword.Font = new System.Drawing.Font("B Roya", 15F);
            this.tbxreenterpassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxreenterpassword.Location = new System.Drawing.Point(538, 331);
            this.tbxreenterpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxreenterpassword.Name = "tbxreenterpassword";
            this.tbxreenterpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxreenterpassword.Size = new System.Drawing.Size(382, 57);
            this.tbxreenterpassword.TabIndex = 4;
            this.tbxreenterpassword.Text = "  تکرار رمز عبور جدید ";
            this.tbxreenterpassword.Enter += new System.EventHandler(this.tbxreenterpassword_Enter);
            this.tbxreenterpassword.Leave += new System.EventHandler(this.tbxreenterpassword_Leave);
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblChangePassword.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChangePassword.Location = new System.Drawing.Point(792, 32);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(182, 53);
            this.lblChangePassword.TabIndex = 17;
            this.lblChangePassword.Text = "تغییر رمز عبور ";
            this.lblChangePassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBackChangePassword
            // 
            this.btnBackChangePassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackChangePassword.FlatAppearance.BorderSize = 2;
            this.btnBackChangePassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackChangePassword.ForeColor = System.Drawing.Color.Ivory;
            this.btnBackChangePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackChangePassword.Location = new System.Drawing.Point(788, 588);
            this.btnBackChangePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackChangePassword.Name = "btnBackChangePassword";
            this.btnBackChangePassword.Size = new System.Drawing.Size(161, 65);
            this.btnBackChangePassword.TabIndex = 62;
            this.btnBackChangePassword.Text = "بازگشت";
            this.btnBackChangePassword.UseVisualStyleBackColor = false;
            this.btnBackChangePassword.Click += new System.EventHandler(this.btnBackChangePassword_Click);
            // 
            // btnSavePassword
            // 
            this.btnSavePassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSavePassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnSavePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSavePassword.Location = new System.Drawing.Point(45, 588);
            this.btnSavePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePassword.Name = "btnSavePassword";
            this.btnSavePassword.Size = new System.Drawing.Size(161, 65);
            this.btnSavePassword.TabIndex = 63;
            this.btnSavePassword.Text = "ذخیره ";
            this.btnSavePassword.UseVisualStyleBackColor = false;
            this.btnSavePassword.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // pbxPassChangeLgo
            // 
            this.pbxPassChangeLgo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxPassChangeLgo.BackgroundImage")));
            this.pbxPassChangeLgo.Location = new System.Drawing.Point(30, 59);
            this.pbxPassChangeLgo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxPassChangeLgo.Name = "pbxPassChangeLgo";
            this.pbxPassChangeLgo.Size = new System.Drawing.Size(381, 450);
            this.pbxPassChangeLgo.TabIndex = 64;
            this.pbxPassChangeLgo.TabStop = false;
            // 
            // cbxShowpassword
            // 
            this.cbxShowpassword.AutoSize = true;
            this.cbxShowpassword.Font = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbxShowpassword.Location = new System.Drawing.Point(750, 414);
            this.cbxShowpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxShowpassword.Name = "cbxShowpassword";
            this.cbxShowpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxShowpassword.Size = new System.Drawing.Size(155, 39);
            this.cbxShowpassword.TabIndex = 65;
            this.cbxShowpassword.Text = "نمایش رمز عبور ";
            this.cbxShowpassword.UseVisualStyleBackColor = true;
            this.cbxShowpassword.CheckedChanged += new System.EventHandler(this.cbxShowpassword_CheckedChanged);
            // 
            // formchanegpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(992, 691);
            this.Controls.Add(this.cbxShowpassword);
            this.Controls.Add(this.pbxPassChangeLgo);
            this.Controls.Add(this.btnSavePassword);
            this.Controls.Add(this.btnBackChangePassword);
            this.Controls.Add(this.lblChangePassword);
            this.Controls.Add(this.tbxreenterpassword);
            this.Controls.Add(this.tbxnewpassword);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formchanegpassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر رمز عبور ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formchanegpassword_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassChangeLgo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxnewpassword;
        private System.Windows.Forms.TextBox tbxreenterpassword;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Button btnBackChangePassword;
        private System.Windows.Forms.Button btnSavePassword;
        private System.Windows.Forms.PictureBox pbxPassChangeLgo;
        private System.Windows.Forms.CheckBox cbxShowpassword;
    }
}