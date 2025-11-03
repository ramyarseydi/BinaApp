
namespace binaiisanji
{
    partial class formFileOpening1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFileOpening1));
            this.lblFileGenration = new System.Windows.Forms.Label();
            this.tbxPatientFname = new System.Windows.Forms.TextBox();
            this.tbxPatientLname = new System.Windows.Forms.TextBox();
            this.tbxPatientAge = new System.Windows.Forms.TextBox();
            this.tbxPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxPatientAddress = new System.Windows.Forms.TextBox();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.btnSaveFIleGen = new System.Windows.Forms.Button();
            this.btnBackFileGen = new System.Windows.Forms.Button();
            this.rdbPatientGenderM = new System.Windows.Forms.RadioButton();
            this.rdbPatientGenderF = new System.Windows.Forms.RadioButton();
            this.tbxPatientSickness = new System.Windows.Forms.TextBox();
            this.cmbInsourence = new System.Windows.Forms.ComboBox();
            this.lblNextAppointment = new System.Windows.Forms.Label();
            this.lblFirstAppointment = new System.Windows.Forms.Label();
            this.dtpFappointment = new BehComponents.DateTimePickerX();
            this.dtpNextAppointment = new BehComponents.DateTimePickerX();
            this.SuspendLayout();
            // 
            // lblFileGenration
            // 
            resources.ApplyResources(this.lblFileGenration, "lblFileGenration");
            this.lblFileGenration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFileGenration.Name = "lblFileGenration";
            // 
            // tbxPatientFname
            // 
            this.tbxPatientFname.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbxPatientFname, "tbxPatientFname");
            this.tbxPatientFname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientFname.Name = "tbxPatientFname";
            this.tbxPatientFname.Enter += new System.EventHandler(this.tbxPatientFname_Enter);
            this.tbxPatientFname.Leave += new System.EventHandler(this.tbxPatientFname_Leave);
            // 
            // tbxPatientLname
            // 
            this.tbxPatientLname.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbxPatientLname, "tbxPatientLname");
            this.tbxPatientLname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientLname.Name = "tbxPatientLname";
            this.tbxPatientLname.Enter += new System.EventHandler(this.tbxPatientLname_Enter);
            this.tbxPatientLname.Leave += new System.EventHandler(this.tbxPatientLname_Leave);
            // 
            // tbxPatientAge
            // 
            this.tbxPatientAge.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbxPatientAge, "tbxPatientAge");
            this.tbxPatientAge.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientAge.Name = "tbxPatientAge";
            this.tbxPatientAge.Enter += new System.EventHandler(this.tbxPatientAge_Enter);
            this.tbxPatientAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPatientAge_KeyPress);
            this.tbxPatientAge.Leave += new System.EventHandler(this.tbxPatientAge_Leave);
            // 
            // tbxPatientPhoneNumber
            // 
            this.tbxPatientPhoneNumber.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbxPatientPhoneNumber, "tbxPatientPhoneNumber");
            this.tbxPatientPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientPhoneNumber.Name = "tbxPatientPhoneNumber";
            this.tbxPatientPhoneNumber.Enter += new System.EventHandler(this.tbxPatientPhoneNumber_Enter);
            this.tbxPatientPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPatientPhoneNumber_KeyPress);
            this.tbxPatientPhoneNumber.Leave += new System.EventHandler(this.tbxPatientPhoneNumber_Leave);
            // 
            // tbxPatientAddress
            // 
            this.tbxPatientAddress.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbxPatientAddress, "tbxPatientAddress");
            this.tbxPatientAddress.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientAddress.Name = "tbxPatientAddress";
            this.tbxPatientAddress.Enter += new System.EventHandler(this.tbxPatientAddress_Enter);
            this.tbxPatientAddress.Leave += new System.EventHandler(this.tbxPatientAddress_Leave);
            // 
            // lblPatientGender
            // 
            resources.ApplyResources(this.lblPatientGender, "lblPatientGender");
            this.lblPatientGender.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPatientGender.Name = "lblPatientGender";
            // 
            // btnSaveFIleGen
            // 
            this.btnSaveFIleGen.BackColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.btnSaveFIleGen, "btnSaveFIleGen");
            this.btnSaveFIleGen.ForeColor = System.Drawing.Color.Snow;
            this.btnSaveFIleGen.Name = "btnSaveFIleGen";
            this.btnSaveFIleGen.UseVisualStyleBackColor = false;
            this.btnSaveFIleGen.Click += new System.EventHandler(this.btnSaveFIleGen_Click);
            // 
            // btnBackFileGen
            // 
            this.btnBackFileGen.BackColor = System.Drawing.SystemColors.MenuText;
            resources.ApplyResources(this.btnBackFileGen, "btnBackFileGen");
            this.btnBackFileGen.ForeColor = System.Drawing.Color.Snow;
            this.btnBackFileGen.Name = "btnBackFileGen";
            this.btnBackFileGen.UseVisualStyleBackColor = false;
            this.btnBackFileGen.Click += new System.EventHandler(this.btnBackFileGen_Click);
            // 
            // rdbPatientGenderM
            // 
            resources.ApplyResources(this.rdbPatientGenderM, "rdbPatientGenderM");
            this.rdbPatientGenderM.Name = "rdbPatientGenderM";
            this.rdbPatientGenderM.TabStop = true;
            this.rdbPatientGenderM.UseVisualStyleBackColor = true;
            // 
            // rdbPatientGenderF
            // 
            resources.ApplyResources(this.rdbPatientGenderF, "rdbPatientGenderF");
            this.rdbPatientGenderF.Name = "rdbPatientGenderF";
            this.rdbPatientGenderF.TabStop = true;
            this.rdbPatientGenderF.UseVisualStyleBackColor = true;
            // 
            // tbxPatientSickness
            // 
            this.tbxPatientSickness.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.tbxPatientSickness, "tbxPatientSickness");
            this.tbxPatientSickness.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientSickness.Name = "tbxPatientSickness";
            this.tbxPatientSickness.Enter += new System.EventHandler(this.tbxPatientSickness_Enter);
            this.tbxPatientSickness.Leave += new System.EventHandler(this.tbxPatientSickness_Leave);
            // 
            // cmbInsourence
            // 
            this.cmbInsourence.BackColor = System.Drawing.SystemColors.Menu;
            resources.ApplyResources(this.cmbInsourence, "cmbInsourence");
            this.cmbInsourence.ForeColor = System.Drawing.Color.DimGray;
            this.cmbInsourence.FormattingEnabled = true;
            this.cmbInsourence.Name = "cmbInsourence";
            this.cmbInsourence.SelectedIndexChanged += new System.EventHandler(this.cmbInsourence_SelectedIndexChanged);
            // 
            // lblNextAppointment
            // 
            resources.ApplyResources(this.lblNextAppointment, "lblNextAppointment");
            this.lblNextAppointment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNextAppointment.Name = "lblNextAppointment";
            // 
            // lblFirstAppointment
            // 
            resources.ApplyResources(this.lblFirstAppointment, "lblFirstAppointment");
            this.lblFirstAppointment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFirstAppointment.Name = "lblFirstAppointment";
            // 
            // dtpFappointment
            // 
            this.dtpFappointment.AnchorSize = new System.Drawing.Size(310, 55);
            this.dtpFappointment.BackColor = System.Drawing.SystemColors.Menu;
            this.dtpFappointment.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpFappointment.CalendarBorderColor = System.Drawing.Color.Black;
            this.dtpFappointment.CalendarDayRectTickness = 2F;
            this.dtpFappointment.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpFappointment.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFappointment.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpFappointment.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpFappointment.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpFappointment.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpFappointment.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpFappointment.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpFappointment.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpFappointment.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpFappointment.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFappointment.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFappointment.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpFappointment.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFappointment.CalendarShowToday = true;
            this.dtpFappointment.CalendarShowTodayRect = true;
            this.dtpFappointment.CalendarShowToolTips = false;
            this.dtpFappointment.CalendarShowTrailing = true;
            this.dtpFappointment.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpFappointment.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFappointment.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpFappointment.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFappointment.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFappointment.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpFappointment.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpFappointment.CalendarTitleFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFappointment.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpFappointment.CalendarTodayBackColor = System.Drawing.SystemColors.Control;
            this.dtpFappointment.CalendarTodayFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFappointment.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpFappointment.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpFappointment.CalendarTodayRectTickness = 2F;
            this.dtpFappointment.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpFappointment.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpFappointment.CalendarWeekDaysBackColor = System.Drawing.SystemColors.Control;
            this.dtpFappointment.CalendarWeekDaysFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFappointment.CalendarWeekDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpFappointment.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpFappointment.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpFappointment.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpFappointment.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpFappointment.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpFappointment.ClearButtonImage")));
            this.dtpFappointment.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFappointment.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpFappointment.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpFappointment.ClearButtonText = "";
            this.dtpFappointment.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFappointment.ClearButtonToolTip = "";
            this.dtpFappointment.ClearButtonWidth = 17;
            this.dtpFappointment.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpFappointment.CustomFormat = "yyyy/MM/dd";
            this.dtpFappointment.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpFappointment.DropDownClosedWhenClickOnDays = false;
            this.dtpFappointment.DropDownClosedWhenSelectedDateChanged = false;
            resources.ApplyResources(this.dtpFappointment, "dtpFappointment");
            this.dtpFappointment.ForeColor = System.Drawing.Color.DimGray;
            this.dtpFappointment.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpFappointment.Format4Binding = "yyyy/MM/dd";
            this.dtpFappointment.Name = "dtpFappointment";
            this.dtpFappointment.RightToLeftLayout = true;
            this.dtpFappointment.ShowClearButton = false;
            this.dtpFappointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpFappointment.TextWhenClearButtonClicked = "";
            // 
            // dtpNextAppointment
            // 
            this.dtpNextAppointment.AnchorSize = new System.Drawing.Size(310, 55);
            this.dtpNextAppointment.BackColor = System.Drawing.SystemColors.Menu;
            this.dtpNextAppointment.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpNextAppointment.CalendarBorderColor = System.Drawing.Color.Black;
            this.dtpNextAppointment.CalendarDayRectTickness = 2F;
            this.dtpNextAppointment.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpNextAppointment.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpNextAppointment.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpNextAppointment.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpNextAppointment.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpNextAppointment.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpNextAppointment.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpNextAppointment.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpNextAppointment.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpNextAppointment.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpNextAppointment.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpNextAppointment.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpNextAppointment.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpNextAppointment.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpNextAppointment.CalendarShowToday = true;
            this.dtpNextAppointment.CalendarShowTodayRect = true;
            this.dtpNextAppointment.CalendarShowToolTips = false;
            this.dtpNextAppointment.CalendarShowTrailing = true;
            this.dtpNextAppointment.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpNextAppointment.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpNextAppointment.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpNextAppointment.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpNextAppointment.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpNextAppointment.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpNextAppointment.CalendarTitleBackColor = System.Drawing.SystemColors.Control;
            this.dtpNextAppointment.CalendarTitleFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpNextAppointment.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpNextAppointment.CalendarTodayBackColor = System.Drawing.SystemColors.Control;
            this.dtpNextAppointment.CalendarTodayFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpNextAppointment.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpNextAppointment.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpNextAppointment.CalendarTodayRectTickness = 2F;
            this.dtpNextAppointment.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpNextAppointment.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpNextAppointment.CalendarWeekDaysBackColor = System.Drawing.SystemColors.Control;
            this.dtpNextAppointment.CalendarWeekDaysFont = new System.Drawing.Font("B Roya", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpNextAppointment.CalendarWeekDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpNextAppointment.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpNextAppointment.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpNextAppointment.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpNextAppointment.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpNextAppointment.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpNextAppointment.ClearButtonImage")));
            this.dtpNextAppointment.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpNextAppointment.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpNextAppointment.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpNextAppointment.ClearButtonText = "";
            this.dtpNextAppointment.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpNextAppointment.ClearButtonToolTip = "";
            this.dtpNextAppointment.ClearButtonWidth = 17;
            this.dtpNextAppointment.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpNextAppointment.CustomFormat = "yyyy/MM/dd";
            this.dtpNextAppointment.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpNextAppointment.DropDownClosedWhenClickOnDays = false;
            this.dtpNextAppointment.DropDownClosedWhenSelectedDateChanged = false;
            resources.ApplyResources(this.dtpNextAppointment, "dtpNextAppointment");
            this.dtpNextAppointment.ForeColor = System.Drawing.Color.DimGray;
            this.dtpNextAppointment.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpNextAppointment.Format4Binding = "yyyy-MM-dd";
            this.dtpNextAppointment.Name = "dtpNextAppointment";
            this.dtpNextAppointment.RightToLeftLayout = true;
            this.dtpNextAppointment.ShowClearButton = false;
            this.dtpNextAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpNextAppointment.TextWhenClearButtonClicked = "";
            // 
            // formFileOpening1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpNextAppointment);
            this.Controls.Add(this.dtpFappointment);
            this.Controls.Add(this.lblNextAppointment);
            this.Controls.Add(this.lblFirstAppointment);
            this.Controls.Add(this.cmbInsourence);
            this.Controls.Add(this.tbxPatientSickness);
            this.Controls.Add(this.rdbPatientGenderF);
            this.Controls.Add(this.rdbPatientGenderM);
            this.Controls.Add(this.btnBackFileGen);
            this.Controls.Add(this.btnSaveFIleGen);
            this.Controls.Add(this.lblPatientGender);
            this.Controls.Add(this.tbxPatientAddress);
            this.Controls.Add(this.tbxPatientPhoneNumber);
            this.Controls.Add(this.tbxPatientAge);
            this.Controls.Add(this.tbxPatientLname);
            this.Controls.Add(this.tbxPatientFname);
            this.Controls.Add(this.lblFileGenration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "formFileOpening1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formFileOpening1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFileGenration;
        private System.Windows.Forms.TextBox tbxPatientFname;
        private System.Windows.Forms.TextBox tbxPatientLname;
        private System.Windows.Forms.TextBox tbxPatientAge;
        private System.Windows.Forms.TextBox tbxPatientPhoneNumber;
        private System.Windows.Forms.TextBox tbxPatientAddress;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.Button btnSaveFIleGen;
        private System.Windows.Forms.Button btnBackFileGen;
        private System.Windows.Forms.RadioButton rdbPatientGenderM;
        private System.Windows.Forms.RadioButton rdbPatientGenderF;
        private System.Windows.Forms.TextBox tbxPatientSickness;
        private System.Windows.Forms.ComboBox cmbInsourence;
        private System.Windows.Forms.Label lblNextAppointment;
        private System.Windows.Forms.Label lblFirstAppointment;
        private BehComponents.DateTimePickerX dtpFappointment;
        private BehComponents.DateTimePickerX dtpNextAppointment;
    }
}