
namespace binaiisanji
{
    partial class formPatientcosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPatientcosts));
            this.lblpatientCost = new System.Windows.Forms.Label();
            this.tbxPatientFileNumber = new System.Windows.Forms.TextBox();
            this.btnBackPatientCost = new System.Windows.Forms.Button();
            this.btnShowCost = new System.Windows.Forms.Button();
            this.tbxPatientPay = new System.Windows.Forms.TextBox();
            this.tbxInsurencePay = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.tbxInsurence = new System.Windows.Forms.TextBox();
            this.tbxDateOfRecp = new System.Windows.Forms.TextBox();
            this.tbxPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsickness = new System.Windows.Forms.Label();
            this.tbxSicknessName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblpatientCost
            // 
            this.lblpatientCost.AutoSize = true;
            this.lblpatientCost.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblpatientCost.Font = new System.Drawing.Font("B Roya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblpatientCost.Location = new System.Drawing.Point(927, 39);
            this.lblpatientCost.Name = "lblpatientCost";
            this.lblpatientCost.Size = new System.Drawing.Size(331, 66);
            this.lblpatientCost.TabIndex = 41;
            this.lblpatientCost.Text = "رسید هزینه های  بیمار ";
            this.lblpatientCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxPatientFileNumber
            // 
            this.tbxPatientFileNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientFileNumber.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientFileNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientFileNumber.Location = new System.Drawing.Point(948, 256);
            this.tbxPatientFileNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientFileNumber.Name = "tbxPatientFileNumber";
            this.tbxPatientFileNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientFileNumber.Size = new System.Drawing.Size(284, 57);
            this.tbxPatientFileNumber.TabIndex = 44;
            this.tbxPatientFileNumber.Text = "شماره پرونده";
            this.tbxPatientFileNumber.Enter += new System.EventHandler(this.tbxPatientFileNumber_Enter);
            this.tbxPatientFileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPatientFileNumber_KeyPress);
            this.tbxPatientFileNumber.Leave += new System.EventHandler(this.tbxPatientFileNumber_Leave);
            // 
            // btnBackPatientCost
            // 
            this.btnBackPatientCost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackPatientCost.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackPatientCost.ForeColor = System.Drawing.Color.Snow;
            this.btnBackPatientCost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackPatientCost.Location = new System.Drawing.Point(1032, 764);
            this.btnBackPatientCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackPatientCost.Name = "btnBackPatientCost";
            this.btnBackPatientCost.Size = new System.Drawing.Size(161, 65);
            this.btnBackPatientCost.TabIndex = 43;
            this.btnBackPatientCost.Text = "بازگشت";
            this.btnBackPatientCost.UseVisualStyleBackColor = false;
            this.btnBackPatientCost.Click += new System.EventHandler(this.btnBackPatientCost_Click);
            // 
            // btnShowCost
            // 
            this.btnShowCost.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowCost.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnShowCost.ForeColor = System.Drawing.Color.Snow;
            this.btnShowCost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowCost.Location = new System.Drawing.Point(1015, 365);
            this.btnShowCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCost.Name = "btnShowCost";
            this.btnShowCost.Size = new System.Drawing.Size(161, 65);
            this.btnShowCost.TabIndex = 42;
            this.btnShowCost.Text = "نمایش";
            this.btnShowCost.UseVisualStyleBackColor = false;
            this.btnShowCost.Click += new System.EventHandler(this.btnShowCost_Click);
            // 
            // tbxPatientPay
            // 
            this.tbxPatientPay.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientPay.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientPay.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientPay.Location = new System.Drawing.Point(160, 704);
            this.tbxPatientPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientPay.Name = "tbxPatientPay";
            this.tbxPatientPay.ReadOnly = true;
            this.tbxPatientPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientPay.Size = new System.Drawing.Size(284, 57);
            this.tbxPatientPay.TabIndex = 46;
            // 
            // tbxInsurencePay
            // 
            this.tbxInsurencePay.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInsurencePay.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxInsurencePay.ForeColor = System.Drawing.Color.DimGray;
            this.tbxInsurencePay.Location = new System.Drawing.Point(160, 606);
            this.tbxInsurencePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxInsurencePay.Name = "tbxInsurencePay";
            this.tbxInsurencePay.ReadOnly = true;
            this.tbxInsurencePay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxInsurencePay.Size = new System.Drawing.Size(284, 57);
            this.tbxInsurencePay.TabIndex = 47;
            // 
            // tbxCost
            // 
            this.tbxCost.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCost.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxCost.ForeColor = System.Drawing.Color.DimGray;
            this.tbxCost.Location = new System.Drawing.Point(160, 508);
            this.tbxCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.ReadOnly = true;
            this.tbxCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxCost.Size = new System.Drawing.Size(284, 57);
            this.tbxCost.TabIndex = 48;
            // 
            // tbxInsurence
            // 
            this.tbxInsurence.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInsurence.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxInsurence.ForeColor = System.Drawing.Color.DimGray;
            this.tbxInsurence.Location = new System.Drawing.Point(160, 301);
            this.tbxInsurence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxInsurence.Name = "tbxInsurence";
            this.tbxInsurence.ReadOnly = true;
            this.tbxInsurence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxInsurence.Size = new System.Drawing.Size(284, 57);
            this.tbxInsurence.TabIndex = 49;
            // 
            // tbxDateOfRecp
            // 
            this.tbxDateOfRecp.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDateOfRecp.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxDateOfRecp.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDateOfRecp.Location = new System.Drawing.Point(160, 208);
            this.tbxDateOfRecp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDateOfRecp.Name = "tbxDateOfRecp";
            this.tbxDateOfRecp.ReadOnly = true;
            this.tbxDateOfRecp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxDateOfRecp.Size = new System.Drawing.Size(284, 57);
            this.tbxDateOfRecp.TabIndex = 50;
            // 
            // tbxPatientName
            // 
            this.tbxPatientName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientName.Location = new System.Drawing.Point(160, 104);
            this.tbxPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientName.Name = "tbxPatientName";
            this.tbxPatientName.ReadOnly = true;
            this.tbxPatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientName.Size = new System.Drawing.Size(284, 57);
            this.tbxPatientName.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(468, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 53);
            this.label1.TabIndex = 52;
            this.label1.Text = "نام و نام خانوادگی بیمار";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(564, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 53);
            this.label2.TabIndex = 53;
            this.label2.Text = "تاریخ پذیرش";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(613, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 53);
            this.label3.TabIndex = 54;
            this.label3.Text = "نوع بیمه ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(564, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 53);
            this.label4.TabIndex = 55;
            this.label4.Text = "تعرفه درمانی ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(513, 710);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 53);
            this.label5.TabIndex = 56;
            this.label5.Text = "سهم پرداختی بیمار";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(521, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 53);
            this.label6.TabIndex = 57;
            this.label6.Text = "سهم پرداختی بیمه";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblsickness
            // 
            this.lblsickness.AutoSize = true;
            this.lblsickness.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblsickness.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblsickness.Location = new System.Drawing.Point(502, 412);
            this.lblsickness.Name = "lblsickness";
            this.lblsickness.Size = new System.Drawing.Size(235, 53);
            this.lblsickness.TabIndex = 59;
            this.lblsickness.Text = "نوع خدمات درمانی ";
            this.lblsickness.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxSicknessName
            // 
            this.tbxSicknessName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxSicknessName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxSicknessName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSicknessName.Location = new System.Drawing.Point(160, 406);
            this.tbxSicknessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSicknessName.Name = "tbxSicknessName";
            this.tbxSicknessName.ReadOnly = true;
            this.tbxSicknessName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxSicknessName.Size = new System.Drawing.Size(284, 57);
            this.tbxSicknessName.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Font = new System.Drawing.Font("B Roya", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(55, 710);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 43);
            this.label7.TabIndex = 60;
            this.label7.Text = "تومان";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // formPatientcosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1274, 879);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblsickness);
            this.Controls.Add(this.tbxSicknessName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPatientName);
            this.Controls.Add(this.tbxDateOfRecp);
            this.Controls.Add(this.tbxInsurence);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxInsurencePay);
            this.Controls.Add(this.tbxPatientPay);
            this.Controls.Add(this.tbxPatientFileNumber);
            this.Controls.Add(this.btnBackPatientCost);
            this.Controls.Add(this.btnShowCost);
            this.Controls.Add(this.lblpatientCost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formPatientcosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رسید هزینه های بیمار ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPatientcosts_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpatientCost;
        private System.Windows.Forms.TextBox tbxPatientFileNumber;
        private System.Windows.Forms.Button btnBackPatientCost;
        private System.Windows.Forms.Button btnShowCost;
        private System.Windows.Forms.TextBox tbxPatientPay;
        private System.Windows.Forms.TextBox tbxInsurencePay;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.TextBox tbxInsurence;
        private System.Windows.Forms.TextBox tbxDateOfRecp;
        private System.Windows.Forms.TextBox tbxPatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsickness;
        private System.Windows.Forms.TextBox tbxSicknessName;
        private System.Windows.Forms.Label label7;
    }
}