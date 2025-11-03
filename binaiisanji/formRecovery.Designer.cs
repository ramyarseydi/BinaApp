
namespace binaiisanji
{
    partial class formRecovery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRecovery));
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSaveRestore = new System.Windows.Forms.Button();
            this.btnBackRestore = new System.Windows.Forms.Button();
            this.lblRestore = new System.Windows.Forms.Label();
            this.tbxRestorePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBrowse.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(71, 301);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(161, 65);
            this.btnBrowse.TabIndex = 75;
            this.btnBrowse.Text = "جستجو";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSaveRestore
            // 
            this.btnSaveRestore.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnSaveRestore.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnSaveRestore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveRestore.Location = new System.Drawing.Point(35, 586);
            this.btnSaveRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveRestore.Name = "btnSaveRestore";
            this.btnSaveRestore.Size = new System.Drawing.Size(161, 65);
            this.btnSaveRestore.TabIndex = 74;
            this.btnSaveRestore.Text = "ذخیره ";
            this.btnSaveRestore.UseVisualStyleBackColor = false;
            this.btnSaveRestore.Click += new System.EventHandler(this.btnSaveRestore_Click);
            // 
            // btnBackRestore
            // 
            this.btnBackRestore.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnBackRestore.FlatAppearance.BorderSize = 2;
            this.btnBackRestore.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackRestore.ForeColor = System.Drawing.Color.Ivory;
            this.btnBackRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackRestore.Location = new System.Drawing.Point(777, 586);
            this.btnBackRestore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackRestore.Name = "btnBackRestore";
            this.btnBackRestore.Size = new System.Drawing.Size(161, 65);
            this.btnBackRestore.TabIndex = 73;
            this.btnBackRestore.Text = "بازگشت";
            this.btnBackRestore.UseVisualStyleBackColor = false;
            this.btnBackRestore.Click += new System.EventHandler(this.btnBackRestore_Click);
            // 
            // lblRestore
            // 
            this.lblRestore.AutoSize = true;
            this.lblRestore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRestore.Font = new System.Drawing.Font("B Roya", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblRestore.Location = new System.Drawing.Point(782, 31);
            this.lblRestore.Name = "lblRestore";
            this.lblRestore.Size = new System.Drawing.Size(197, 53);
            this.lblRestore.TabIndex = 72;
            this.lblRestore.Text = "بازیابی اطلاعات ";
            this.lblRestore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxRestorePath
            // 
            this.tbxRestorePath.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxRestorePath.Font = new System.Drawing.Font("B Roya", 15F);
            this.tbxRestorePath.ForeColor = System.Drawing.Color.DimGray;
            this.tbxRestorePath.Location = new System.Drawing.Point(267, 301);
            this.tbxRestorePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxRestorePath.Name = "tbxRestorePath";
            this.tbxRestorePath.ReadOnly = true;
            this.tbxRestorePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxRestorePath.Size = new System.Drawing.Size(628, 57);
            this.tbxRestorePath.TabIndex = 71;
            this.tbxRestorePath.Text = "  محل ذخیره فایل پشتیبان  ";
            this.tbxRestorePath.Enter += new System.EventHandler(this.tbxRestorePath_Enter);
            this.tbxRestorePath.Leave += new System.EventHandler(this.tbxRestorePath_Leave);
            // 
            // formRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(992, 691);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSaveRestore);
            this.Controls.Add(this.btnBackRestore);
            this.Controls.Add(this.lblRestore);
            this.Controls.Add(this.tbxRestorePath);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formRecovery";
            this.Text = "بازیابی اطلاعات ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formRecovery_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSaveRestore;
        private System.Windows.Forms.Button btnBackRestore;
        private System.Windows.Forms.Label lblRestore;
        private System.Windows.Forms.TextBox tbxRestorePath;
    }
}