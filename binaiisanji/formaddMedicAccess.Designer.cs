
namespace binaiisanji
{
    partial class formaddMedicAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaddMedicAccess));
            this.lblAddmedicAccess = new System.Windows.Forms.Label();
            this.tbxmedicFname = new System.Windows.Forms.TextBox();
            this.tbxmedicLname = new System.Windows.Forms.TextBox();
            this.tbxmedicAge = new System.Windows.Forms.TextBox();
            this.tbxmedicPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblmedicGender = new System.Windows.Forms.Label();
            this.rdbmedicGenderM = new System.Windows.Forms.RadioButton();
            this.rdbmedicGenderF = new System.Windows.Forms.RadioButton();
            this.btnBackAddmedicAccess = new System.Windows.Forms.Button();
            this.btnsavenewMedic = new System.Windows.Forms.Button();
            this.tbxmedicusername = new System.Windows.Forms.TextBox();
            this.tbxmedicPassword = new System.Windows.Forms.TextBox();
            this.tbxreenterpassword = new System.Windows.Forms.TextBox();
            this.cbxShowpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAddmedicAccess
            // 
            this.lblAddmedicAccess.AutoSize = true;
            this.lblAddmedicAccess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAddmedicAccess.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddmedicAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddmedicAccess.Location = new System.Drawing.Point(894, 44);
            this.lblAddmedicAccess.Name = "lblAddmedicAccess";
            this.lblAddmedicAccess.Size = new System.Drawing.Size(367, 60);
            this.lblAddmedicAccess.TabIndex = 26;
            this.lblAddmedicAccess.Text = "اضافه کردن دسترسی پزشک";
            this.lblAddmedicAccess.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxmedicFname
            // 
            this.tbxmedicFname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxmedicFname.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxmedicFname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxmedicFname.Location = new System.Drawing.Point(911, 225);
            this.tbxmedicFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxmedicFname.Name = "tbxmedicFname";
            this.tbxmedicFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxmedicFname.Size = new System.Drawing.Size(248, 57);
            this.tbxmedicFname.TabIndex = 29;
            this.tbxmedicFname.Text = "  نام  ";
            this.tbxmedicFname.Enter += new System.EventHandler(this.tbxmedicFname_Enter);
            this.tbxmedicFname.Leave += new System.EventHandler(this.tbxmedicFname_Leave);
            // 
            // tbxmedicLname
            // 
            this.tbxmedicLname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxmedicLname.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxmedicLname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxmedicLname.Location = new System.Drawing.Point(911, 338);
            this.tbxmedicLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxmedicLname.Name = "tbxmedicLname";
            this.tbxmedicLname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxmedicLname.Size = new System.Drawing.Size(248, 57);
            this.tbxmedicLname.TabIndex = 30;
            this.tbxmedicLname.Text = "  نام خانوادگی   ";
            this.tbxmedicLname.Enter += new System.EventHandler(this.tbxmedicLname_Enter);
            this.tbxmedicLname.Leave += new System.EventHandler(this.tbxmedicLname_Leave);
            // 
            // tbxmedicAge
            // 
            this.tbxmedicAge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxmedicAge.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxmedicAge.ForeColor = System.Drawing.Color.DimGray;
            this.tbxmedicAge.Location = new System.Drawing.Point(911, 450);
            this.tbxmedicAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxmedicAge.Name = "tbxmedicAge";
            this.tbxmedicAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxmedicAge.Size = new System.Drawing.Size(248, 57);
            this.tbxmedicAge.TabIndex = 31;
            this.tbxmedicAge.Text = "  سن";
            this.tbxmedicAge.Enter += new System.EventHandler(this.tbxmedicAge_Enter);
            this.tbxmedicAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxmedicAge_KeyPress);
            this.tbxmedicAge.Leave += new System.EventHandler(this.tbxmedicAge_Leave);
            // 
            // tbxmedicPhoneNumber
            // 
            this.tbxmedicPhoneNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxmedicPhoneNumber.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxmedicPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxmedicPhoneNumber.Location = new System.Drawing.Point(911, 562);
            this.tbxmedicPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxmedicPhoneNumber.Name = "tbxmedicPhoneNumber";
            this.tbxmedicPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxmedicPhoneNumber.Size = new System.Drawing.Size(250, 57);
            this.tbxmedicPhoneNumber.TabIndex = 32;
            this.tbxmedicPhoneNumber.Text = "  شماره تماس";
            this.tbxmedicPhoneNumber.Enter += new System.EventHandler(this.tbxmedicPhoneNumber_Enter);
            this.tbxmedicPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxmedicPhoneNumber_KeyPress);
            this.tbxmedicPhoneNumber.Leave += new System.EventHandler(this.tbxmedicPhoneNumber_Leave);
            // 
            // lblmedicGender
            // 
            this.lblmedicGender.AutoSize = true;
            this.lblmedicGender.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblmedicGender.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblmedicGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblmedicGender.Location = new System.Drawing.Point(748, 225);
            this.lblmedicGender.Name = "lblmedicGender";
            this.lblmedicGender.Size = new System.Drawing.Size(90, 46);
            this.lblmedicGender.TabIndex = 34;
            this.lblmedicGender.Text = "جنسیت";
            this.lblmedicGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdbmedicGenderM
            // 
            this.rdbmedicGenderM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rdbmedicGenderM.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold);
            this.rdbmedicGenderM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbmedicGenderM.Location = new System.Drawing.Point(748, 294);
            this.rdbmedicGenderM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbmedicGenderM.Name = "rdbmedicGenderM";
            this.rdbmedicGenderM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbmedicGenderM.Size = new System.Drawing.Size(84, 44);
            this.rdbmedicGenderM.TabIndex = 37;
            this.rdbmedicGenderM.TabStop = true;
            this.rdbmedicGenderM.Text = "مرد";
            this.rdbmedicGenderM.UseVisualStyleBackColor = false;
            // 
            // rdbmedicGenderF
            // 
            this.rdbmedicGenderF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rdbmedicGenderF.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold);
            this.rdbmedicGenderF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbmedicGenderF.Location = new System.Drawing.Point(748, 338);
            this.rdbmedicGenderF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbmedicGenderF.Name = "rdbmedicGenderF";
            this.rdbmedicGenderF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbmedicGenderF.Size = new System.Drawing.Size(84, 44);
            this.rdbmedicGenderF.TabIndex = 38;
            this.rdbmedicGenderF.TabStop = true;
            this.rdbmedicGenderF.Text = "زن";
            this.rdbmedicGenderF.UseVisualStyleBackColor = false;
            // 
            // btnBackAddmedicAccess
            // 
            this.btnBackAddmedicAccess.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackAddmedicAccess.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackAddmedicAccess.ForeColor = System.Drawing.Color.Snow;
            this.btnBackAddmedicAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackAddmedicAccess.Location = new System.Drawing.Point(1046, 750);
            this.btnBackAddmedicAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackAddmedicAccess.Name = "btnBackAddmedicAccess";
            this.btnBackAddmedicAccess.Size = new System.Drawing.Size(161, 65);
            this.btnBackAddmedicAccess.TabIndex = 39;
            this.btnBackAddmedicAccess.Text = "بازگشت";
            this.btnBackAddmedicAccess.UseVisualStyleBackColor = false;
            this.btnBackAddmedicAccess.Click += new System.EventHandler(this.btnBackAddmedicAccess_Click);
            // 
            // btnsavenewMedic
            // 
            this.btnsavenewMedic.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnsavenewMedic.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnsavenewMedic.ForeColor = System.Drawing.Color.Snow;
            this.btnsavenewMedic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsavenewMedic.Location = new System.Drawing.Point(45, 750);
            this.btnsavenewMedic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsavenewMedic.Name = "btnsavenewMedic";
            this.btnsavenewMedic.Size = new System.Drawing.Size(161, 65);
            this.btnsavenewMedic.TabIndex = 40;
            this.btnsavenewMedic.Text = "ذخیره ";
            this.btnsavenewMedic.UseVisualStyleBackColor = false;
            this.btnsavenewMedic.Click += new System.EventHandler(this.btnsavenewMedic_Click);
            // 
            // tbxmedicusername
            // 
            this.tbxmedicusername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxmedicusername.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxmedicusername.ForeColor = System.Drawing.Color.DimGray;
            this.tbxmedicusername.Location = new System.Drawing.Point(242, 225);
            this.tbxmedicusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxmedicusername.Name = "tbxmedicusername";
            this.tbxmedicusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxmedicusername.Size = new System.Drawing.Size(382, 57);
            this.tbxmedicusername.TabIndex = 41;
            this.tbxmedicusername.Text = "  نام کاربری  ";
            this.tbxmedicusername.Enter += new System.EventHandler(this.tbxmedicusername_Enter);
            this.tbxmedicusername.Leave += new System.EventHandler(this.tbxmedicusername_Leave);
            // 
            // tbxmedicPassword
            // 
            this.tbxmedicPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxmedicPassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxmedicPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxmedicPassword.Location = new System.Drawing.Point(242, 338);
            this.tbxmedicPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxmedicPassword.Name = "tbxmedicPassword";
            this.tbxmedicPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxmedicPassword.Size = new System.Drawing.Size(382, 57);
            this.tbxmedicPassword.TabIndex = 42;
            this.tbxmedicPassword.Text = "  رمز عبور ";
            this.tbxmedicPassword.Enter += new System.EventHandler(this.tbxmedicPassword_Enter);
            this.tbxmedicPassword.Leave += new System.EventHandler(this.tbxmedicPassword_Leave);
            // 
            // tbxreenterpassword
            // 
            this.tbxreenterpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxreenterpassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxreenterpassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbxreenterpassword.Location = new System.Drawing.Point(242, 450);
            this.tbxreenterpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxreenterpassword.Name = "tbxreenterpassword";
            this.tbxreenterpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxreenterpassword.Size = new System.Drawing.Size(382, 57);
            this.tbxreenterpassword.TabIndex = 43;
            this.tbxreenterpassword.Text = "  تکرار رمز عبور ";
            this.tbxreenterpassword.Enter += new System.EventHandler(this.tbxreenterpassword_Enter);
            this.tbxreenterpassword.Leave += new System.EventHandler(this.tbxreenterpassword_Leave);
            // 
            // cbxShowpassword
            // 
            this.cbxShowpassword.AutoSize = true;
            this.cbxShowpassword.Font = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbxShowpassword.Location = new System.Drawing.Point(461, 535);
            this.cbxShowpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxShowpassword.Name = "cbxShowpassword";
            this.cbxShowpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxShowpassword.Size = new System.Drawing.Size(155, 39);
            this.cbxShowpassword.TabIndex = 44;
            this.cbxShowpassword.Text = "نمایش رمز عبور ";
            this.cbxShowpassword.UseVisualStyleBackColor = true;
            this.cbxShowpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // formaddMedicAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1274, 879);
            this.Controls.Add(this.cbxShowpassword);
            this.Controls.Add(this.tbxreenterpassword);
            this.Controls.Add(this.tbxmedicPassword);
            this.Controls.Add(this.tbxmedicusername);
            this.Controls.Add(this.btnsavenewMedic);
            this.Controls.Add(this.btnBackAddmedicAccess);
            this.Controls.Add(this.rdbmedicGenderF);
            this.Controls.Add(this.rdbmedicGenderM);
            this.Controls.Add(this.lblmedicGender);
            this.Controls.Add(this.tbxmedicPhoneNumber);
            this.Controls.Add(this.tbxmedicAge);
            this.Controls.Add(this.tbxmedicLname);
            this.Controls.Add(this.tbxmedicFname);
            this.Controls.Add(this.lblAddmedicAccess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formaddMedicAccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن دسترسی پزشک ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formaddMedicAccess_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddmedicAccess;
        private System.Windows.Forms.TextBox tbxmedicFname;
        private System.Windows.Forms.TextBox tbxmedicLname;
        private System.Windows.Forms.TextBox tbxmedicAge;
        private System.Windows.Forms.TextBox tbxmedicPhoneNumber;
        private System.Windows.Forms.Label lblmedicGender;
        private System.Windows.Forms.RadioButton rdbmedicGenderM;
        private System.Windows.Forms.RadioButton rdbmedicGenderF;
        private System.Windows.Forms.Button btnBackAddmedicAccess;
        private System.Windows.Forms.Button btnsavenewMedic;
        private System.Windows.Forms.TextBox tbxmedicusername;
        internal System.Windows.Forms.TextBox tbxmedicPassword;
        internal System.Windows.Forms.TextBox tbxreenterpassword;
        private System.Windows.Forms.CheckBox cbxShowpassword;
    }
}