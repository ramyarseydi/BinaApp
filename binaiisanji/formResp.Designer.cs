
namespace binaiisanji
{
    partial class formResp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formResp));
            this.lblRecptionPaitent = new System.Windows.Forms.Label();
            this.tbxrecpFileNum = new System.Windows.Forms.TextBox();
            this.tbxpaymentNumber = new System.Windows.Forms.TextBox();
            this.btnBackFileGen = new System.Windows.Forms.Button();
            this.btnSaveFIleGen = new System.Windows.Forms.Button();
            this.cmbSickness = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblRecptionPaitent
            // 
            this.lblRecptionPaitent.AutoSize = true;
            this.lblRecptionPaitent.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRecptionPaitent.Font = new System.Drawing.Font("B Roya", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRecptionPaitent.Location = new System.Drawing.Point(327, 68);
            this.lblRecptionPaitent.Name = "lblRecptionPaitent";
            this.lblRecptionPaitent.Size = new System.Drawing.Size(214, 66);
            this.lblRecptionPaitent.TabIndex = 1;
            this.lblRecptionPaitent.Text = " پذیرش بیمار ";
            this.lblRecptionPaitent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxrecpFileNum
            // 
            this.tbxrecpFileNum.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxrecpFileNum.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecpFileNum.ForeColor = System.Drawing.Color.DimGray;
            this.tbxrecpFileNum.Location = new System.Drawing.Point(255, 176);
            this.tbxrecpFileNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxrecpFileNum.Name = "tbxrecpFileNum";
            this.tbxrecpFileNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecpFileNum.Size = new System.Drawing.Size(352, 57);
            this.tbxrecpFileNum.TabIndex = 2;
            this.tbxrecpFileNum.Text = "  شماره پرونده     ";
            this.tbxrecpFileNum.Enter += new System.EventHandler(this.tbxrecpFileNum_Enter);
            this.tbxrecpFileNum.Leave += new System.EventHandler(this.tbxrecpFileNum_Leave);
            // 
            // tbxpaymentNumber
            // 
            this.tbxpaymentNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxpaymentNumber.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxpaymentNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxpaymentNumber.Location = new System.Drawing.Point(255, 272);
            this.tbxpaymentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxpaymentNumber.Name = "tbxpaymentNumber";
            this.tbxpaymentNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxpaymentNumber.Size = new System.Drawing.Size(349, 57);
            this.tbxpaymentNumber.TabIndex = 3;
            this.tbxpaymentNumber.Text = "  شماره پیگیری پرداخت ";
            this.tbxpaymentNumber.Enter += new System.EventHandler(this.tbxpaymentNumber_Enter);
            this.tbxpaymentNumber.Leave += new System.EventHandler(this.tbxpaymentNumber_Leave);
            // 
            // btnBackFileGen
            // 
            this.btnBackFileGen.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackFileGen.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackFileGen.ForeColor = System.Drawing.Color.Snow;
            this.btnBackFileGen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackFileGen.Location = new System.Drawing.Point(656, 765);
            this.btnBackFileGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackFileGen.Name = "btnBackFileGen";
            this.btnBackFileGen.Size = new System.Drawing.Size(161, 65);
            this.btnBackFileGen.TabIndex = 48;
            this.btnBackFileGen.Text = "بازگشت";
            this.btnBackFileGen.UseVisualStyleBackColor = false;
            this.btnBackFileGen.Click += new System.EventHandler(this.btnBackFileGen_Click);
            // 
            // btnSaveFIleGen
            // 
            this.btnSaveFIleGen.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnSaveFIleGen.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveFIleGen.ForeColor = System.Drawing.Color.Snow;
            this.btnSaveFIleGen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveFIleGen.Location = new System.Drawing.Point(62, 765);
            this.btnSaveFIleGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveFIleGen.Name = "btnSaveFIleGen";
            this.btnSaveFIleGen.Size = new System.Drawing.Size(161, 65);
            this.btnSaveFIleGen.TabIndex = 47;
            this.btnSaveFIleGen.Text = "پذیرش";
            this.btnSaveFIleGen.UseVisualStyleBackColor = false;
            this.btnSaveFIleGen.Click += new System.EventHandler(this.btnSaveFIleGen_Click);
            // 
            // cmbSickness
            // 
            this.cmbSickness.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbSickness.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbSickness.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSickness.FormattingEnabled = true;
            this.cmbSickness.Location = new System.Drawing.Point(255, 370);
            this.cmbSickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSickness.Name = "cmbSickness";
            this.cmbSickness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSickness.Size = new System.Drawing.Size(349, 54);
            this.cmbSickness.TabIndex = 4;
            // 
            // formResp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 879);
            this.Controls.Add(this.cmbSickness);
            this.Controls.Add(this.btnBackFileGen);
            this.Controls.Add(this.btnSaveFIleGen);
            this.Controls.Add(this.tbxrecpFileNum);
            this.Controls.Add(this.tbxpaymentNumber);
            this.Controls.Add(this.lblRecptionPaitent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formResp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پذیرش";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formResp_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecptionPaitent;
        private System.Windows.Forms.TextBox tbxrecpFileNum;
        private System.Windows.Forms.TextBox tbxpaymentNumber;
        private System.Windows.Forms.Button btnBackFileGen;
        private System.Windows.Forms.Button btnSaveFIleGen;
        private System.Windows.Forms.ComboBox cmbSickness;
    }
}