
namespace binaiisanji
{
    partial class formRecoery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecoery));
            this.lblRecovery = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBackBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecovery
            // 
            this.lblRecovery.AutoSize = true;
            this.lblRecovery.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRecovery.Font = new System.Drawing.Font("B Roya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecovery.Location = new System.Drawing.Point(890, 40);
            this.lblRecovery.Name = "lblRecovery";
            this.lblRecovery.Size = new System.Drawing.Size(206, 57);
            this.lblRecovery.TabIndex = 21;
            this.lblRecovery.Text = "بازیابی اطلاعات ";
            this.lblRecovery.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnLoad.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLoad.Location = new System.Drawing.Point(60, 600);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(143, 52);
            this.btnLoad.TabIndex = 54;
            this.btnLoad.Text = "بارگزاری";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnBackBackup
            // 
            this.btnBackBackup.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnBackBackup.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackBackup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBackBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackBackup.Location = new System.Drawing.Point(930, 600);
            this.btnBackBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackBackup.Name = "btnBackBackup";
            this.btnBackBackup.Size = new System.Drawing.Size(143, 52);
            this.btnBackBackup.TabIndex = 57;
            this.btnBackBackup.Text = "بازگشت";
            this.btnBackBackup.UseVisualStyleBackColor = false;
            this.btnBackBackup.Click += new System.EventHandler(this.btnBackBackup_Click);
            // 
            // formRecoery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.btnBackBackup);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblRecovery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formRecoery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پشتیبان گیری ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formRecoery_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecovery;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBackBackup;
    }
}