
namespace binaiisanji
{
    partial class formAddSicknessCosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddSicknessCosts));
            this.tbxSicknessName = new System.Windows.Forms.TextBox();
            this.btnBackSickness = new System.Windows.Forms.Button();
            this.btnAddSickness = new System.Windows.Forms.Button();
            this.tbxSicknessPersent = new System.Windows.Forms.TextBox();
            this.lblAddsickness = new System.Windows.Forms.Label();
            this.dgvSicknessAdd = new System.Windows.Forms.DataGridView();
            this.sicknessIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessCostsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessCostsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet14 = new binaiisanji.clinicDataSet14();
            this.sicknessCostsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet4 = new binaiisanji.clinicDataSet4();
            this.sicknessCostsTableAdapter = new binaiisanji.clinicDataSet4TableAdapters.SicknessCostsTableAdapter();
            this.sicknessCostsTableAdapter1 = new binaiisanji.clinicDataSet14TableAdapters.SicknessCostsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSicknessAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicknessCostsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicknessCostsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxSicknessName
            // 
            this.tbxSicknessName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxSicknessName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxSicknessName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSicknessName.Location = new System.Drawing.Point(550, 222);
            this.tbxSicknessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSicknessName.Name = "tbxSicknessName";
            this.tbxSicknessName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxSicknessName.Size = new System.Drawing.Size(284, 57);
            this.tbxSicknessName.TabIndex = 2;
            this.tbxSicknessName.Text = "  نام بیماری  ";
            this.tbxSicknessName.Enter += new System.EventHandler(this.tbxSicknessName_Enter);
            this.tbxSicknessName.Leave += new System.EventHandler(this.tbxSicknessName_Leave);
            // 
            // btnBackSickness
            // 
            this.btnBackSickness.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackSickness.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackSickness.ForeColor = System.Drawing.Color.Snow;
            this.btnBackSickness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackSickness.Location = new System.Drawing.Point(654, 754);
            this.btnBackSickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackSickness.Name = "btnBackSickness";
            this.btnBackSickness.Size = new System.Drawing.Size(161, 65);
            this.btnBackSickness.TabIndex = 5;
            this.btnBackSickness.Text = "بازگشت";
            this.btnBackSickness.UseVisualStyleBackColor = false;
            this.btnBackSickness.Click += new System.EventHandler(this.btnBackSickness_Click);
            // 
            // btnAddSickness
            // 
            this.btnAddSickness.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddSickness.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddSickness.ForeColor = System.Drawing.Color.Snow;
            this.btnAddSickness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddSickness.Location = new System.Drawing.Point(71, 754);
            this.btnAddSickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddSickness.Name = "btnAddSickness";
            this.btnAddSickness.Size = new System.Drawing.Size(161, 65);
            this.btnAddSickness.TabIndex = 4;
            this.btnAddSickness.Text = "افزودن";
            this.btnAddSickness.UseVisualStyleBackColor = false;
            this.btnAddSickness.Click += new System.EventHandler(this.btnAddSickness_Click);
            // 
            // tbxSicknessPersent
            // 
            this.tbxSicknessPersent.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxSicknessPersent.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxSicknessPersent.ForeColor = System.Drawing.Color.DimGray;
            this.tbxSicknessPersent.Location = new System.Drawing.Point(550, 341);
            this.tbxSicknessPersent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSicknessPersent.Name = "tbxSicknessPersent";
            this.tbxSicknessPersent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxSicknessPersent.Size = new System.Drawing.Size(284, 57);
            this.tbxSicknessPersent.TabIndex = 3;
            this.tbxSicknessPersent.Text = "  تعرفه درمانی ";
            this.tbxSicknessPersent.TextChanged += new System.EventHandler(this.tbxSicknessPersent_TextChanged);
            this.tbxSicknessPersent.Enter += new System.EventHandler(this.tbxSicknessPersent_Enter);
            this.tbxSicknessPersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSicknessPersent_KeyPress);
            this.tbxSicknessPersent.Leave += new System.EventHandler(this.tbxSicknessPersent_Leave);
            // 
            // lblAddsickness
            // 
            this.lblAddsickness.AutoSize = true;
            this.lblAddsickness.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAddsickness.Font = new System.Drawing.Font("B Roya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblAddsickness.Location = new System.Drawing.Point(497, 71);
            this.lblAddsickness.Name = "lblAddsickness";
            this.lblAddsickness.Size = new System.Drawing.Size(351, 66);
            this.lblAddsickness.TabIndex = 1;
            this.lblAddsickness.Text = "اضافه کردن تعرفه جدید";
            this.lblAddsickness.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvSicknessAdd
            // 
            this.dgvSicknessAdd.AllowUserToAddRows = false;
            this.dgvSicknessAdd.AllowUserToDeleteRows = false;
            this.dgvSicknessAdd.AutoGenerateColumns = false;
            this.dgvSicknessAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSicknessAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sicknessIDDataGridViewTextBoxColumn,
            this.sicknessNameDataGridViewTextBoxColumn,
            this.sicknessCostsDataGridViewTextBoxColumn});
            this.dgvSicknessAdd.DataSource = this.sicknessCostsBindingSource1;
            this.dgvSicknessAdd.Location = new System.Drawing.Point(36, 222);
            this.dgvSicknessAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSicknessAdd.Name = "dgvSicknessAdd";
            this.dgvSicknessAdd.ReadOnly = true;
            this.dgvSicknessAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSicknessAdd.RowHeadersWidth = 51;
            this.dgvSicknessAdd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSicknessAdd.RowTemplate.Height = 24;
            this.dgvSicknessAdd.Size = new System.Drawing.Size(424, 401);
            this.dgvSicknessAdd.TabIndex = 56;
            // 
            // sicknessIDDataGridViewTextBoxColumn
            // 
            this.sicknessIDDataGridViewTextBoxColumn.DataPropertyName = "SicknessID";
            this.sicknessIDDataGridViewTextBoxColumn.HeaderText = "SicknessID";
            this.sicknessIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sicknessIDDataGridViewTextBoxColumn.Name = "sicknessIDDataGridViewTextBoxColumn";
            this.sicknessIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sicknessIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // sicknessNameDataGridViewTextBoxColumn
            // 
            this.sicknessNameDataGridViewTextBoxColumn.DataPropertyName = "SicknessName";
            this.sicknessNameDataGridViewTextBoxColumn.HeaderText = "SicknessName";
            this.sicknessNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sicknessNameDataGridViewTextBoxColumn.Name = "sicknessNameDataGridViewTextBoxColumn";
            this.sicknessNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sicknessNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sicknessCostsDataGridViewTextBoxColumn
            // 
            this.sicknessCostsDataGridViewTextBoxColumn.DataPropertyName = "SicknessCosts";
            this.sicknessCostsDataGridViewTextBoxColumn.HeaderText = "SicknessCosts";
            this.sicknessCostsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sicknessCostsDataGridViewTextBoxColumn.Name = "sicknessCostsDataGridViewTextBoxColumn";
            this.sicknessCostsDataGridViewTextBoxColumn.ReadOnly = true;
            this.sicknessCostsDataGridViewTextBoxColumn.Width = 125;
            // 
            // sicknessCostsBindingSource1
            // 
            this.sicknessCostsBindingSource1.DataMember = "SicknessCosts";
            this.sicknessCostsBindingSource1.DataSource = this.clinicDataSet14;
            // 
            // clinicDataSet14
            // 
            this.clinicDataSet14.DataSetName = "clinicDataSet14";
            this.clinicDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sicknessCostsBindingSource
            // 
            this.sicknessCostsBindingSource.DataMember = "SicknessCosts";
            this.sicknessCostsBindingSource.DataSource = this.clinicDataSet4;
            // 
            // clinicDataSet4
            // 
            this.clinicDataSet4.DataSetName = "clinicDataSet4";
            this.clinicDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sicknessCostsTableAdapter
            // 
            this.sicknessCostsTableAdapter.ClearBeforeFill = true;
            // 
            // sicknessCostsTableAdapter1
            // 
            this.sicknessCostsTableAdapter1.ClearBeforeFill = true;
            // 
            // formAddSicknessCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 879);
            this.Controls.Add(this.dgvSicknessAdd);
            this.Controls.Add(this.tbxSicknessName);
            this.Controls.Add(this.btnBackSickness);
            this.Controls.Add(this.btnAddSickness);
            this.Controls.Add(this.tbxSicknessPersent);
            this.Controls.Add(this.lblAddsickness);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formAddSicknessCosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعرفه های درمانی ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formAddSicknessCosts_FormClosing);
            this.Load += new System.EventHandler(this.formAddSicknessCosts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSicknessAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicknessCostsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicknessCostsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxSicknessName;
        private System.Windows.Forms.Button btnBackSickness;
        private System.Windows.Forms.Button btnAddSickness;
        private System.Windows.Forms.TextBox tbxSicknessPersent;
        private System.Windows.Forms.Label lblAddsickness;
        private System.Windows.Forms.DataGridView dgvSicknessAdd;
        private clinicDataSet4 clinicDataSet4;
        private System.Windows.Forms.BindingSource sicknessCostsBindingSource;
        private clinicDataSet4TableAdapters.SicknessCostsTableAdapter sicknessCostsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessCostsDataGridViewTextBoxColumn;
        private clinicDataSet14 clinicDataSet14;
        private System.Windows.Forms.BindingSource sicknessCostsBindingSource1;
        private clinicDataSet14TableAdapters.SicknessCostsTableAdapter sicknessCostsTableAdapter1;
    }
}