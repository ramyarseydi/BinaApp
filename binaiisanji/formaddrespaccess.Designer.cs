
namespace binaiisanji
{
    partial class formaddrespaccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formaddrespaccess));
            this.lblAddresAccess = new System.Windows.Forms.Label();
            this.tbxrecFname = new System.Windows.Forms.TextBox();
            this.tbxrecLname = new System.Windows.Forms.TextBox();
            this.tbxrecAge = new System.Windows.Forms.TextBox();
            this.tbxrecPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblmedicGender = new System.Windows.Forms.Label();
            this.rdbresGenderM = new System.Windows.Forms.RadioButton();
            this.rdbresGenderF = new System.Windows.Forms.RadioButton();
            this.tbxresreenterpassword = new System.Windows.Forms.TextBox();
            this.tbxrecPassword = new System.Windows.Forms.TextBox();
            this.tbxrecusername = new System.Windows.Forms.TextBox();
            this.btnsavenewres = new System.Windows.Forms.Button();
            this.btnBackAddresAccess = new System.Windows.Forms.Button();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.cbxShowpassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblAddresAccess
            // 
            this.lblAddresAccess.AutoSize = true;
            this.lblAddresAccess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAddresAccess.Font = new System.Drawing.Font("B Roya", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddresAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAddresAccess.Location = new System.Drawing.Point(894, 44);
            this.lblAddresAccess.Name = "lblAddresAccess";
            this.lblAddresAccess.Size = new System.Drawing.Size(352, 60);
            this.lblAddresAccess.TabIndex = 27;
            this.lblAddresAccess.Text = "اضافه کردن دسترسی منشی";
            this.lblAddresAccess.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxrecFname
            // 
            this.tbxrecFname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxrecFname.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecFname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxrecFname.Location = new System.Drawing.Point(911, 225);
            this.tbxrecFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxrecFname.Name = "tbxrecFname";
            this.tbxrecFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecFname.Size = new System.Drawing.Size(248, 57);
            this.tbxrecFname.TabIndex = 30;
            this.tbxrecFname.Text = "  نام  ";
            this.tbxrecFname.Enter += new System.EventHandler(this.tbxrecFname_Enter);
            this.tbxrecFname.Leave += new System.EventHandler(this.tbxrecFname_Leave);
            // 
            // tbxrecLname
            // 
            this.tbxrecLname.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxrecLname.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecLname.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxrecLname.Location = new System.Drawing.Point(911, 338);
            this.tbxrecLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxrecLname.Name = "tbxrecLname";
            this.tbxrecLname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecLname.Size = new System.Drawing.Size(248, 57);
            this.tbxrecLname.TabIndex = 31;
            this.tbxrecLname.Text = "  نام خانوادگی   ";
            this.tbxrecLname.Enter += new System.EventHandler(this.tbxrecLname_Enter);
            this.tbxrecLname.Leave += new System.EventHandler(this.tbxrecLname_Leave);
            // 
            // tbxrecAge
            // 
            this.tbxrecAge.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxrecAge.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecAge.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxrecAge.Location = new System.Drawing.Point(911, 450);
            this.tbxrecAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxrecAge.Name = "tbxrecAge";
            this.tbxrecAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecAge.Size = new System.Drawing.Size(248, 57);
            this.tbxrecAge.TabIndex = 32;
            this.tbxrecAge.Text = "  سن";
            this.tbxrecAge.Enter += new System.EventHandler(this.tbxrecAge_Enter);
            this.tbxrecAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxrecAge_KeyPress);
            this.tbxrecAge.Leave += new System.EventHandler(this.tbxrecAge_Leave);
            // 
            // tbxrecPhoneNumber
            // 
            this.tbxrecPhoneNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxrecPhoneNumber.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxrecPhoneNumber.Location = new System.Drawing.Point(911, 562);
            this.tbxrecPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxrecPhoneNumber.Name = "tbxrecPhoneNumber";
            this.tbxrecPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecPhoneNumber.Size = new System.Drawing.Size(250, 57);
            this.tbxrecPhoneNumber.TabIndex = 33;
            this.tbxrecPhoneNumber.Text = "  شماره تماس";
            this.tbxrecPhoneNumber.Enter += new System.EventHandler(this.tbxrecPhoneNumber_Enter);
            this.tbxrecPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxrecPhoneNumber_KeyPress);
            this.tbxrecPhoneNumber.Leave += new System.EventHandler(this.tbxrecPhoneNumber_Leave);
            // 
            // lblmedicGender
            // 
            this.lblmedicGender.AutoSize = true;
            this.lblmedicGender.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblmedicGender.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblmedicGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblmedicGender.Location = new System.Drawing.Point(737, 225);
            this.lblmedicGender.Name = "lblmedicGender";
            this.lblmedicGender.Size = new System.Drawing.Size(90, 46);
            this.lblmedicGender.TabIndex = 35;
            this.lblmedicGender.Text = "جنسیت";
            this.lblmedicGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdbresGenderM
            // 
            this.rdbresGenderM.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rdbresGenderM.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold);
            this.rdbresGenderM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbresGenderM.Location = new System.Drawing.Point(737, 294);
            this.rdbresGenderM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbresGenderM.Name = "rdbresGenderM";
            this.rdbresGenderM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbresGenderM.Size = new System.Drawing.Size(84, 44);
            this.rdbresGenderM.TabIndex = 38;
            this.rdbresGenderM.TabStop = true;
            this.rdbresGenderM.Text = "مرد";
            this.rdbresGenderM.UseVisualStyleBackColor = false;
            // 
            // rdbresGenderF
            // 
            this.rdbresGenderF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rdbresGenderF.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold);
            this.rdbresGenderF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbresGenderF.Location = new System.Drawing.Point(737, 338);
            this.rdbresGenderF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbresGenderF.Name = "rdbresGenderF";
            this.rdbresGenderF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbresGenderF.Size = new System.Drawing.Size(84, 44);
            this.rdbresGenderF.TabIndex = 39;
            this.rdbresGenderF.TabStop = true;
            this.rdbresGenderF.Text = "زن";
            this.rdbresGenderF.UseVisualStyleBackColor = false;
            // 
            // tbxresreenterpassword
            // 
            this.tbxresreenterpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxresreenterpassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxresreenterpassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxresreenterpassword.Location = new System.Drawing.Point(242, 421);
            this.tbxresreenterpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxresreenterpassword.Name = "tbxresreenterpassword";
            this.tbxresreenterpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxresreenterpassword.Size = new System.Drawing.Size(382, 57);
            this.tbxresreenterpassword.TabIndex = 46;
            this.tbxresreenterpassword.Text = "  تکرار رمز عبور ";
            this.tbxresreenterpassword.Enter += new System.EventHandler(this.tbxresreenterpassword_Enter);
            this.tbxresreenterpassword.Leave += new System.EventHandler(this.tbxresreenterpassword_Leave);
            // 
            // tbxrecPassword
            // 
            this.tbxrecPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxrecPassword.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxrecPassword.Location = new System.Drawing.Point(242, 338);
            this.tbxrecPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxrecPassword.Name = "tbxrecPassword";
            this.tbxrecPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecPassword.Size = new System.Drawing.Size(382, 57);
            this.tbxrecPassword.TabIndex = 45;
            this.tbxrecPassword.Text = "  رمز عبور ";
            this.tbxrecPassword.Enter += new System.EventHandler(this.tbxrecPassword_Enter);
            this.tbxrecPassword.Leave += new System.EventHandler(this.tbxrecPassword_Leave);
            // 
            // tbxrecusername
            // 
            this.tbxrecusername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxrecusername.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecusername.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxrecusername.Location = new System.Drawing.Point(242, 225);
            this.tbxrecusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxrecusername.Name = "tbxrecusername";
            this.tbxrecusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecusername.Size = new System.Drawing.Size(382, 57);
            this.tbxrecusername.TabIndex = 44;
            this.tbxrecusername.Text = "  نام کاربری  ";
            this.tbxrecusername.Enter += new System.EventHandler(this.tbxrecusername_Enter);
            this.tbxrecusername.Leave += new System.EventHandler(this.tbxrecusername_Leave);
            // 
            // btnsavenewres
            // 
            this.btnsavenewres.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnsavenewres.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnsavenewres.ForeColor = System.Drawing.Color.Snow;
            this.btnsavenewres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsavenewres.Location = new System.Drawing.Point(45, 750);
            this.btnsavenewres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsavenewres.Name = "btnsavenewres";
            this.btnsavenewres.Size = new System.Drawing.Size(161, 65);
            this.btnsavenewres.TabIndex = 48;
            this.btnsavenewres.Text = "ذخیره";
            this.btnsavenewres.UseVisualStyleBackColor = false;
            this.btnsavenewres.Click += new System.EventHandler(this.btnsavenewres_Click);
            // 
            // btnBackAddresAccess
            // 
            this.btnBackAddresAccess.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackAddresAccess.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackAddresAccess.ForeColor = System.Drawing.Color.Snow;
            this.btnBackAddresAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackAddresAccess.Location = new System.Drawing.Point(1046, 750);
            this.btnBackAddresAccess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackAddresAccess.Name = "btnBackAddresAccess";
            this.btnBackAddresAccess.Size = new System.Drawing.Size(161, 65);
            this.btnBackAddresAccess.TabIndex = 47;
            this.btnBackAddresAccess.Text = "بازگشت";
            this.btnBackAddresAccess.UseVisualStyleBackColor = false;
            this.btnBackAddresAccess.Click += new System.EventHandler(this.btnBackAddresAccess_Click);
            // 
            // tbxSalary
            // 
            this.tbxSalary.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSalary.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxSalary.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxSalary.Location = new System.Drawing.Point(242, 562);
            this.tbxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxSalary.Size = new System.Drawing.Size(382, 57);
            this.tbxSalary.TabIndex = 49;
            this.tbxSalary.Text = "  حقوق ساعتی";
            this.tbxSalary.TextChanged += new System.EventHandler(this.tbxSalary_TextChanged);
            this.tbxSalary.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tbxSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSalary_KeyPress);
            this.tbxSalary.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // cbxShowpassword
            // 
            this.cbxShowpassword.AutoSize = true;
            this.cbxShowpassword.Font = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbxShowpassword.Location = new System.Drawing.Point(443, 490);
            this.cbxShowpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxShowpassword.Name = "cbxShowpassword";
            this.cbxShowpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxShowpassword.Size = new System.Drawing.Size(155, 39);
            this.cbxShowpassword.TabIndex = 50;
            this.cbxShowpassword.Text = "نمایش رمز عبور ";
            this.cbxShowpassword.UseVisualStyleBackColor = true;
            this.cbxShowpassword.CheckedChanged += new System.EventHandler(this.cbxShowpassword_CheckedChanged);
            // 
            // formaddrespaccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1274, 879);
            this.Controls.Add(this.cbxShowpassword);
            this.Controls.Add(this.tbxSalary);
            this.Controls.Add(this.btnsavenewres);
            this.Controls.Add(this.btnBackAddresAccess);
            this.Controls.Add(this.tbxresreenterpassword);
            this.Controls.Add(this.tbxrecPassword);
            this.Controls.Add(this.tbxrecusername);
            this.Controls.Add(this.rdbresGenderF);
            this.Controls.Add(this.rdbresGenderM);
            this.Controls.Add(this.lblmedicGender);
            this.Controls.Add(this.tbxrecPhoneNumber);
            this.Controls.Add(this.tbxrecAge);
            this.Controls.Add(this.tbxrecLname);
            this.Controls.Add(this.tbxrecFname);
            this.Controls.Add(this.lblAddresAccess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formaddrespaccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن دسترسی منشی ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formaddrespaccess_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddresAccess;
        private System.Windows.Forms.TextBox tbxrecFname;
        private System.Windows.Forms.TextBox tbxrecLname;
        private System.Windows.Forms.TextBox tbxrecAge;
        private System.Windows.Forms.TextBox tbxrecPhoneNumber;
        private System.Windows.Forms.Label lblmedicGender;
        private System.Windows.Forms.RadioButton rdbresGenderM;
        private System.Windows.Forms.RadioButton rdbresGenderF;
        private System.Windows.Forms.TextBox tbxresreenterpassword;
        private System.Windows.Forms.TextBox tbxrecPassword;
        private System.Windows.Forms.TextBox tbxrecusername;
        private System.Windows.Forms.Button btnsavenewres;
        private System.Windows.Forms.Button btnBackAddresAccess;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.CheckBox cbxShowpassword;
    }
}