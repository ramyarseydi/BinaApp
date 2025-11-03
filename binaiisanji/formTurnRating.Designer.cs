
namespace binaiisanji
{
    partial class formTurnRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTurnRating));
            this.lblTurnRateing = new System.Windows.Forms.Label();
            this.lblTurnRateingHelp = new System.Windows.Forms.Label();
            this.btnBackTurnRateing = new System.Windows.Forms.Button();
            this.btnNextTurnRateing = new System.Windows.Forms.Button();
            this.dtpturnRating = new BehComponents.DateTimePickerX();
            this.tbxrecpFileNum = new System.Windows.Forms.TextBox();
            this.mtbxTime = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTurnRating = new System.Windows.Forms.DataGridView();
            this.nobatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet9 = new binaiisanji.clinicDataSet9();
            this.nobatTableAdapter1 = new binaiisanji.clinicDataSet9TableAdapters.NobatTableAdapter();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurnRateing
            // 
            this.lblTurnRateing.AutoSize = true;
            this.lblTurnRateing.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTurnRateing.Font = new System.Drawing.Font("B Roya", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTurnRateing.Location = new System.Drawing.Point(1078, 58);
            this.lblTurnRateing.Name = "lblTurnRateing";
            this.lblTurnRateing.Size = new System.Drawing.Size(179, 66);
            this.lblTurnRateing.TabIndex = 18;
            this.lblTurnRateing.Text = "نوبت دهی  ";
            this.lblTurnRateing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTurnRateingHelp
            // 
            this.lblTurnRateingHelp.AutoSize = true;
            this.lblTurnRateingHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTurnRateingHelp.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTurnRateingHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTurnRateingHelp.Location = new System.Drawing.Point(896, 206);
            this.lblTurnRateingHelp.Name = "lblTurnRateingHelp";
            this.lblTurnRateingHelp.Size = new System.Drawing.Size(328, 46);
            this.lblTurnRateingHelp.TabIndex = 47;
            this.lblTurnRateingHelp.Text = "لطفا تاریخ مورد نظر را وارد کنید ";
            this.lblTurnRateingHelp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBackTurnRateing
            // 
            this.btnBackTurnRateing.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackTurnRateing.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackTurnRateing.ForeColor = System.Drawing.Color.Snow;
            this.btnBackTurnRateing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackTurnRateing.Location = new System.Drawing.Point(1047, 778);
            this.btnBackTurnRateing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackTurnRateing.Name = "btnBackTurnRateing";
            this.btnBackTurnRateing.Size = new System.Drawing.Size(161, 65);
            this.btnBackTurnRateing.TabIndex = 57;
            this.btnBackTurnRateing.Text = "بازگشت";
            this.btnBackTurnRateing.UseVisualStyleBackColor = false;
            this.btnBackTurnRateing.Click += new System.EventHandler(this.btnBackTurnRateing_Click);
            // 
            // btnNextTurnRateing
            // 
            this.btnNextTurnRateing.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnNextTurnRateing.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNextTurnRateing.ForeColor = System.Drawing.Color.Snow;
            this.btnNextTurnRateing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNextTurnRateing.Location = new System.Drawing.Point(52, 778);
            this.btnNextTurnRateing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextTurnRateing.Name = "btnNextTurnRateing";
            this.btnNextTurnRateing.Size = new System.Drawing.Size(161, 65);
            this.btnNextTurnRateing.TabIndex = 58;
            this.btnNextTurnRateing.Text = "بعدی";
            this.btnNextTurnRateing.UseVisualStyleBackColor = false;
            this.btnNextTurnRateing.Click += new System.EventHandler(this.btnNextTurnRateing_Click_1);
            // 
            // dtpturnRating
            // 
            this.dtpturnRating.AnchorSize = new System.Drawing.Size(310, 55);
            this.dtpturnRating.BackColor = System.Drawing.SystemColors.Menu;
            this.dtpturnRating.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpturnRating.CalendarBorderColor = System.Drawing.Color.Black;
            this.dtpturnRating.CalendarDayRectTickness = 2F;
            this.dtpturnRating.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpturnRating.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpturnRating.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpturnRating.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpturnRating.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpturnRating.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpturnRating.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpturnRating.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpturnRating.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpturnRating.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpturnRating.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpturnRating.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpturnRating.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpturnRating.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpturnRating.CalendarShowToday = true;
            this.dtpturnRating.CalendarShowTodayRect = true;
            this.dtpturnRating.CalendarShowToolTips = false;
            this.dtpturnRating.CalendarShowTrailing = true;
            this.dtpturnRating.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpturnRating.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpturnRating.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpturnRating.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpturnRating.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpturnRating.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpturnRating.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpturnRating.CalendarTitleFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpturnRating.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpturnRating.CalendarTodayBackColor = System.Drawing.SystemColors.Control;
            this.dtpturnRating.CalendarTodayFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpturnRating.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpturnRating.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpturnRating.CalendarTodayRectTickness = 2F;
            this.dtpturnRating.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpturnRating.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpturnRating.CalendarWeekDaysBackColor = System.Drawing.SystemColors.Control;
            this.dtpturnRating.CalendarWeekDaysFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpturnRating.CalendarWeekDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpturnRating.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpturnRating.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpturnRating.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpturnRating.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpturnRating.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpturnRating.ClearButtonImage")));
            this.dtpturnRating.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpturnRating.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpturnRating.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpturnRating.ClearButtonText = "";
            this.dtpturnRating.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpturnRating.ClearButtonToolTip = "";
            this.dtpturnRating.ClearButtonWidth = 17;
            this.dtpturnRating.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpturnRating.CustomFormat = "yyyy-M-d";
            this.dtpturnRating.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpturnRating.DropDownClosedWhenClickOnDays = false;
            this.dtpturnRating.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpturnRating.Font = new System.Drawing.Font("B Roya", 14F, System.Drawing.FontStyle.Bold);
            this.dtpturnRating.ForeColor = System.Drawing.Color.DimGray;
            this.dtpturnRating.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpturnRating.Format4Binding = "yyyy-MM-dd";
            this.dtpturnRating.Location = new System.Drawing.Point(898, 274);
            this.dtpturnRating.Margin = new System.Windows.Forms.Padding(6);
            this.dtpturnRating.Name = "dtpturnRating";
            this.dtpturnRating.RightToLeftLayout = true;
            this.dtpturnRating.ShowClearButton = false;
            this.dtpturnRating.Size = new System.Drawing.Size(310, 55);
            this.dtpturnRating.TabIndex = 66;
            this.dtpturnRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpturnRating.TextWhenClearButtonClicked = "";
            // 
            // tbxrecpFileNum
            // 
            this.tbxrecpFileNum.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxrecpFileNum.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxrecpFileNum.ForeColor = System.Drawing.Color.DimGray;
            this.tbxrecpFileNum.Location = new System.Drawing.Point(903, 445);
            this.tbxrecpFileNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxrecpFileNum.Name = "tbxrecpFileNum";
            this.tbxrecpFileNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxrecpFileNum.Size = new System.Drawing.Size(304, 57);
            this.tbxrecpFileNum.TabIndex = 69;
            this.tbxrecpFileNum.Text = "  شماره پرونده";
            this.tbxrecpFileNum.TextChanged += new System.EventHandler(this.tbxrecpFileNum_TextChanged);
            this.tbxrecpFileNum.Enter += new System.EventHandler(this.tbxrecpFileNum_Enter);
            this.tbxrecpFileNum.Leave += new System.EventHandler(this.tbxrecpFileNum_Leave);
            // 
            // mtbxTime
            // 
            this.mtbxTime.BackColor = System.Drawing.SystemColors.Menu;
            this.mtbxTime.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mtbxTime.Location = new System.Drawing.Point(903, 611);
            this.mtbxTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbxTime.Mask = "90:00";
            this.mtbxTime.Name = "mtbxTime";
            this.mtbxTime.Size = new System.Drawing.Size(304, 57);
            this.mtbxTime.TabIndex = 70;
            this.mtbxTime.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(889, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 46);
            this.label1.TabIndex = 71;
            this.label1.Text = "لطفا ساعت مورد نظر را وارد کنید ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvTurnRating
            // 
            this.dgvTurnRating.AllowUserToAddRows = false;
            this.dgvTurnRating.AllowUserToDeleteRows = false;
            this.dgvTurnRating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnRating.Location = new System.Drawing.Point(72, 206);
            this.dgvTurnRating.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTurnRating.Name = "dgvTurnRating";
            this.dgvTurnRating.ReadOnly = true;
            this.dgvTurnRating.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTurnRating.RowHeadersWidth = 51;
            this.dgvTurnRating.RowTemplate.Height = 24;
            this.dgvTurnRating.Size = new System.Drawing.Size(665, 412);
            this.dgvTurnRating.TabIndex = 72;
            // 
            // nobatBindingSource1
            // 
            this.nobatBindingSource1.DataMember = "Nobat";
            this.nobatBindingSource1.DataSource = this.clinicDataSet9;
            // 
            // clinicDataSet9
            // 
            this.clinicDataSet9.DataSetName = "clinicDataSet9";
            this.clinicDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nobatTableAdapter1
            // 
            this.nobatTableAdapter1.ClearBeforeFill = true;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnShow.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShow.ForeColor = System.Drawing.Color.Snow;
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShow.Location = new System.Drawing.Point(980, 352);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(161, 65);
            this.btnShow.TabIndex = 73;
            this.btnShow.Text = "نمایش";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // formTurnRating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dgvTurnRating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbxTime);
            this.Controls.Add(this.tbxrecpFileNum);
            this.Controls.Add(this.dtpturnRating);
            this.Controls.Add(this.btnNextTurnRateing);
            this.Controls.Add(this.btnBackTurnRateing);
            this.Controls.Add(this.lblTurnRateingHelp);
            this.Controls.Add(this.lblTurnRateing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formTurnRating";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTurnRating";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formTurnRating_FormClosing);
            this.Load += new System.EventHandler(this.formTurnRating_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnRateing;
        private System.Windows.Forms.Label lblTurnRateingHelp;
        private System.Windows.Forms.Button btnBackTurnRateing;
        private System.Windows.Forms.Button btnNextTurnRateing;
        private BehComponents.DateTimePickerX dtpturnRating;
        private System.Windows.Forms.TextBox tbxrecpFileNum;
        private System.Windows.Forms.MaskedTextBox mtbxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTurnRating;
        private clinicDataSet9 clinicDataSet9;
        private System.Windows.Forms.BindingSource nobatBindingSource1;
        private clinicDataSet9TableAdapters.NobatTableAdapter nobatTableAdapter1;
        private System.Windows.Forms.Button btnShow;
    }
}