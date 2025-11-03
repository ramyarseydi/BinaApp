
namespace binaiisanji
{
    partial class formEditSicknessCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditSicknessCost));
            this.btnDeleteSickness = new System.Windows.Forms.Button();
            this.tbxISicknessName = new System.Windows.Forms.TextBox();
            this.tbxDeleteSicknessId = new System.Windows.Forms.TextBox();
            this.lblDeletesickness = new System.Windows.Forms.Label();
            this.tbxCostEdit = new System.Windows.Forms.TextBox();
            this.btnSicknessEdit = new System.Windows.Forms.Button();
            this.btnBackEditSic = new System.Windows.Forms.Button();
            this.dgvSickness = new System.Windows.Forms.DataGridView();
            this.sicknessIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessCostsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sicknessCostsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet15 = new binaiisanji.clinicDataSet15();
            this.sicknessCostsTableAdapter2 = new binaiisanji.clinicDataSet15TableAdapters.SicknessCostsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicknessCostsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteSickness
            // 
            this.btnDeleteSickness.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteSickness.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSickness.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteSickness.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteSickness.Location = new System.Drawing.Point(42, 764);
            this.btnDeleteSickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteSickness.Name = "btnDeleteSickness";
            this.btnDeleteSickness.Size = new System.Drawing.Size(161, 65);
            this.btnDeleteSickness.TabIndex = 5;
            this.btnDeleteSickness.Text = "حذف";
            this.btnDeleteSickness.UseVisualStyleBackColor = false;
            this.btnDeleteSickness.Click += new System.EventHandler(this.btnDeleteSickness_Click);
            // 
            // tbxISicknessName
            // 
            this.tbxISicknessName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxISicknessName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxISicknessName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxISicknessName.Location = new System.Drawing.Point(560, 239);
            this.tbxISicknessName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxISicknessName.Name = "tbxISicknessName";
            this.tbxISicknessName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxISicknessName.Size = new System.Drawing.Size(290, 57);
            this.tbxISicknessName.TabIndex = 3;
            this.tbxISicknessName.Text = "  نام بیماری  ";
            this.tbxISicknessName.Enter += new System.EventHandler(this.tbxDeleteISicknessName_Enter);
            this.tbxISicknessName.Leave += new System.EventHandler(this.tbxDeleteISicknessName_Leave);
            // 
            // tbxDeleteSicknessId
            // 
            this.tbxDeleteSicknessId.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDeleteSicknessId.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxDeleteSicknessId.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDeleteSicknessId.Location = new System.Drawing.Point(560, 146);
            this.tbxDeleteSicknessId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDeleteSicknessId.Name = "tbxDeleteSicknessId";
            this.tbxDeleteSicknessId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxDeleteSicknessId.Size = new System.Drawing.Size(290, 57);
            this.tbxDeleteSicknessId.TabIndex = 2;
            this.tbxDeleteSicknessId.Text = "  شناسه بیماری  ";
            this.tbxDeleteSicknessId.Enter += new System.EventHandler(this.tbxDeleteSicknessId_Enter);
            this.tbxDeleteSicknessId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDeleteSicknessId_KeyPress);
            this.tbxDeleteSicknessId.Leave += new System.EventHandler(this.tbxDeleteSicknessId_Leave);
            // 
            // lblDeletesickness
            // 
            this.lblDeletesickness.AutoSize = true;
            this.lblDeletesickness.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDeletesickness.Font = new System.Drawing.Font("B Roya", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDeletesickness.Location = new System.Drawing.Point(506, 44);
            this.lblDeletesickness.Name = "lblDeletesickness";
            this.lblDeletesickness.Size = new System.Drawing.Size(375, 65);
            this.lblDeletesickness.TabIndex = 1;
            this.lblDeletesickness.Text = "ویرایش تعرفه های درمانی ";
            this.lblDeletesickness.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxCostEdit
            // 
            this.tbxCostEdit.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxCostEdit.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxCostEdit.ForeColor = System.Drawing.Color.DimGray;
            this.tbxCostEdit.Location = new System.Drawing.Point(560, 336);
            this.tbxCostEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxCostEdit.Name = "tbxCostEdit";
            this.tbxCostEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxCostEdit.Size = new System.Drawing.Size(290, 57);
            this.tbxCostEdit.TabIndex = 4;
            this.tbxCostEdit.Text = "  تعرفه درمانی ";
            this.tbxCostEdit.Click += new System.EventHandler(this.tbxCostEdit_Click);
            this.tbxCostEdit.TextChanged += new System.EventHandler(this.tbxCostEdit_TextChanged);
            this.tbxCostEdit.Enter += new System.EventHandler(this.tbxCostEdit_Enter);
            this.tbxCostEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCostEdit_KeyPress);
            this.tbxCostEdit.Leave += new System.EventHandler(this.tbxCostEdit_Leave);
            // 
            // btnSicknessEdit
            // 
            this.btnSicknessEdit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSicknessEdit.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnSicknessEdit.ForeColor = System.Drawing.Color.Snow;
            this.btnSicknessEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSicknessEdit.Location = new System.Drawing.Point(616, 439);
            this.btnSicknessEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSicknessEdit.Name = "btnSicknessEdit";
            this.btnSicknessEdit.Size = new System.Drawing.Size(161, 65);
            this.btnSicknessEdit.TabIndex = 53;
            this.btnSicknessEdit.Text = "ویرایش";
            this.btnSicknessEdit.UseVisualStyleBackColor = false;
            this.btnSicknessEdit.Click += new System.EventHandler(this.btnSicknessEdit_Click);
            // 
            // btnBackEditSic
            // 
            this.btnBackEditSic.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBackEditSic.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnBackEditSic.ForeColor = System.Drawing.Color.Snow;
            this.btnBackEditSic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackEditSic.Location = new System.Drawing.Point(690, 764);
            this.btnBackEditSic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackEditSic.Name = "btnBackEditSic";
            this.btnBackEditSic.Size = new System.Drawing.Size(161, 65);
            this.btnBackEditSic.TabIndex = 6;
            this.btnBackEditSic.Text = "بازگشت";
            this.btnBackEditSic.UseVisualStyleBackColor = false;
            this.btnBackEditSic.Click += new System.EventHandler(this.btnBackEditSic_Click);
            // 
            // dgvSickness
            // 
            this.dgvSickness.AllowUserToAddRows = false;
            this.dgvSickness.AllowUserToDeleteRows = false;
            this.dgvSickness.AutoGenerateColumns = false;
            this.dgvSickness.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSickness.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sicknessIDDataGridViewTextBoxColumn,
            this.sicknessNameDataGridViewTextBoxColumn,
            this.sicknessCostsDataGridViewTextBoxColumn});
            this.dgvSickness.DataSource = this.sicknessCostsBindingSource2;
            this.dgvSickness.Location = new System.Drawing.Point(42, 239);
            this.dgvSickness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSickness.Name = "dgvSickness";
            this.dgvSickness.ReadOnly = true;
            this.dgvSickness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSickness.RowHeadersWidth = 51;
            this.dgvSickness.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSickness.RowTemplate.Height = 24;
            this.dgvSickness.Size = new System.Drawing.Size(424, 401);
            this.dgvSickness.TabIndex = 55;
            this.dgvSickness.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSickness_CellClick);
            this.dgvSickness.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSickness_CellDoubleClick_1);
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
            // sicknessCostsBindingSource2
            // 
            this.sicknessCostsBindingSource2.DataMember = "SicknessCosts";
            this.sicknessCostsBindingSource2.DataSource = this.clinicDataSet15;
            // 
            // clinicDataSet15
            // 
            this.clinicDataSet15.DataSetName = "clinicDataSet15";
            this.clinicDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sicknessCostsTableAdapter2
            // 
            this.sicknessCostsTableAdapter2.ClearBeforeFill = true;
            // 
            // formEditSicknessCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 879);
            this.Controls.Add(this.dgvSickness);
            this.Controls.Add(this.btnBackEditSic);
            this.Controls.Add(this.btnSicknessEdit);
            this.Controls.Add(this.tbxCostEdit);
            this.Controls.Add(this.btnDeleteSickness);
            this.Controls.Add(this.tbxISicknessName);
            this.Controls.Add(this.tbxDeleteSicknessId);
            this.Controls.Add(this.lblDeletesickness);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formEditSicknessCost";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش تعرفه های درمانی ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formEditSicknessCost_FormClosing);
            this.Load += new System.EventHandler(this.formEditSicknessCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sicknessCostsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSickness;
        private System.Windows.Forms.TextBox tbxISicknessName;
        private System.Windows.Forms.TextBox tbxDeleteSicknessId;
        private System.Windows.Forms.Label lblDeletesickness;
        private System.Windows.Forms.TextBox tbxCostEdit;
        private System.Windows.Forms.Button btnSicknessEdit;
        private System.Windows.Forms.Button btnBackEditSic;
        private System.Windows.Forms.DataGridView dgvSickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sicknessCostsDataGridViewTextBoxColumn;
        private clinicDataSet15 clinicDataSet15;
        private System.Windows.Forms.BindingSource sicknessCostsBindingSource2;
        private clinicDataSet15TableAdapters.SicknessCostsTableAdapter sicknessCostsTableAdapter2;
    }
}