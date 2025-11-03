
namespace binaiisanji
{
    partial class formshowIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formshowIncome));
            this.dtpEnd = new BehComponents.DateTimePickerX();
            this.dtpStart = new BehComponents.DateTimePickerX();
            this.btnBackShowIncom = new System.Windows.Forms.Button();
            this.btnShowIncome = new System.Windows.Forms.Button();
            this.lblShwoIncomeEnd = new System.Windows.Forms.Label();
            this.lblShowIncomeStart = new System.Windows.Forms.Label();
            this.lblShowIncome = new System.Windows.Forms.Label();
            this.dvgShowIncomeMedic = new System.Windows.Forms.DataGridView();
            this.payIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payInsurenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payBypatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinicDataSet16 = new binaiisanji.clinicDataSet16();
            this.paymentTableAdapter1 = new binaiisanji.clinicDataSet16TableAdapters.paymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowIncomeMedic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpEnd
            // 
            this.dtpEnd.AnchorSize = new System.Drawing.Size(295, 55);
            this.dtpEnd.BackColor = System.Drawing.SystemColors.Menu;
            this.dtpEnd.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpEnd.CalendarBorderColor = System.Drawing.Color.Black;
            this.dtpEnd.CalendarDayRectTickness = 2F;
            this.dtpEnd.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpEnd.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpEnd.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpEnd.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpEnd.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpEnd.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpEnd.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpEnd.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpEnd.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpEnd.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpEnd.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpEnd.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpEnd.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpEnd.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpEnd.CalendarShowToday = true;
            this.dtpEnd.CalendarShowTodayRect = true;
            this.dtpEnd.CalendarShowToolTips = false;
            this.dtpEnd.CalendarShowTrailing = true;
            this.dtpEnd.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpEnd.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpEnd.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpEnd.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpEnd.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpEnd.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpEnd.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpEnd.CalendarTitleFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpEnd.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpEnd.CalendarTodayBackColor = System.Drawing.SystemColors.Control;
            this.dtpEnd.CalendarTodayFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpEnd.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpEnd.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpEnd.CalendarTodayRectTickness = 2F;
            this.dtpEnd.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpEnd.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpEnd.CalendarWeekDaysBackColor = System.Drawing.SystemColors.Control;
            this.dtpEnd.CalendarWeekDaysFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpEnd.CalendarWeekDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpEnd.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpEnd.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpEnd.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpEnd.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpEnd.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpEnd.ClearButtonImage")));
            this.dtpEnd.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpEnd.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpEnd.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpEnd.ClearButtonText = "";
            this.dtpEnd.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpEnd.ClearButtonToolTip = "";
            this.dtpEnd.ClearButtonWidth = 17;
            this.dtpEnd.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpEnd.CustomFormat = "yyyy-M-d";
            this.dtpEnd.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpEnd.DropDownClosedWhenClickOnDays = false;
            this.dtpEnd.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpEnd.Font = new System.Drawing.Font("B Roya", 14F, System.Drawing.FontStyle.Bold);
            this.dtpEnd.ForeColor = System.Drawing.Color.DimGray;
            this.dtpEnd.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpEnd.Format4Binding = "yyyy-MM-dd ";
            this.dtpEnd.Location = new System.Drawing.Point(924, 578);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.RightToLeftLayout = true;
            this.dtpEnd.ShowClearButton = false;
            this.dtpEnd.Size = new System.Drawing.Size(295, 55);
            this.dtpEnd.TabIndex = 74;
            this.dtpEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpEnd.TextWhenClearButtonClicked = "";
            // 
            // dtpStart
            // 
            this.dtpStart.AnchorSize = new System.Drawing.Size(295, 55);
            this.dtpStart.BackColor = System.Drawing.SystemColors.Menu;
            this.dtpStart.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpStart.CalendarBorderColor = System.Drawing.Color.Black;
            this.dtpStart.CalendarDayRectTickness = 2F;
            this.dtpStart.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpStart.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpStart.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpStart.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpStart.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpStart.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpStart.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpStart.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpStart.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpStart.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpStart.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpStart.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpStart.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpStart.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpStart.CalendarShowToday = true;
            this.dtpStart.CalendarShowTodayRect = true;
            this.dtpStart.CalendarShowToolTips = false;
            this.dtpStart.CalendarShowTrailing = true;
            this.dtpStart.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpStart.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpStart.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpStart.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpStart.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpStart.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpStart.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpStart.CalendarTitleFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpStart.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpStart.CalendarTodayBackColor = System.Drawing.SystemColors.Control;
            this.dtpStart.CalendarTodayFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpStart.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpStart.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpStart.CalendarTodayRectTickness = 2F;
            this.dtpStart.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpStart.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpStart.CalendarWeekDaysBackColor = System.Drawing.SystemColors.Control;
            this.dtpStart.CalendarWeekDaysFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpStart.CalendarWeekDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpStart.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpStart.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpStart.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpStart.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpStart.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpStart.ClearButtonImage")));
            this.dtpStart.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpStart.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpStart.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpStart.ClearButtonText = "";
            this.dtpStart.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpStart.ClearButtonToolTip = "";
            this.dtpStart.ClearButtonWidth = 17;
            this.dtpStart.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpStart.CustomFormat = "yyyy-M-d";
            this.dtpStart.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpStart.DropDownClosedWhenClickOnDays = false;
            this.dtpStart.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpStart.Font = new System.Drawing.Font("B Roya", 14F, System.Drawing.FontStyle.Bold);
            this.dtpStart.ForeColor = System.Drawing.Color.DimGray;
            this.dtpStart.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpStart.Format4Binding = "yyyy-MM-dd";
            this.dtpStart.Location = new System.Drawing.Point(924, 291);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.RightToLeftLayout = true;
            this.dtpStart.ShowClearButton = false;
            this.dtpStart.Size = new System.Drawing.Size(295, 55);
            this.dtpStart.TabIndex = 73;
            this.dtpStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpStart.TextWhenClearButtonClicked = "";
            // 
            // btnBackShowIncom
            // 
            this.btnBackShowIncom.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackShowIncom.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackShowIncom.ForeColor = System.Drawing.Color.Snow;
            this.btnBackShowIncom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackShowIncom.Location = new System.Drawing.Point(1024, 756);
            this.btnBackShowIncom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackShowIncom.Name = "btnBackShowIncom";
            this.btnBackShowIncom.Size = new System.Drawing.Size(161, 65);
            this.btnBackShowIncom.TabIndex = 72;
            this.btnBackShowIncom.Text = "بازگشت";
            this.btnBackShowIncom.UseVisualStyleBackColor = false;
            this.btnBackShowIncom.Click += new System.EventHandler(this.btnBackShowIncom_Click);
            // 
            // btnShowIncome
            // 
            this.btnShowIncome.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnShowIncome.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShowIncome.ForeColor = System.Drawing.Color.Snow;
            this.btnShowIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowIncome.Location = new System.Drawing.Point(45, 756);
            this.btnShowIncome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowIncome.Name = "btnShowIncome";
            this.btnShowIncome.Size = new System.Drawing.Size(161, 65);
            this.btnShowIncome.TabIndex = 71;
            this.btnShowIncome.Text = "نمایش ";
            this.btnShowIncome.UseVisualStyleBackColor = false;
            this.btnShowIncome.Click += new System.EventHandler(this.btnShowIncome_Click);
            // 
            // lblShwoIncomeEnd
            // 
            this.lblShwoIncomeEnd.AutoSize = true;
            this.lblShwoIncomeEnd.BackColor = System.Drawing.SystemColors.Menu;
            this.lblShwoIncomeEnd.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShwoIncomeEnd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblShwoIncomeEnd.Location = new System.Drawing.Point(900, 506);
            this.lblShwoIncomeEnd.Name = "lblShwoIncomeEnd";
            this.lblShwoIncomeEnd.Size = new System.Drawing.Size(347, 46);
            this.lblShwoIncomeEnd.TabIndex = 70;
            this.lblShwoIncomeEnd.Text = "لطفا تاریخ انتهای بازه را وارد نمایید";
            this.lblShwoIncomeEnd.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblShowIncomeStart
            // 
            this.lblShowIncomeStart.AutoSize = true;
            this.lblShowIncomeStart.BackColor = System.Drawing.SystemColors.Menu;
            this.lblShowIncomeStart.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowIncomeStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblShowIncomeStart.Location = new System.Drawing.Point(900, 219);
            this.lblShowIncomeStart.Name = "lblShowIncomeStart";
            this.lblShowIncomeStart.Size = new System.Drawing.Size(349, 46);
            this.lblShowIncomeStart.TabIndex = 69;
            this.lblShowIncomeStart.Text = "لطفا تاریخ ابتدای بازه را وارد نمایید\r\n";
            this.lblShowIncomeStart.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblShowIncome
            // 
            this.lblShowIncome.AutoSize = true;
            this.lblShowIncome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblShowIncome.Font = new System.Drawing.Font("B Roya", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblShowIncome.Location = new System.Drawing.Point(990, 56);
            this.lblShowIncome.Name = "lblShowIncome";
            this.lblShowIncome.Size = new System.Drawing.Size(232, 66);
            this.lblShowIncome.TabIndex = 68;
            this.lblShowIncome.Text = "نمایش کارکرد ";
            this.lblShowIncome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dvgShowIncomeMedic
            // 
            this.dvgShowIncomeMedic.AllowUserToAddRows = false;
            this.dvgShowIncomeMedic.AllowUserToDeleteRows = false;
            this.dvgShowIncomeMedic.AutoGenerateColumns = false;
            this.dvgShowIncomeMedic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgShowIncomeMedic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.payIDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.payInsurenceDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.payBypatientDataGridViewTextBoxColumn});
            this.dvgShowIncomeMedic.DataSource = this.paymentBindingSource1;
            this.dvgShowIncomeMedic.Location = new System.Drawing.Point(108, 219);
            this.dvgShowIncomeMedic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgShowIncomeMedic.Name = "dvgShowIncomeMedic";
            this.dvgShowIncomeMedic.ReadOnly = true;
            this.dvgShowIncomeMedic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dvgShowIncomeMedic.RowHeadersWidth = 51;
            this.dvgShowIncomeMedic.RowTemplate.Height = 24;
            this.dvgShowIncomeMedic.Size = new System.Drawing.Size(696, 464);
            this.dvgShowIncomeMedic.TabIndex = 75;
            // 
            // payIDDataGridViewTextBoxColumn
            // 
            this.payIDDataGridViewTextBoxColumn.DataPropertyName = "PayID";
            this.payIDDataGridViewTextBoxColumn.HeaderText = "PayID";
            this.payIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.payIDDataGridViewTextBoxColumn.Name = "payIDDataGridViewTextBoxColumn";
            this.payIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.payIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 150;
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            this.patientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // payInsurenceDataGridViewTextBoxColumn
            // 
            this.payInsurenceDataGridViewTextBoxColumn.DataPropertyName = "PayInsurence";
            this.payInsurenceDataGridViewTextBoxColumn.HeaderText = "PayInsurence";
            this.payInsurenceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.payInsurenceDataGridViewTextBoxColumn.Name = "payInsurenceDataGridViewTextBoxColumn";
            this.payInsurenceDataGridViewTextBoxColumn.ReadOnly = true;
            this.payInsurenceDataGridViewTextBoxColumn.Width = 150;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "PayDate";
            this.payDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            this.payDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.payDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // payBypatientDataGridViewTextBoxColumn
            // 
            this.payBypatientDataGridViewTextBoxColumn.DataPropertyName = "PayBypatient";
            this.payBypatientDataGridViewTextBoxColumn.HeaderText = "PayBypatient";
            this.payBypatientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.payBypatientDataGridViewTextBoxColumn.Name = "payBypatientDataGridViewTextBoxColumn";
            this.payBypatientDataGridViewTextBoxColumn.ReadOnly = true;
            this.payBypatientDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "payment";
            this.paymentBindingSource1.DataSource = this.clinicDataSet16;
            // 
            // clinicDataSet16
            // 
            this.clinicDataSet16.DataSetName = "clinicDataSet16";
            this.clinicDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // formshowIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.dvgShowIncomeMedic);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnBackShowIncom);
            this.Controls.Add(this.btnShowIncome);
            this.Controls.Add(this.lblShwoIncomeEnd);
            this.Controls.Add(this.lblShowIncomeStart);
            this.Controls.Add(this.lblShowIncome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formshowIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش کارکرد";
            this.Load += new System.EventHandler(this.formshowIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgShowIncomeMedic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BehComponents.DateTimePickerX dtpEnd;
        private BehComponents.DateTimePickerX dtpStart;
        private System.Windows.Forms.Button btnBackShowIncom;
        private System.Windows.Forms.Button btnShowIncome;
        private System.Windows.Forms.Label lblShwoIncomeEnd;
        private System.Windows.Forms.Label lblShowIncomeStart;
        private System.Windows.Forms.Label lblShowIncome;
        private System.Windows.Forms.DataGridView dvgShowIncomeMedic;
        private System.Windows.Forms.DataGridViewTextBoxColumn payIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payInsurenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payBypatientDataGridViewTextBoxColumn;
        private clinicDataSet16 clinicDataSet16;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private clinicDataSet16TableAdapters.paymentTableAdapter paymentTableAdapter1;
    }
}