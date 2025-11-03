
namespace binaiisanji
{
    partial class formEditIns
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditIns));
            this.btnDeleteInsurence = new System.Windows.Forms.Button();
            this.tbxDeleteInsName = new System.Windows.Forms.TextBox();
            this.tbxDeleteInsId = new System.Windows.Forms.TextBox();
            this.lblDeleteIns = new System.Windows.Forms.Label();
            this.btnEditINS = new System.Windows.Forms.Button();
            this.tbxeditInsPersent = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insPersentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurenceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet12 = new binaiisanji.clinicDataSet12();
            this.insurenceTableAdapter1 = new binaiisanji.clinicDataSet12TableAdapters.insurenceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteInsurence
            // 
            this.btnDeleteInsurence.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteInsurence.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeleteInsurence.ForeColor = System.Drawing.Color.Snow;
            this.btnDeleteInsurence.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeleteInsurence.Location = new System.Drawing.Point(54, 749);
            this.btnDeleteInsurence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteInsurence.Name = "btnDeleteInsurence";
            this.btnDeleteInsurence.Size = new System.Drawing.Size(161, 65);
            this.btnDeleteInsurence.TabIndex = 8;
            this.btnDeleteInsurence.Text = "حذف";
            this.btnDeleteInsurence.UseVisualStyleBackColor = false;
            this.btnDeleteInsurence.Click += new System.EventHandler(this.btnDeleteInsurence_Click);
            // 
            // tbxDeleteInsName
            // 
            this.tbxDeleteInsName.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDeleteInsName.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxDeleteInsName.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDeleteInsName.Location = new System.Drawing.Point(500, 262);
            this.tbxDeleteInsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDeleteInsName.Name = "tbxDeleteInsName";
            this.tbxDeleteInsName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxDeleteInsName.Size = new System.Drawing.Size(362, 57);
            this.tbxDeleteInsName.TabIndex = 3;
            this.tbxDeleteInsName.Text = "  نام بیمه  ";
            this.tbxDeleteInsName.Enter += new System.EventHandler(this.tbxDeleteInsName_Enter);
            this.tbxDeleteInsName.Leave += new System.EventHandler(this.tbxDeleteInsName_Leave);
            // 
            // tbxDeleteInsId
            // 
            this.tbxDeleteInsId.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxDeleteInsId.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxDeleteInsId.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDeleteInsId.Location = new System.Drawing.Point(500, 172);
            this.tbxDeleteInsId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxDeleteInsId.Name = "tbxDeleteInsId";
            this.tbxDeleteInsId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxDeleteInsId.Size = new System.Drawing.Size(362, 57);
            this.tbxDeleteInsId.TabIndex = 2;
            this.tbxDeleteInsId.Text = "  شناسه بیمه  ";
            this.tbxDeleteInsId.Enter += new System.EventHandler(this.tbxDeleteInsId_Enter);
            this.tbxDeleteInsId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDeleteInsId_KeyPress);
            this.tbxDeleteInsId.Leave += new System.EventHandler(this.tbxDeleteInsId_Leave);
            // 
            // lblDeleteIns
            // 
            this.lblDeleteIns.AutoSize = true;
            this.lblDeleteIns.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDeleteIns.Font = new System.Drawing.Font("B Roya", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDeleteIns.Location = new System.Drawing.Point(634, 49);
            this.lblDeleteIns.Name = "lblDeleteIns";
            this.lblDeleteIns.Size = new System.Drawing.Size(234, 66);
            this.lblDeleteIns.TabIndex = 1;
            this.lblDeleteIns.Text = "ویرایش بیمه ها ";
            this.lblDeleteIns.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEditINS
            // 
            this.btnEditINS.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEditINS.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnEditINS.ForeColor = System.Drawing.Color.Snow;
            this.btnEditINS.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditINS.Location = new System.Drawing.Point(592, 448);
            this.btnEditINS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditINS.Name = "btnEditINS";
            this.btnEditINS.Size = new System.Drawing.Size(161, 65);
            this.btnEditINS.TabIndex = 5;
            this.btnEditINS.Text = "ویرایش";
            this.btnEditINS.UseVisualStyleBackColor = false;
            this.btnEditINS.Click += new System.EventHandler(this.btnEditINS_Click);
            // 
            // tbxeditInsPersent
            // 
            this.tbxeditInsPersent.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxeditInsPersent.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxeditInsPersent.ForeColor = System.Drawing.Color.DimGray;
            this.tbxeditInsPersent.Location = new System.Drawing.Point(500, 351);
            this.tbxeditInsPersent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxeditInsPersent.Name = "tbxeditInsPersent";
            this.tbxeditInsPersent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxeditInsPersent.Size = new System.Drawing.Size(362, 57);
            this.tbxeditInsPersent.TabIndex = 4;
            this.tbxeditInsPersent.Text = "  درصد بازپرداخت";
            this.tbxeditInsPersent.Enter += new System.EventHandler(this.tbxeditInsPersent_Enter);
            this.tbxeditInsPersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxeditInsPersent_KeyPress);
            this.tbxeditInsPersent.Leave += new System.EventHandler(this.tbxeditInsPersent_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(701, 749);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 65);
            this.button1.TabIndex = 7;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.insIDDataGridViewTextBoxColumn,
            this.insNameDataGridViewTextBoxColumn,
            this.insPersentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.insurenceBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(54, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(398, 344);
            this.dataGridView1.TabIndex = 9;
            // 
            // insIDDataGridViewTextBoxColumn
            // 
            this.insIDDataGridViewTextBoxColumn.DataPropertyName = "InsID";
            this.insIDDataGridViewTextBoxColumn.HeaderText = "InsID";
            this.insIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.insIDDataGridViewTextBoxColumn.Name = "insIDDataGridViewTextBoxColumn";
            this.insIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.insIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // insNameDataGridViewTextBoxColumn
            // 
            this.insNameDataGridViewTextBoxColumn.DataPropertyName = "InsName";
            this.insNameDataGridViewTextBoxColumn.HeaderText = "InsName";
            this.insNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.insNameDataGridViewTextBoxColumn.Name = "insNameDataGridViewTextBoxColumn";
            this.insNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.insNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // insPersentDataGridViewTextBoxColumn
            // 
            this.insPersentDataGridViewTextBoxColumn.DataPropertyName = "InsPersent";
            this.insPersentDataGridViewTextBoxColumn.HeaderText = "InsPersent";
            this.insPersentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.insPersentDataGridViewTextBoxColumn.Name = "insPersentDataGridViewTextBoxColumn";
            this.insPersentDataGridViewTextBoxColumn.ReadOnly = true;
            this.insPersentDataGridViewTextBoxColumn.Width = 150;
            // 
            // insurenceBindingSource1
            // 
            this.insurenceBindingSource1.DataMember = "insurence";
            this.insurenceBindingSource1.DataSource = this.clinicDataSet12;
            // 
            // clinicDataSet12
            // 
            this.clinicDataSet12.DataSetName = "clinicDataSet12";
            this.clinicDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insurenceTableAdapter1
            // 
            this.insurenceTableAdapter1.ClearBeforeFill = true;
            // 
            // formEditIns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 879);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxeditInsPersent);
            this.Controls.Add(this.btnEditINS);
            this.Controls.Add(this.btnDeleteInsurence);
            this.Controls.Add(this.tbxDeleteInsName);
            this.Controls.Add(this.tbxDeleteInsId);
            this.Controls.Add(this.lblDeleteIns);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formEditIns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش لیست بیمه ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formEditIns_FormClosing);
            this.Load += new System.EventHandler(this.formEditIns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insurenceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteInsurence;
        private System.Windows.Forms.TextBox tbxDeleteInsName;
        private System.Windows.Forms.TextBox tbxDeleteInsId;
        private System.Windows.Forms.Label lblDeleteIns;
        private System.Windows.Forms.Button btnEditINS;
        private System.Windows.Forms.TextBox tbxeditInsPersent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private clinicDataSet12 clinicDataSet12;
        private System.Windows.Forms.BindingSource insurenceBindingSource1;
        private clinicDataSet12TableAdapters.insurenceTableAdapter insurenceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn insIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insPersentDataGridViewTextBoxColumn;
    }
}