
namespace binaiisanji
{
    partial class FormBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackup));
            this.tbxBackUpPath = new System.Windows.Forms.TextBox();
            this.lblBackUp = new System.Windows.Forms.Label();
            this.btnBackBackup = new System.Windows.Forms.Button();
            this.btnSavebackup = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxBackUpPath
            // 
            this.tbxBackUpPath.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxBackUpPath.Font = new System.Drawing.Font("B Roya", 15F);
            this.tbxBackUpPath.ForeColor = System.Drawing.Color.DimGray;
            this.tbxBackUpPath.Location = new System.Drawing.Point(276, 305);
            this.tbxBackUpPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxBackUpPath.Name = "tbxBackUpPath";
            this.tbxBackUpPath.ReadOnly = true;
            this.tbxBackUpPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxBackUpPath.Size = new System.Drawing.Size(628, 57);
            this.tbxBackUpPath.TabIndex = 66;
            this.tbxBackUpPath.Text = "  محل ذخیره فایل پشتیبان";
            this.tbxBackUpPath.Enter += new System.EventHandler(this.tbxBackUpPath_Enter);
            this.tbxBackUpPath.Leave += new System.EventHandler(this.tbxBackUpPath_Leave);
            // 
            // lblBackUp
            // 
            this.lblBackUp.AutoSize = true;
            this.lblBackUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBackUp.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBackUp.Location = new System.Drawing.Point(791, 35);
            this.lblBackUp.Name = "lblBackUp";
            this.lblBackUp.Size = new System.Drawing.Size(176, 53);
            this.lblBackUp.TabIndex = 67;
            this.lblBackUp.Text = "پشتیبان گیری ";
            this.lblBackUp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBackBackup
            // 
            this.btnBackBackup.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBackBackup.FlatAppearance.BorderSize = 2;
            this.btnBackBackup.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackBackup.ForeColor = System.Drawing.Color.Ivory;
            this.btnBackBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackBackup.Location = new System.Drawing.Point(786, 590);
            this.btnBackBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackBackup.Name = "btnBackBackup";
            this.btnBackBackup.Size = new System.Drawing.Size(161, 65);
            this.btnBackBackup.TabIndex = 68;
            this.btnBackBackup.Text = "بازگشت";
            this.btnBackBackup.UseVisualStyleBackColor = false;
            this.btnBackBackup.Click += new System.EventHandler(this.btnBackChangePassword_Click);
            // 
            // btnSavebackup
            // 
            this.btnSavebackup.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSavebackup.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnSavebackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSavebackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSavebackup.Location = new System.Drawing.Point(44, 590);
            this.btnSavebackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavebackup.Name = "btnSavebackup";
            this.btnSavebackup.Size = new System.Drawing.Size(161, 65);
            this.btnSavebackup.TabIndex = 69;
            this.btnSavebackup.Text = "ذخیره ";
            this.btnSavebackup.UseVisualStyleBackColor = false;
            this.btnSavebackup.Click += new System.EventHandler(this.btnSavePassword_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBrowse.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(80, 305);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(161, 65);
            this.btnBrowse.TabIndex = 70;
            this.btnBrowse.Text = "محل ذخیره";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(992, 691);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSavebackup);
            this.Controls.Add(this.btnBackBackup);
            this.Controls.Add(this.lblBackUp);
            this.Controls.Add(this.tbxBackUpPath);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBackup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxBackUpPath;
        private System.Windows.Forms.Label lblBackUp;
        private System.Windows.Forms.Button btnBackBackup;
        private System.Windows.Forms.Button btnSavebackup;
        private System.Windows.Forms.Button btnBrowse;
    }
}