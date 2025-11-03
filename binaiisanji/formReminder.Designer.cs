
namespace binaiisanji
{
    partial class formReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReminder));
            this.btnBackReminder = new System.Windows.Forms.Button();
            this.btnShowReminder = new System.Windows.Forms.Button();
            this.lblReminder = new System.Windows.Forms.Label();
            this.dgvReminder = new System.Windows.Forms.DataGridView();
            this.clinicDataSet10 = new binaiisanji.clinicDataSet10();
            this.lblReminderHelp = new System.Windows.Forms.Label();
            this.dtpReminder = new BehComponents.DateTimePickerX();
            this.nobatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nobatTableAdapter = new binaiisanji.clinicDataSet10TableAdapters.NobatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackReminder
            // 
            this.btnBackReminder.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackReminder.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackReminder.ForeColor = System.Drawing.Color.Snow;
            this.btnBackReminder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBackReminder.Location = new System.Drawing.Point(1022, 756);
            this.btnBackReminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackReminder.Name = "btnBackReminder";
            this.btnBackReminder.Size = new System.Drawing.Size(161, 65);
            this.btnBackReminder.TabIndex = 62;
            this.btnBackReminder.Text = "بازگشت";
            this.btnBackReminder.UseVisualStyleBackColor = false;
            this.btnBackReminder.Click += new System.EventHandler(this.btnBackReminder_Click);
            // 
            // btnShowReminder
            // 
            this.btnShowReminder.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnShowReminder.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShowReminder.ForeColor = System.Drawing.Color.Snow;
            this.btnShowReminder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShowReminder.Location = new System.Drawing.Point(969, 388);
            this.btnShowReminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowReminder.Name = "btnShowReminder";
            this.btnShowReminder.Size = new System.Drawing.Size(161, 65);
            this.btnShowReminder.TabIndex = 61;
            this.btnShowReminder.Text = "نمایش ";
            this.btnShowReminder.UseVisualStyleBackColor = false;
            this.btnShowReminder.Click += new System.EventHandler(this.btnShowReminder_Click);
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblReminder.Font = new System.Drawing.Font("B Roya", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReminder.Location = new System.Drawing.Point(976, 56);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(264, 66);
            this.lblReminder.TabIndex = 58;
            this.lblReminder.Text = "یادآوری مراجعات";
            this.lblReminder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgvReminder
            // 
            this.dgvReminder.AllowUserToAddRows = false;
            this.dgvReminder.AllowUserToDeleteRows = false;
            this.dgvReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminder.Location = new System.Drawing.Point(134, 231);
            this.dgvReminder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvReminder.Name = "dgvReminder";
            this.dgvReminder.ReadOnly = true;
            this.dgvReminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvReminder.RowHeadersWidth = 51;
            this.dgvReminder.RowTemplate.Height = 24;
            this.dgvReminder.Size = new System.Drawing.Size(606, 452);
            this.dgvReminder.TabIndex = 67;
            // 
            // clinicDataSet10
            // 
            this.clinicDataSet10.DataSetName = "clinicDataSet10";
            this.clinicDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblReminderHelp
            // 
            this.lblReminderHelp.AutoSize = true;
            this.lblReminderHelp.BackColor = System.Drawing.SystemColors.Menu;
            this.lblReminderHelp.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblReminderHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblReminderHelp.Location = new System.Drawing.Point(842, 231);
            this.lblReminderHelp.Name = "lblReminderHelp";
            this.lblReminderHelp.Size = new System.Drawing.Size(412, 46);
            this.lblReminderHelp.TabIndex = 59;
            this.lblReminderHelp.Text = "لطفا تاریخ مورد نظر خود را انتخاب نمایید ";
            this.lblReminderHelp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpReminder
            // 
            this.dtpReminder.AnchorSize = new System.Drawing.Size(310, 55);
            this.dtpReminder.BackColor = System.Drawing.SystemColors.Menu;
            this.dtpReminder.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpReminder.CalendarBorderColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarDayRectTickness = 2F;
            this.dtpReminder.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpReminder.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpReminder.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpReminder.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpReminder.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpReminder.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpReminder.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpReminder.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpReminder.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpReminder.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpReminder.CalendarShowToday = true;
            this.dtpReminder.CalendarShowTodayRect = true;
            this.dtpReminder.CalendarShowToolTips = false;
            this.dtpReminder.CalendarShowTrailing = true;
            this.dtpReminder.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpReminder.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminder.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpReminder.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminder.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpReminder.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpReminder.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpReminder.CalendarTitleFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpReminder.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarTodayBackColor = System.Drawing.SystemColors.Control;
            this.dtpReminder.CalendarTodayFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpReminder.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpReminder.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpReminder.CalendarTodayRectTickness = 2F;
            this.dtpReminder.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpReminder.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpReminder.CalendarWeekDaysBackColor = System.Drawing.SystemColors.Control;
            this.dtpReminder.CalendarWeekDaysFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpReminder.CalendarWeekDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpReminder.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpReminder.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpReminder.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpReminder.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpReminder.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpReminder.ClearButtonImage")));
            this.dtpReminder.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpReminder.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpReminder.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpReminder.ClearButtonText = "";
            this.dtpReminder.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpReminder.ClearButtonToolTip = "";
            this.dtpReminder.ClearButtonWidth = 17;
            this.dtpReminder.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpReminder.CustomFormat = "yyyy-M-d";
            this.dtpReminder.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpReminder.DropDownClosedWhenClickOnDays = false;
            this.dtpReminder.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpReminder.Font = new System.Drawing.Font("B Roya", 14F, System.Drawing.FontStyle.Bold);
            this.dtpReminder.ForeColor = System.Drawing.Color.DimGray;
            this.dtpReminder.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpReminder.Format4Binding = "yyyy-MM-dd";
            this.dtpReminder.Location = new System.Drawing.Point(884, 302);
            this.dtpReminder.Margin = new System.Windows.Forms.Padding(6);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.RightToLeftLayout = true;
            this.dtpReminder.ShowClearButton = false;
            this.dtpReminder.Size = new System.Drawing.Size(310, 55);
            this.dtpReminder.TabIndex = 66;
            this.dtpReminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpReminder.TextWhenClearButtonClicked = "";
            this.dtpReminder.Load += new System.EventHandler(this.dtpReminder_Load);
            // 
            // nobatBindingSource
            // 
            this.nobatBindingSource.DataMember = "Nobat";
            this.nobatBindingSource.DataSource = this.clinicDataSet10;
            // 
            // nobatTableAdapter
            // 
            this.nobatTableAdapter.ClearBeforeFill = true;
            // 
            // formReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.dgvReminder);
            this.Controls.Add(this.dtpReminder);
            this.Controls.Add(this.btnBackReminder);
            this.Controls.Add(this.btnShowReminder);
            this.Controls.Add(this.lblReminderHelp);
            this.Controls.Add(this.lblReminder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مراجعات روزانه";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formReminder_FormClosing);
            this.Load += new System.EventHandler(this.formReminder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nobatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackReminder;
        private System.Windows.Forms.Button btnShowReminder;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.DataGridView dgvReminder;
        private clinicDataSet10 clinicDataSet10;
        private System.Windows.Forms.Label lblReminderHelp;
        private BehComponents.DateTimePickerX dtpReminder;
        private System.Windows.Forms.BindingSource nobatBindingSource;
        private clinicDataSet10TableAdapters.NobatTableAdapter nobatTableAdapter;
    }
}