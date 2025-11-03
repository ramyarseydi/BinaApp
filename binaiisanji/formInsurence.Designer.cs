
namespace binaiisanji
{
    partial class formAddInsurence
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddInsurence));
            this.lblAddIns = new System.Windows.Forms.Label();
            this.tbxInsurensePersent = new System.Windows.Forms.TextBox();
            this.btnAddInsurence = new System.Windows.Forms.Button();
            this.btnBackInsurence = new System.Windows.Forms.Button();
            this.tbxInsurenceName = new System.Windows.Forms.TextBox();
            this.insurenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet5 = new binaiisanji.clinicDataSet5();
            this.insurenceTableAdapter = new binaiisanji.clinicDataSet5TableAdapters.insurenceTableAdapter();
            this.insPersentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAddsickness = new System.Windows.Forms.DataGridView();
            this.insurenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet13 = new binaiisanji.clinicDataSet13();
            this.insurenceTableAdapter1 = new binaiisanji.clinicDataSet13TableAdapters.insurenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddsickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddIns
            // 
            this.lblAddIns.AutoSize = true;
            this.lblAddIns.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAddIns.Font = new System.Drawing.Font("B Roya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddIns.Location = new System.Drawing.Point(528, 58);
            this.lblAddIns.Name = "lblAddIns";
            this.lblAddIns.Size = new System.Drawing.Size(341, 66);
            this.lblAddIns.TabIndex = 1;
            this.lblAddIns.Text = "اضافه کردن بیمه جدید ";
            this.lblAddIns.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxInsurensePersent
            // 
            this.tbxInsurensePersent.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInsurensePersent.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxInsurensePersent.ForeColor = System.Drawing.Color.DimGray;
            this.tbxInsurensePersent.Location = new System.Drawing.Point(554, 328);
            this.tbxInsurensePersent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxInsurensePersent.Name = "tbxInsurensePersent";
            this.tbxInsurensePersent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxInsurensePersent.Size = new System.Drawing.Size(284, 57);
            this.tbxInsurensePersent.TabIndex = 3;
            this.tbxInsurensePersent.Text = "  درصد بازپرداخت ";
            this.tbxInsurensePersent.Enter += new System.EventHandler(this.tbxInsurensePersent_Enter);
            this.tbxInsurensePersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxInsurensePersent_KeyPress);
            this.tbxInsurensePersent.Leave += new System.EventHandler(this.tbxInsurensePersent_Leave);
            // 
            // btnAddInsurence
            // 
            this.btnAddInsurence.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddInsurence.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddInsurence.ForeColor = System.Drawing.Color.Snow;
            this.btnAddInsurence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddInsurence.Location = new System.Drawing.Point(51, 764);
            this.btnAddInsurence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddInsurence.Name = "btnAddInsurence";
            this.btnAddInsurence.Size = new System.Drawing.Size(161, 65);
            this.btnAddInsurence.TabIndex = 4;
            this.btnAddInsurence.Text = "افزودن";
            this.btnAddInsurence.UseVisualStyleBackColor = false;
            this.btnAddInsurence.Click += new System.EventHandler(this.btnAddInsurence_Click);
            // 
            // btnBackInsurence
            // 
            this.btnBackInsurence.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackInsurence.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackInsurence.ForeColor = System.Drawing.Color.Snow;
            this.btnBackInsurence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackInsurence.Location = new System.Drawing.Point(677, 764);
            this.btnBackInsurence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackInsurence.Name = "btnBackInsurence";
            this.btnBackInsurence.Size = new System.Drawing.Size(161, 65);
            this.btnBackInsurence.TabIndex = 5;
            this.btnBackInsurence.Text = "بازگشت";
            this.btnBackInsurence.UseVisualStyleBackColor = false;
            this.btnBackInsurence.Click += new System.EventHandler(this.btnBackInsurence_Click);
            // 
            // tbxInsurenceName
            // 
            this.tbxInsurenceName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxInsurenceName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxInsurenceName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxInsurenceName.Location = new System.Drawing.Point(554, 208);
            this.tbxInsurenceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxInsurenceName.Name = "tbxInsurenceName";
            this.tbxInsurenceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxInsurenceName.Size = new System.Drawing.Size(284, 57);
            this.tbxInsurenceName.TabIndex = 2;
            this.tbxInsurenceName.Text = "  نام بیمه  ";
            this.tbxInsurenceName.TextChanged += new System.EventHandler(this.tbxInsurenceName_TextChanged);
            this.tbxInsurenceName.Enter += new System.EventHandler(this.tbxInsurenceName_Enter);
            this.tbxInsurenceName.Leave += new System.EventHandler(this.tbxInsurenceName_Leave);
            // 
            // insurenceBindingSource
            // 
            this.insurenceBindingSource.DataMember = "insurence";
            this.insurenceBindingSource.DataSource = this.clinicDataSet5;
            // 
            // clinicDataSet5
            // 
            this.clinicDataSet5.DataSetName = "clinicDataSet5";
            this.clinicDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insurenceTableAdapter
            // 
            this.insurenceTableAdapter.ClearBeforeFill = true;
            // 
            // insPersentDataGridViewTextBoxColumn
            // 
            this.insPersentDataGridViewTextBoxColumn.DataPropertyName = "InsPersent";
            this.insPersentDataGridViewTextBoxColumn.HeaderText = "InsPersent";
            this.insPersentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insPersentDataGridViewTextBoxColumn.Name = "insPersentDataGridViewTextBoxColumn";
            this.insPersentDataGridViewTextBoxColumn.ReadOnly = true;
            this.insPersentDataGridViewTextBoxColumn.Width = 125;
            // 
            // insIDDataGridViewTextBoxColumn
            // 
            this.insIDDataGridViewTextBoxColumn.DataPropertyName = "InsID";
            this.insIDDataGridViewTextBoxColumn.HeaderText = "InsID";
            this.insIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insIDDataGridViewTextBoxColumn.Name = "insIDDataGridViewTextBoxColumn";
            this.insIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.insIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // insNameDataGridViewTextBoxColumn
            // 
            this.insNameDataGridViewTextBoxColumn.DataPropertyName = "InsName";
            this.insNameDataGridViewTextBoxColumn.HeaderText = "InsName";
            this.insNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.insNameDataGridViewTextBoxColumn.Name = "insNameDataGridViewTextBoxColumn";
            this.insNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.insNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dgvAddsickness
            // 
            this.dgvAddsickness.AllowUserToAddRows = false;
            this.dgvAddsickness.AllowUserToDeleteRows = false;
            this.dgvAddsickness.AutoGenerateColumns = false;
            this.dgvAddsickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddsickness.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insNameDataGridViewTextBoxColumn,
            this.insIDDataGridViewTextBoxColumn,
            this.insPersentDataGridViewTextBoxColumn});
            this.dgvAddsickness.DataSource = this.insurenceBindingSource1;
            this.dgvAddsickness.Location = new System.Drawing.Point(40, 208);
            this.dgvAddsickness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAddsickness.Name = "dgvAddsickness";
            this.dgvAddsickness.ReadOnly = true;
            this.dgvAddsickness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAddsickness.RowHeadersWidth = 51;
            this.dgvAddsickness.RowTemplate.Height = 24;
            this.dgvAddsickness.Size = new System.Drawing.Size(407, 401);
            this.dgvAddsickness.TabIndex = 42;
            // 
            // insurenceBindingSource1
            // 
            this.insurenceBindingSource1.DataMember = "insurence";
            this.insurenceBindingSource1.DataSource = this.clinicDataSet13;
            // 
            // clinicDataSet13
            // 
            this.clinicDataSet13.DataSetName = "clinicDataSet13";
            this.clinicDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insurenceTableAdapter1
            // 
            this.insurenceTableAdapter1.ClearBeforeFill = true;
            // 
            // formAddInsurence
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 879);
            this.Controls.Add(this.dgvAddsickness);
            this.Controls.Add(this.tbxInsurenceName);
            this.Controls.Add(this.btnBackInsurence);
            this.Controls.Add(this.btnAddInsurence);
            this.Controls.Add(this.tbxInsurensePersent);
            this.Controls.Add(this.lblAddIns);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formAddInsurence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن بیمه ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAddInsurence_FormClosing);
            this.Load += new System.EventHandler(this.formAddInsurence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.insurenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddsickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddIns;
        private System.Windows.Forms.TextBox tbxInsurensePersent;
        private System.Windows.Forms.Button btnAddInsurence;
        private System.Windows.Forms.Button btnBackInsurence;
        private System.Windows.Forms.TextBox tbxInsurenceName;
        private clinicDataSet5 clinicDataSet5;
        private System.Windows.Forms.BindingSource insurenceBindingSource;
        private clinicDataSet5TableAdapters.insurenceTableAdapter insurenceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn insPersentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvAddsickness;
        private clinicDataSet13 clinicDataSet13;
        private System.Windows.Forms.BindingSource insurenceBindingSource1;
        private clinicDataSet13TableAdapters.insurenceTableAdapter insurenceTableAdapter1;
    }
}