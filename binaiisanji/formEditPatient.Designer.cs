
namespace binaiisanji
{
    partial class formEditPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditPatient));
            this.dtpNextAppointment = new BehComponents.DateTimePickerX();
            this.dtpFappointment = new BehComponents.DateTimePickerX();
            this.lblNextAppointment = new System.Windows.Forms.Label();
            this.lblFirstAppointment = new System.Windows.Forms.Label();
            this.cmbInsourence = new System.Windows.Forms.ComboBox();
            this.tbxPatientSickness = new System.Windows.Forms.TextBox();
            this.rdbPatientGenderF = new System.Windows.Forms.RadioButton();
            this.rdbPatientGenderM = new System.Windows.Forms.RadioButton();
            this.lblPatientGender = new System.Windows.Forms.Label();
            this.tbxPatientAddress = new System.Windows.Forms.TextBox();
            this.tbxPatientPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxPatientAge = new System.Windows.Forms.TextBox();
            this.tbxPatientLname = new System.Windows.Forms.TextBox();
            this.tbxPatientFname = new System.Windows.Forms.TextBox();
            this.lblFileGenration = new System.Windows.Forms.Label();
            this.tbxfileNumber = new System.Windows.Forms.TextBox();
            this.btnEditBack = new System.Windows.Forms.Button();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnEditShow = new System.Windows.Forms.Button();
            this.btnDeletepatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpNextAppointment
            // 
            this.dtpNextAppointment.AnchorSize = new System.Drawing.Size(310, 62);
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
            this.dtpNextAppointment.Font = new System.Drawing.Font("B Roya", 14F, System.Drawing.FontStyle.Bold);
            this.dtpNextAppointment.ForeColor = System.Drawing.Color.DimGray;
            this.dtpNextAppointment.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpNextAppointment.Format4Binding = "yyyy-MM-dd";
            this.dtpNextAppointment.Location = new System.Drawing.Point(76, 605);
            this.dtpNextAppointment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpNextAppointment.Name = "dtpNextAppointment";
            this.dtpNextAppointment.RightToLeftLayout = true;
            this.dtpNextAppointment.ShowClearButton = false;
            this.dtpNextAppointment.Size = new System.Drawing.Size(310, 62);
            this.dtpNextAppointment.TabIndex = 66;
            this.dtpNextAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpNextAppointment.TextWhenClearButtonClicked = "";
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
            this.dtpFappointment.Font = new System.Drawing.Font("B Roya", 14F, System.Drawing.FontStyle.Bold);
            this.dtpFappointment.ForeColor = System.Drawing.Color.DimGray;
            this.dtpFappointment.Format = BehComponents.DateTimePickerX.FormatDate.Custom;
            this.dtpFappointment.Format4Binding = "yyyy/MM/dd";
            this.dtpFappointment.Location = new System.Drawing.Point(76, 481);
            this.dtpFappointment.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFappointment.Name = "dtpFappointment";
            this.dtpFappointment.RightToLeftLayout = true;
            this.dtpFappointment.ShowClearButton = false;
            this.dtpFappointment.Size = new System.Drawing.Size(310, 55);
            this.dtpFappointment.TabIndex = 80;
            this.dtpFappointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dtpFappointment.TextWhenClearButtonClicked = "";
            // 
            // lblNextAppointment
            // 
            this.lblNextAppointment.AutoSize = true;
            this.lblNextAppointment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblNextAppointment.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblNextAppointment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNextAppointment.Location = new System.Drawing.Point(220, 549);
            this.lblNextAppointment.Name = "lblNextAppointment";
            this.lblNextAppointment.Size = new System.Drawing.Size(210, 46);
            this.lblNextAppointment.TabIndex = 79;
            this.lblNextAppointment.Text = "تاریخ مراجعه بعدی ";
            this.lblNextAppointment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFirstAppointment
            // 
            this.lblFirstAppointment.AutoSize = true;
            this.lblFirstAppointment.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFirstAppointment.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblFirstAppointment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFirstAppointment.Location = new System.Drawing.Point(225, 425);
            this.lblFirstAppointment.Name = "lblFirstAppointment";
            this.lblFirstAppointment.Size = new System.Drawing.Size(204, 46);
            this.lblFirstAppointment.TabIndex = 78;
            this.lblFirstAppointment.Text = "تاریخ اولین مراجعه ";
            this.lblFirstAppointment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbInsourence
            // 
            this.cmbInsourence.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbInsourence.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.cmbInsourence.ForeColor = System.Drawing.Color.DimGray;
            this.cmbInsourence.FormattingEnabled = true;
            this.cmbInsourence.Location = new System.Drawing.Point(656, 560);
            this.cmbInsourence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbInsourence.Name = "cmbInsourence";
            this.cmbInsourence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbInsourence.Size = new System.Drawing.Size(248, 54);
            this.cmbInsourence.TabIndex = 77;
            // 
            // tbxPatientSickness
            // 
            this.tbxPatientSickness.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientSickness.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientSickness.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientSickness.Location = new System.Drawing.Point(56, 345);
            this.tbxPatientSickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientSickness.Name = "tbxPatientSickness";
            this.tbxPatientSickness.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientSickness.Size = new System.Drawing.Size(516, 57);
            this.tbxPatientSickness.TabIndex = 76;
            this.tbxPatientSickness.Text = "  شرح بیماری    ";
            this.tbxPatientSickness.Enter += new System.EventHandler(this.tbxPatientSickness_Enter);
            this.tbxPatientSickness.Leave += new System.EventHandler(this.tbxPatientSickness_Leave);
            // 
            // rdbPatientGenderF
            // 
            this.rdbPatientGenderF.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold);
            this.rdbPatientGenderF.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbPatientGenderF.Location = new System.Drawing.Point(489, 526);
            this.rdbPatientGenderF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbPatientGenderF.Name = "rdbPatientGenderF";
            this.rdbPatientGenderF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPatientGenderF.Size = new System.Drawing.Size(84, 44);
            this.rdbPatientGenderF.TabIndex = 75;
            this.rdbPatientGenderF.TabStop = true;
            this.rdbPatientGenderF.Text = "زن";
            this.rdbPatientGenderF.UseVisualStyleBackColor = true;
            // 
            // rdbPatientGenderM
            // 
            this.rdbPatientGenderM.Font = new System.Drawing.Font("B Roya", 12F, System.Drawing.FontStyle.Bold);
            this.rdbPatientGenderM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rdbPatientGenderM.Location = new System.Drawing.Point(489, 488);
            this.rdbPatientGenderM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdbPatientGenderM.Name = "rdbPatientGenderM";
            this.rdbPatientGenderM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPatientGenderM.Size = new System.Drawing.Size(84, 44);
            this.rdbPatientGenderM.TabIndex = 74;
            this.rdbPatientGenderM.TabStop = true;
            this.rdbPatientGenderM.Text = "مرد";
            this.rdbPatientGenderM.UseVisualStyleBackColor = true;
            // 
            // lblPatientGender
            // 
            this.lblPatientGender.AutoSize = true;
            this.lblPatientGender.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPatientGender.Font = new System.Drawing.Font("B Roya", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblPatientGender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPatientGender.Location = new System.Drawing.Point(488, 425);
            this.lblPatientGender.Name = "lblPatientGender";
            this.lblPatientGender.Size = new System.Drawing.Size(90, 46);
            this.lblPatientGender.TabIndex = 73;
            this.lblPatientGender.Text = "جنسیت";
            this.lblPatientGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxPatientAddress
            // 
            this.tbxPatientAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientAddress.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientAddress.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientAddress.Location = new System.Drawing.Point(56, 211);
            this.tbxPatientAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientAddress.Multiline = true;
            this.tbxPatientAddress.Name = "tbxPatientAddress";
            this.tbxPatientAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientAddress.Size = new System.Drawing.Size(516, 106);
            this.tbxPatientAddress.TabIndex = 72;
            this.tbxPatientAddress.Text = "  آدرس     ";
            this.tbxPatientAddress.Enter += new System.EventHandler(this.tbxPatientAddress_Enter_1);
            this.tbxPatientAddress.Leave += new System.EventHandler(this.tbxPatientAddress_Leave_1);
            // 
            // tbxPatientPhoneNumber
            // 
            this.tbxPatientPhoneNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientPhoneNumber.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientPhoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientPhoneNumber.Location = new System.Drawing.Point(656, 465);
            this.tbxPatientPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientPhoneNumber.Name = "tbxPatientPhoneNumber";
            this.tbxPatientPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientPhoneNumber.Size = new System.Drawing.Size(246, 57);
            this.tbxPatientPhoneNumber.TabIndex = 71;
            this.tbxPatientPhoneNumber.Text = "  شماره تماس";
            this.tbxPatientPhoneNumber.Enter += new System.EventHandler(this.tbxPatientPhoneNumber_Enter_1);
            this.tbxPatientPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPatientPhoneNumber_KeyPress);
            this.tbxPatientPhoneNumber.Leave += new System.EventHandler(this.tbxPatientPhoneNumber_Leave_1);
            // 
            // tbxPatientAge
            // 
            this.tbxPatientAge.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientAge.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientAge.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientAge.Location = new System.Drawing.Point(656, 379);
            this.tbxPatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientAge.Name = "tbxPatientAge";
            this.tbxPatientAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientAge.Size = new System.Drawing.Size(246, 57);
            this.tbxPatientAge.TabIndex = 70;
            this.tbxPatientAge.Text = "  سن";
            this.tbxPatientAge.Enter += new System.EventHandler(this.tbxPatientAge_Enter_1);
            this.tbxPatientAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPatientAge_KeyPress);
            this.tbxPatientAge.Leave += new System.EventHandler(this.tbxPatientAge_Leave_1);
            // 
            // tbxPatientLname
            // 
            this.tbxPatientLname.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientLname.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientLname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientLname.Location = new System.Drawing.Point(656, 295);
            this.tbxPatientLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientLname.Name = "tbxPatientLname";
            this.tbxPatientLname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientLname.Size = new System.Drawing.Size(248, 57);
            this.tbxPatientLname.TabIndex = 69;
            this.tbxPatientLname.Text = "  نام خانوادگی   ";
            this.tbxPatientLname.Enter += new System.EventHandler(this.tbxPatientLname_Enter_1);
            this.tbxPatientLname.Leave += new System.EventHandler(this.tbxPatientLname_Leave_1);
            // 
            // tbxPatientFname
            // 
            this.tbxPatientFname.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxPatientFname.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxPatientFname.ForeColor = System.Drawing.Color.DimGray;
            this.tbxPatientFname.Location = new System.Drawing.Point(656, 211);
            this.tbxPatientFname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPatientFname.Name = "tbxPatientFname";
            this.tbxPatientFname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxPatientFname.Size = new System.Drawing.Size(248, 57);
            this.tbxPatientFname.TabIndex = 68;
            this.tbxPatientFname.Text = "  نام  ";
            this.tbxPatientFname.Enter += new System.EventHandler(this.tbxPatientFname_Enter_1);
            this.tbxPatientFname.Leave += new System.EventHandler(this.tbxPatientFname_Leave_1);
            // 
            // lblFileGenration
            // 
            this.lblFileGenration.AutoSize = true;
            this.lblFileGenration.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFileGenration.Font = new System.Drawing.Font("B Roya", 19.8F, System.Drawing.FontStyle.Bold);
            this.lblFileGenration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFileGenration.Location = new System.Drawing.Point(940, 50);
            this.lblFileGenration.Name = "lblFileGenration";
            this.lblFileGenration.Size = new System.Drawing.Size(314, 66);
            this.lblFileGenration.TabIndex = 67;
            this.lblFileGenration.Text = "ویرایش اطلاعات بیمار";
            this.lblFileGenration.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxfileNumber
            // 
            this.tbxfileNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.tbxfileNumber.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.tbxfileNumber.ForeColor = System.Drawing.Color.DimGray;
            this.tbxfileNumber.Location = new System.Drawing.Point(993, 345);
            this.tbxfileNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxfileNumber.Name = "tbxfileNumber";
            this.tbxfileNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxfileNumber.Size = new System.Drawing.Size(248, 57);
            this.tbxfileNumber.TabIndex = 82;
            this.tbxfileNumber.Text = "  شماره پرونده";
            this.tbxfileNumber.Enter += new System.EventHandler(this.tbxfileNumber_Enter);
            this.tbxfileNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxfileNumber_KeyPress);
            this.tbxfileNumber.Leave += new System.EventHandler(this.tbxfileNumber_Leave);
            // 
            // btnEditBack
            // 
            this.btnEditBack.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnEditBack.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnEditBack.ForeColor = System.Drawing.Color.Snow;
            this.btnEditBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditBack.Location = new System.Drawing.Point(1065, 771);
            this.btnEditBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditBack.Name = "btnEditBack";
            this.btnEditBack.Size = new System.Drawing.Size(161, 65);
            this.btnEditBack.TabIndex = 85;
            this.btnEditBack.Text = "بازگشت";
            this.btnEditBack.UseVisualStyleBackColor = false;
            this.btnEditBack.Click += new System.EventHandler(this.btnEditBack_Click);
            // 
            // btnEditSave
            // 
            this.btnEditSave.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnEditSave.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnEditSave.ForeColor = System.Drawing.Color.Snow;
            this.btnEditSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditSave.Location = new System.Drawing.Point(81, 771);
            this.btnEditSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(161, 65);
            this.btnEditSave.TabIndex = 84;
            this.btnEditSave.Text = "ذخیره";
            this.btnEditSave.UseVisualStyleBackColor = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // btnEditShow
            // 
            this.btnEditShow.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnEditShow.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnEditShow.ForeColor = System.Drawing.Color.Snow;
            this.btnEditShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEditShow.Location = new System.Drawing.Point(1043, 441);
            this.btnEditShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditShow.Name = "btnEditShow";
            this.btnEditShow.Size = new System.Drawing.Size(161, 65);
            this.btnEditShow.TabIndex = 86;
            this.btnEditShow.Text = "نمایش";
            this.btnEditShow.UseVisualStyleBackColor = false;
            this.btnEditShow.Click += new System.EventHandler(this.btnEditShow_Click);
            // 
            // btnDeletepatient
            // 
            this.btnDeletepatient.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnDeletepatient.Font = new System.Drawing.Font("B Roya", 15F, System.Drawing.FontStyle.Bold);
            this.btnDeletepatient.ForeColor = System.Drawing.Color.Snow;
            this.btnDeletepatient.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDeletepatient.Location = new System.Drawing.Point(561, 771);
            this.btnDeletepatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletepatient.Name = "btnDeletepatient";
            this.btnDeletepatient.Size = new System.Drawing.Size(161, 65);
            this.btnDeletepatient.TabIndex = 87;
            this.btnDeletepatient.Text = "حذف";
            this.btnDeletepatient.UseVisualStyleBackColor = false;
            this.btnDeletepatient.Click += new System.EventHandler(this.btnDeletepatient_Click);
            // 
            // formEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1279, 879);
            this.Controls.Add(this.btnDeletepatient);
            this.Controls.Add(this.btnEditShow);
            this.Controls.Add(this.btnEditBack);
            this.Controls.Add(this.btnEditSave);
            this.Controls.Add(this.tbxfileNumber);
            this.Controls.Add(this.dtpNextAppointment);
            this.Controls.Add(this.dtpFappointment);
            this.Controls.Add(this.lblNextAppointment);
            this.Controls.Add(this.lblFirstAppointment);
            this.Controls.Add(this.cmbInsourence);
            this.Controls.Add(this.tbxPatientSickness);
            this.Controls.Add(this.rdbPatientGenderF);
            this.Controls.Add(this.rdbPatientGenderM);
            this.Controls.Add(this.lblPatientGender);
            this.Controls.Add(this.tbxPatientAddress);
            this.Controls.Add(this.tbxPatientPhoneNumber);
            this.Controls.Add(this.tbxPatientAge);
            this.Controls.Add(this.tbxPatientLname);
            this.Controls.Add(this.tbxPatientFname);
            this.Controls.Add(this.lblFileGenration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "formEditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش لیست بیماران ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formEditPatient_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BehComponents.DateTimePickerX dtpNextAppointment;
        private BehComponents.DateTimePickerX dtpFappointment;
        private System.Windows.Forms.Label lblNextAppointment;
        private System.Windows.Forms.Label lblFirstAppointment;
        private System.Windows.Forms.ComboBox cmbInsourence;
        private System.Windows.Forms.TextBox tbxPatientSickness;
        private System.Windows.Forms.RadioButton rdbPatientGenderF;
        private System.Windows.Forms.RadioButton rdbPatientGenderM;
        private System.Windows.Forms.Label lblPatientGender;
        private System.Windows.Forms.TextBox tbxPatientAddress;
        private System.Windows.Forms.TextBox tbxPatientPhoneNumber;
        private System.Windows.Forms.TextBox tbxPatientAge;
        private System.Windows.Forms.TextBox tbxPatientLname;
        private System.Windows.Forms.TextBox tbxPatientFname;
        private System.Windows.Forms.Label lblFileGenration;
        private System.Windows.Forms.TextBox tbxfileNumber;
        private System.Windows.Forms.Button btnEditBack;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnEditShow;
        private System.Windows.Forms.Button btnDeletepatient;
    }
}