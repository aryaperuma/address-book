namespace PersonalAddressBook
{
    partial class frmPersonalAddressBook
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
            this.tcAddressBook = new System.Windows.Forms.TabControl();
            this.tpTbAddContact = new System.Windows.Forms.TabPage();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.gbContactInfo = new System.Windows.Forms.GroupBox();
            this.lblAddBday = new System.Windows.Forms.Label();
            this.txtAddInstaHandle = new System.Windows.Forms.TextBox();
            this.lblAddInstaHandle = new System.Windows.Forms.Label();
            this.txtAddEmailAddress = new System.Windows.Forms.TextBox();
            this.txtAddCellNum = new System.Windows.Forms.TextBox();
            this.dtpAddBday = new System.Windows.Forms.DateTimePicker();
            this.lblAddEmailAddress = new System.Windows.Forms.Label();
            this.lblAddCellNum = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.lblAddFirstName = new System.Windows.Forms.Label();
            this.lblAddLastName = new System.Windows.Forms.Label();
            this.tpTbSearch = new System.Windows.Forms.TabPage();
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.lblSearchFirstName = new System.Windows.Forms.Label();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.lblTitleSearchContacts = new System.Windows.Forms.Label();
            this.gbShowContactInfo = new System.Windows.Forms.GroupBox();
            this.lblShowContactInstaHandle = new System.Windows.Forms.Label();
            this.lblShowContactEmailAddress = new System.Windows.Forms.Label();
            this.lblShowContactCellNum = new System.Windows.Forms.Label();
            this.lblShowContactInstaHandleTitle = new System.Windows.Forms.Label();
            this.lblShowContactEmailAddressTitle = new System.Windows.Forms.Label();
            this.lblShowContactCellNumTitle = new System.Windows.Forms.Label();
            this.btnSearchContact = new System.Windows.Forms.Button();
            this.tpTbSearchBdays = new System.Windows.Forms.TabPage();
            this.dtpSearchBday = new System.Windows.Forms.DateTimePicker();
            this.lblSearchBdayLastName = new System.Windows.Forms.Label();
            this.lblSearchBdayFirstName = new System.Windows.Forms.Label();
            this.txtSearchBdayFirstName = new System.Windows.Forms.TextBox();
            this.txtSearchBdayLastName = new System.Windows.Forms.TextBox();
            this.lblTitleSearchBday = new System.Windows.Forms.Label();
            this.btnSearchBday = new System.Windows.Forms.Button();
            this.tpTbShowBdays = new System.Windows.Forms.TabPage();
            this.lblTitleShowTodaysBdays = new System.Windows.Forms.Label();
            this.btnShowTodaysBdays = new System.Windows.Forms.Button();
            this.lbShowBdays = new System.Windows.Forms.ListBox();
            this.tpTbEditDel = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFindContactEditDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbDisplayContactInfo = new System.Windows.Forms.GroupBox();
            this.lblEditDelBday = new System.Windows.Forms.Label();
            this.txtEditDelInstaHandle = new System.Windows.Forms.TextBox();
            this.lblEditDelInstaHandle = new System.Windows.Forms.Label();
            this.txtEditDelEmailAddress = new System.Windows.Forms.TextBox();
            this.txtEditDelCellNum = new System.Windows.Forms.TextBox();
            this.dtpEditDelBday = new System.Windows.Forms.DateTimePicker();
            this.lblEditDelEmailAddress = new System.Windows.Forms.Label();
            this.lblEditDelCellNum = new System.Windows.Forms.Label();
            this.lblEditDelTitle = new System.Windows.Forms.Label();
            this.lblEditDelFirstName = new System.Windows.Forms.Label();
            this.lblEditDelLastName = new System.Windows.Forms.Label();
            this.txtEditDelLastName = new System.Windows.Forms.TextBox();
            this.txtEditDelFirstName = new System.Windows.Forms.TextBox();
            this.msFileTab = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msSaveToFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenText = new System.Windows.Forms.ToolStripMenuItem();
            this.msSaveBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.msOpenBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonalization = new System.Windows.Forms.ToolStripMenuItem();
            this.msPersonalizationColor = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tcAddressBook.SuspendLayout();
            this.tpTbAddContact.SuspendLayout();
            this.gbContactInfo.SuspendLayout();
            this.tpTbSearch.SuspendLayout();
            this.gbShowContactInfo.SuspendLayout();
            this.tpTbSearchBdays.SuspendLayout();
            this.tpTbShowBdays.SuspendLayout();
            this.tpTbEditDel.SuspendLayout();
            this.gbDisplayContactInfo.SuspendLayout();
            this.msFileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAddressBook
            // 
            this.tcAddressBook.Controls.Add(this.tpTbAddContact);
            this.tcAddressBook.Controls.Add(this.tpTbSearch);
            this.tcAddressBook.Controls.Add(this.tpTbSearchBdays);
            this.tcAddressBook.Controls.Add(this.tpTbShowBdays);
            this.tcAddressBook.Controls.Add(this.tpTbEditDel);
            this.tcAddressBook.Location = new System.Drawing.Point(12, 27);
            this.tcAddressBook.Name = "tcAddressBook";
            this.tcAddressBook.SelectedIndex = 0;
            this.tcAddressBook.Size = new System.Drawing.Size(686, 467);
            this.tcAddressBook.TabIndex = 0;
            // 
            // tpTbAddContact
            // 
            this.tpTbAddContact.Controls.Add(this.btnAddContact);
            this.tpTbAddContact.Controls.Add(this.gbContactInfo);
            this.tpTbAddContact.Location = new System.Drawing.Point(4, 25);
            this.tpTbAddContact.Name = "tpTbAddContact";
            this.tpTbAddContact.Padding = new System.Windows.Forms.Padding(3);
            this.tpTbAddContact.Size = new System.Drawing.Size(678, 438);
            this.tpTbAddContact.TabIndex = 0;
            this.tpTbAddContact.Text = "Add a Contact";
            this.tpTbAddContact.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(299, 378);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(124, 37);
            this.btnAddContact.TabIndex = 0;
            this.btnAddContact.Text = "Add";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // gbContactInfo
            // 
            this.gbContactInfo.Controls.Add(this.lblAddBday);
            this.gbContactInfo.Controls.Add(this.txtAddInstaHandle);
            this.gbContactInfo.Controls.Add(this.lblAddInstaHandle);
            this.gbContactInfo.Controls.Add(this.txtAddEmailAddress);
            this.gbContactInfo.Controls.Add(this.txtAddCellNum);
            this.gbContactInfo.Controls.Add(this.dtpAddBday);
            this.gbContactInfo.Controls.Add(this.lblAddEmailAddress);
            this.gbContactInfo.Controls.Add(this.lblAddCellNum);
            this.gbContactInfo.Controls.Add(this.txtAddFirstName);
            this.gbContactInfo.Controls.Add(this.txtAddLastName);
            this.gbContactInfo.Controls.Add(this.lblAddFirstName);
            this.gbContactInfo.Controls.Add(this.lblAddLastName);
            this.gbContactInfo.Location = new System.Drawing.Point(122, 23);
            this.gbContactInfo.Name = "gbContactInfo";
            this.gbContactInfo.Size = new System.Drawing.Size(475, 349);
            this.gbContactInfo.TabIndex = 8;
            this.gbContactInfo.TabStop = false;
            this.gbContactInfo.Text = "Contact Info";
            // 
            // lblAddBday
            // 
            this.lblAddBday.AutoSize = true;
            this.lblAddBday.Location = new System.Drawing.Point(212, 227);
            this.lblAddBday.Name = "lblAddBday";
            this.lblAddBday.Size = new System.Drawing.Size(64, 16);
            this.lblAddBday.TabIndex = 4;
            this.lblAddBday.Text = "* Birthday";
            // 
            // txtAddInstaHandle
            // 
            this.txtAddInstaHandle.Location = new System.Drawing.Point(263, 305);
            this.txtAddInstaHandle.Name = "txtAddInstaHandle";
            this.txtAddInstaHandle.Size = new System.Drawing.Size(181, 22);
            this.txtAddInstaHandle.TabIndex = 5;
            // 
            // lblAddInstaHandle
            // 
            this.lblAddInstaHandle.AutoSize = true;
            this.lblAddInstaHandle.Location = new System.Drawing.Point(110, 305);
            this.lblAddInstaHandle.Name = "lblAddInstaHandle";
            this.lblAddInstaHandle.Size = new System.Drawing.Size(113, 16);
            this.lblAddInstaHandle.TabIndex = 9;
            this.lblAddInstaHandle.Text = "Instagram Handle";
            // 
            // txtAddEmailAddress
            // 
            this.txtAddEmailAddress.Location = new System.Drawing.Point(263, 172);
            this.txtAddEmailAddress.Name = "txtAddEmailAddress";
            this.txtAddEmailAddress.Size = new System.Drawing.Size(181, 22);
            this.txtAddEmailAddress.TabIndex = 3;
            // 
            // txtAddCellNum
            // 
            this.txtAddCellNum.Location = new System.Drawing.Point(263, 124);
            this.txtAddCellNum.Name = "txtAddCellNum";
            this.txtAddCellNum.Size = new System.Drawing.Size(181, 22);
            this.txtAddCellNum.TabIndex = 2;
            // 
            // dtpAddBday
            // 
            this.dtpAddBday.Location = new System.Drawing.Point(154, 255);
            this.dtpAddBday.Name = "dtpAddBday";
            this.dtpAddBday.Size = new System.Drawing.Size(200, 22);
            this.dtpAddBday.TabIndex = 4;
            // 
            // lblAddEmailAddress
            // 
            this.lblAddEmailAddress.AutoSize = true;
            this.lblAddEmailAddress.Location = new System.Drawing.Point(110, 172);
            this.lblAddEmailAddress.Name = "lblAddEmailAddress";
            this.lblAddEmailAddress.Size = new System.Drawing.Size(103, 16);
            this.lblAddEmailAddress.TabIndex = 5;
            this.lblAddEmailAddress.Text = "* Email Address";
            // 
            // lblAddCellNum
            // 
            this.lblAddCellNum.AutoSize = true;
            this.lblAddCellNum.Location = new System.Drawing.Point(110, 124);
            this.lblAddCellNum.Name = "lblAddCellNum";
            this.lblAddCellNum.Size = new System.Drawing.Size(131, 16);
            this.lblAddCellNum.TabIndex = 4;
            this.lblAddCellNum.Text = "* Cell Phone Number";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(263, 32);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(181, 22);
            this.txtAddFirstName.TabIndex = 0;
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(263, 76);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(181, 22);
            this.txtAddLastName.TabIndex = 1;
            // 
            // lblAddFirstName
            // 
            this.lblAddFirstName.AutoSize = true;
            this.lblAddFirstName.Location = new System.Drawing.Point(110, 32);
            this.lblAddFirstName.Name = "lblAddFirstName";
            this.lblAddFirstName.Size = new System.Drawing.Size(80, 16);
            this.lblAddFirstName.TabIndex = 0;
            this.lblAddFirstName.Text = "* First Name";
            // 
            // lblAddLastName
            // 
            this.lblAddLastName.AutoSize = true;
            this.lblAddLastName.Location = new System.Drawing.Point(110, 76);
            this.lblAddLastName.Name = "lblAddLastName";
            this.lblAddLastName.Size = new System.Drawing.Size(80, 16);
            this.lblAddLastName.TabIndex = 1;
            this.lblAddLastName.Text = "* Last Name";
            // 
            // tpTbSearch
            // 
            this.tpTbSearch.Controls.Add(this.lblSearchLastName);
            this.tpTbSearch.Controls.Add(this.lblSearchFirstName);
            this.tpTbSearch.Controls.Add(this.txtSearchFirstName);
            this.tpTbSearch.Controls.Add(this.txtSearchLastName);
            this.tpTbSearch.Controls.Add(this.lblTitleSearchContacts);
            this.tpTbSearch.Controls.Add(this.gbShowContactInfo);
            this.tpTbSearch.Controls.Add(this.btnSearchContact);
            this.tpTbSearch.Location = new System.Drawing.Point(4, 25);
            this.tpTbSearch.Name = "tpTbSearch";
            this.tpTbSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpTbSearch.Size = new System.Drawing.Size(678, 438);
            this.tpTbSearch.TabIndex = 1;
            this.tpTbSearch.Text = "Search Contacts";
            this.tpTbSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(260, 98);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(72, 16);
            this.lblSearchLastName.TabIndex = 14;
            this.lblSearchLastName.Text = "Last Name";
            // 
            // lblSearchFirstName
            // 
            this.lblSearchFirstName.AutoSize = true;
            this.lblSearchFirstName.Location = new System.Drawing.Point(260, 56);
            this.lblSearchFirstName.Name = "lblSearchFirstName";
            this.lblSearchFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblSearchFirstName.TabIndex = 13;
            this.lblSearchFirstName.Text = "First Name";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(360, 56);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchFirstName.TabIndex = 0;
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(360, 98);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchLastName.TabIndex = 1;
            // 
            // lblTitleSearchContacts
            // 
            this.lblTitleSearchContacts.AutoSize = true;
            this.lblTitleSearchContacts.Location = new System.Drawing.Point(296, 19);
            this.lblTitleSearchContacts.Name = "lblTitleSearchContacts";
            this.lblTitleSearchContacts.Size = new System.Drawing.Size(127, 16);
            this.lblTitleSearchContacts.TabIndex = 10;
            this.lblTitleSearchContacts.Text = "Search for a Contact";
            // 
            // gbShowContactInfo
            // 
            this.gbShowContactInfo.Controls.Add(this.lblShowContactInstaHandle);
            this.gbShowContactInfo.Controls.Add(this.lblShowContactEmailAddress);
            this.gbShowContactInfo.Controls.Add(this.lblShowContactCellNum);
            this.gbShowContactInfo.Controls.Add(this.lblShowContactInstaHandleTitle);
            this.gbShowContactInfo.Controls.Add(this.lblShowContactEmailAddressTitle);
            this.gbShowContactInfo.Controls.Add(this.lblShowContactCellNumTitle);
            this.gbShowContactInfo.Location = new System.Drawing.Point(24, 201);
            this.gbShowContactInfo.Name = "gbShowContactInfo";
            this.gbShowContactInfo.Size = new System.Drawing.Size(629, 218);
            this.gbShowContactInfo.TabIndex = 9;
            this.gbShowContactInfo.TabStop = false;
            this.gbShowContactInfo.Text = "Contact Info";
            // 
            // lblShowContactInstaHandle
            // 
            this.lblShowContactInstaHandle.AutoSize = true;
            this.lblShowContactInstaHandle.Location = new System.Drawing.Point(359, 170);
            this.lblShowContactInstaHandle.Name = "lblShowContactInstaHandle";
            this.lblShowContactInstaHandle.Size = new System.Drawing.Size(0, 16);
            this.lblShowContactInstaHandle.TabIndex = 3;
            // 
            // lblShowContactEmailAddress
            // 
            this.lblShowContactEmailAddress.AutoSize = true;
            this.lblShowContactEmailAddress.Location = new System.Drawing.Point(359, 104);
            this.lblShowContactEmailAddress.Name = "lblShowContactEmailAddress";
            this.lblShowContactEmailAddress.Size = new System.Drawing.Size(0, 16);
            this.lblShowContactEmailAddress.TabIndex = 1;
            // 
            // lblShowContactCellNum
            // 
            this.lblShowContactCellNum.AutoSize = true;
            this.lblShowContactCellNum.Location = new System.Drawing.Point(359, 43);
            this.lblShowContactCellNum.Name = "lblShowContactCellNum";
            this.lblShowContactCellNum.Size = new System.Drawing.Size(0, 16);
            this.lblShowContactCellNum.TabIndex = 1;
            // 
            // lblShowContactInstaHandleTitle
            // 
            this.lblShowContactInstaHandleTitle.AutoSize = true;
            this.lblShowContactInstaHandleTitle.Location = new System.Drawing.Point(130, 170);
            this.lblShowContactInstaHandleTitle.Name = "lblShowContactInstaHandleTitle";
            this.lblShowContactInstaHandleTitle.Size = new System.Drawing.Size(113, 16);
            this.lblShowContactInstaHandleTitle.TabIndex = 9;
            this.lblShowContactInstaHandleTitle.Text = "Instagram Handle";
            this.lblShowContactInstaHandleTitle.Visible = false;
            // 
            // lblShowContactEmailAddressTitle
            // 
            this.lblShowContactEmailAddressTitle.AutoSize = true;
            this.lblShowContactEmailAddressTitle.Location = new System.Drawing.Point(130, 104);
            this.lblShowContactEmailAddressTitle.Name = "lblShowContactEmailAddressTitle";
            this.lblShowContactEmailAddressTitle.Size = new System.Drawing.Size(95, 16);
            this.lblShowContactEmailAddressTitle.TabIndex = 5;
            this.lblShowContactEmailAddressTitle.Text = "Email Address";
            this.lblShowContactEmailAddressTitle.Visible = false;
            // 
            // lblShowContactCellNumTitle
            // 
            this.lblShowContactCellNumTitle.AutoSize = true;
            this.lblShowContactCellNumTitle.Location = new System.Drawing.Point(130, 43);
            this.lblShowContactCellNumTitle.Name = "lblShowContactCellNumTitle";
            this.lblShowContactCellNumTitle.Size = new System.Drawing.Size(123, 16);
            this.lblShowContactCellNumTitle.TabIndex = 4;
            this.lblShowContactCellNumTitle.Text = "Cell Phone Number";
            this.lblShowContactCellNumTitle.Visible = false;
            // 
            // btnSearchContact
            // 
            this.btnSearchContact.Location = new System.Drawing.Point(286, 148);
            this.btnSearchContact.Name = "btnSearchContact";
            this.btnSearchContact.Size = new System.Drawing.Size(127, 47);
            this.btnSearchContact.TabIndex = 2;
            this.btnSearchContact.Text = "Search Contact";
            this.btnSearchContact.UseVisualStyleBackColor = true;
            this.btnSearchContact.Click += new System.EventHandler(this.btnSearchContact_Click);
            // 
            // tpTbSearchBdays
            // 
            this.tpTbSearchBdays.Controls.Add(this.dtpSearchBday);
            this.tpTbSearchBdays.Controls.Add(this.lblSearchBdayLastName);
            this.tpTbSearchBdays.Controls.Add(this.lblSearchBdayFirstName);
            this.tpTbSearchBdays.Controls.Add(this.txtSearchBdayFirstName);
            this.tpTbSearchBdays.Controls.Add(this.txtSearchBdayLastName);
            this.tpTbSearchBdays.Controls.Add(this.lblTitleSearchBday);
            this.tpTbSearchBdays.Controls.Add(this.btnSearchBday);
            this.tpTbSearchBdays.Location = new System.Drawing.Point(4, 25);
            this.tpTbSearchBdays.Name = "tpTbSearchBdays";
            this.tpTbSearchBdays.Padding = new System.Windows.Forms.Padding(3);
            this.tpTbSearchBdays.Size = new System.Drawing.Size(678, 438);
            this.tpTbSearchBdays.TabIndex = 2;
            this.tpTbSearchBdays.Text = "Search Birthdays";
            this.tpTbSearchBdays.UseVisualStyleBackColor = true;
            // 
            // dtpSearchBday
            // 
            this.dtpSearchBday.Enabled = false;
            this.dtpSearchBday.Location = new System.Drawing.Point(256, 299);
            this.dtpSearchBday.Name = "dtpSearchBday";
            this.dtpSearchBday.Size = new System.Drawing.Size(200, 22);
            this.dtpSearchBday.TabIndex = 3;
            this.dtpSearchBday.Visible = false;
            // 
            // lblSearchBdayLastName
            // 
            this.lblSearchBdayLastName.AutoSize = true;
            this.lblSearchBdayLastName.Location = new System.Drawing.Point(253, 132);
            this.lblSearchBdayLastName.Name = "lblSearchBdayLastName";
            this.lblSearchBdayLastName.Size = new System.Drawing.Size(72, 16);
            this.lblSearchBdayLastName.TabIndex = 20;
            this.lblSearchBdayLastName.Text = "Last Name";
            // 
            // lblSearchBdayFirstName
            // 
            this.lblSearchBdayFirstName.AutoSize = true;
            this.lblSearchBdayFirstName.Location = new System.Drawing.Point(253, 84);
            this.lblSearchBdayFirstName.Name = "lblSearchBdayFirstName";
            this.lblSearchBdayFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblSearchBdayFirstName.TabIndex = 19;
            this.lblSearchBdayFirstName.Text = "First Name";
            // 
            // txtSearchBdayFirstName
            // 
            this.txtSearchBdayFirstName.Location = new System.Drawing.Point(353, 84);
            this.txtSearchBdayFirstName.Name = "txtSearchBdayFirstName";
            this.txtSearchBdayFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchBdayFirstName.TabIndex = 0;
            // 
            // txtSearchBdayLastName
            // 
            this.txtSearchBdayLastName.Location = new System.Drawing.Point(353, 126);
            this.txtSearchBdayLastName.Name = "txtSearchBdayLastName";
            this.txtSearchBdayLastName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchBdayLastName.TabIndex = 1;
            // 
            // lblTitleSearchBday
            // 
            this.lblTitleSearchBday.AutoSize = true;
            this.lblTitleSearchBday.Location = new System.Drawing.Point(293, 34);
            this.lblTitleSearchBday.Name = "lblTitleSearchBday";
            this.lblTitleSearchBday.Size = new System.Drawing.Size(131, 16);
            this.lblTitleSearchBday.TabIndex = 16;
            this.lblTitleSearchBday.Text = "Search for a Birthday";
            // 
            // btnSearchBday
            // 
            this.btnSearchBday.Location = new System.Drawing.Point(296, 187);
            this.btnSearchBday.Name = "btnSearchBday";
            this.btnSearchBday.Size = new System.Drawing.Size(127, 47);
            this.btnSearchBday.TabIndex = 2;
            this.btnSearchBday.Text = "Search Birthday";
            this.btnSearchBday.UseVisualStyleBackColor = true;
            this.btnSearchBday.Click += new System.EventHandler(this.btnSearchBday_Click);
            // 
            // tpTbShowBdays
            // 
            this.tpTbShowBdays.Controls.Add(this.lblTitleShowTodaysBdays);
            this.tpTbShowBdays.Controls.Add(this.btnShowTodaysBdays);
            this.tpTbShowBdays.Controls.Add(this.lbShowBdays);
            this.tpTbShowBdays.Location = new System.Drawing.Point(4, 25);
            this.tpTbShowBdays.Name = "tpTbShowBdays";
            this.tpTbShowBdays.Padding = new System.Windows.Forms.Padding(3);
            this.tpTbShowBdays.Size = new System.Drawing.Size(678, 438);
            this.tpTbShowBdays.TabIndex = 3;
            this.tpTbShowBdays.Text = "Show Today\'s Birthdays";
            this.tpTbShowBdays.UseVisualStyleBackColor = true;
            // 
            // lblTitleShowTodaysBdays
            // 
            this.lblTitleShowTodaysBdays.AutoSize = true;
            this.lblTitleShowTodaysBdays.Location = new System.Drawing.Point(279, 24);
            this.lblTitleShowTodaysBdays.Name = "lblTitleShowTodaysBdays";
            this.lblTitleShowTodaysBdays.Size = new System.Drawing.Size(152, 16);
            this.lblTitleShowTodaysBdays.TabIndex = 2;
            this.lblTitleShowTodaysBdays.Text = "Show Today\'s Birthdays";
            // 
            // btnShowTodaysBdays
            // 
            this.btnShowTodaysBdays.Location = new System.Drawing.Point(274, 64);
            this.btnShowTodaysBdays.Name = "btnShowTodaysBdays";
            this.btnShowTodaysBdays.Size = new System.Drawing.Size(157, 51);
            this.btnShowTodaysBdays.TabIndex = 0;
            this.btnShowTodaysBdays.Text = "Show Today\'s Birthdays";
            this.btnShowTodaysBdays.UseVisualStyleBackColor = true;
            this.btnShowTodaysBdays.Click += new System.EventHandler(this.showTodaysBdays_Click);
            // 
            // lbShowBdays
            // 
            this.lbShowBdays.FormattingEnabled = true;
            this.lbShowBdays.ItemHeight = 16;
            this.lbShowBdays.Location = new System.Drawing.Point(40, 130);
            this.lbShowBdays.Name = "lbShowBdays";
            this.lbShowBdays.Size = new System.Drawing.Size(610, 292);
            this.lbShowBdays.TabIndex = 0;
            // 
            // tpTbEditDel
            // 
            this.tpTbEditDel.Controls.Add(this.btnCancel);
            this.tpTbEditDel.Controls.Add(this.btnSave);
            this.tpTbEditDel.Controls.Add(this.btnDelete);
            this.tpTbEditDel.Controls.Add(this.btnFindContactEditDel);
            this.tpTbEditDel.Controls.Add(this.btnEdit);
            this.tpTbEditDel.Controls.Add(this.gbDisplayContactInfo);
            this.tpTbEditDel.Controls.Add(this.lblEditDelTitle);
            this.tpTbEditDel.Controls.Add(this.lblEditDelFirstName);
            this.tpTbEditDel.Controls.Add(this.lblEditDelLastName);
            this.tpTbEditDel.Controls.Add(this.txtEditDelLastName);
            this.tpTbEditDel.Controls.Add(this.txtEditDelFirstName);
            this.tpTbEditDel.Location = new System.Drawing.Point(4, 25);
            this.tpTbEditDel.Name = "tpTbEditDel";
            this.tpTbEditDel.Padding = new System.Windows.Forms.Padding(3);
            this.tpTbEditDel.Size = new System.Drawing.Size(678, 438);
            this.tpTbEditDel.TabIndex = 4;
            this.tpTbEditDel.Text = "Edit/Delete";
            this.tpTbEditDel.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(293, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(223, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(495, 389);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFindContactEditDel
            // 
            this.btnFindContactEditDel.Location = new System.Drawing.Point(437, 74);
            this.btnFindContactEditDel.Name = "btnFindContactEditDel";
            this.btnFindContactEditDel.Size = new System.Drawing.Size(106, 33);
            this.btnFindContactEditDel.TabIndex = 2;
            this.btnFindContactEditDel.Text = "Find";
            this.btnFindContactEditDel.UseVisualStyleBackColor = true;
            this.btnFindContactEditDel.Click += new System.EventHandler(this.btnFindContactEditDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(153, 389);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 33);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbDisplayContactInfo
            // 
            this.gbDisplayContactInfo.Controls.Add(this.lblEditDelBday);
            this.gbDisplayContactInfo.Controls.Add(this.txtEditDelInstaHandle);
            this.gbDisplayContactInfo.Controls.Add(this.lblEditDelInstaHandle);
            this.gbDisplayContactInfo.Controls.Add(this.txtEditDelEmailAddress);
            this.gbDisplayContactInfo.Controls.Add(this.txtEditDelCellNum);
            this.gbDisplayContactInfo.Controls.Add(this.dtpEditDelBday);
            this.gbDisplayContactInfo.Controls.Add(this.lblEditDelEmailAddress);
            this.gbDisplayContactInfo.Controls.Add(this.lblEditDelCellNum);
            this.gbDisplayContactInfo.Location = new System.Drawing.Point(153, 139);
            this.gbDisplayContactInfo.Name = "gbDisplayContactInfo";
            this.gbDisplayContactInfo.Size = new System.Drawing.Size(406, 244);
            this.gbDisplayContactInfo.TabIndex = 9;
            this.gbDisplayContactInfo.TabStop = false;
            this.gbDisplayContactInfo.Text = "Edit Info";
            // 
            // lblEditDelBday
            // 
            this.lblEditDelBday.AutoSize = true;
            this.lblEditDelBday.Location = new System.Drawing.Point(171, 123);
            this.lblEditDelBday.Name = "lblEditDelBday";
            this.lblEditDelBday.Size = new System.Drawing.Size(56, 16);
            this.lblEditDelBday.TabIndex = 11;
            this.lblEditDelBday.Text = "Birthday";
            // 
            // txtEditDelInstaHandle
            // 
            this.txtEditDelInstaHandle.Enabled = false;
            this.txtEditDelInstaHandle.Location = new System.Drawing.Point(245, 198);
            this.txtEditDelInstaHandle.Name = "txtEditDelInstaHandle";
            this.txtEditDelInstaHandle.Size = new System.Drawing.Size(100, 22);
            this.txtEditDelInstaHandle.TabIndex = 3;
            // 
            // lblEditDelInstaHandle
            // 
            this.lblEditDelInstaHandle.AutoSize = true;
            this.lblEditDelInstaHandle.Location = new System.Drawing.Point(87, 204);
            this.lblEditDelInstaHandle.Name = "lblEditDelInstaHandle";
            this.lblEditDelInstaHandle.Size = new System.Drawing.Size(113, 16);
            this.lblEditDelInstaHandle.TabIndex = 9;
            this.lblEditDelInstaHandle.Text = "Instagram Handle";
            // 
            // txtEditDelEmailAddress
            // 
            this.txtEditDelEmailAddress.Enabled = false;
            this.txtEditDelEmailAddress.Location = new System.Drawing.Point(245, 65);
            this.txtEditDelEmailAddress.Name = "txtEditDelEmailAddress";
            this.txtEditDelEmailAddress.Size = new System.Drawing.Size(100, 22);
            this.txtEditDelEmailAddress.TabIndex = 1;
            // 
            // txtEditDelCellNum
            // 
            this.txtEditDelCellNum.Enabled = false;
            this.txtEditDelCellNum.Location = new System.Drawing.Point(245, 26);
            this.txtEditDelCellNum.Name = "txtEditDelCellNum";
            this.txtEditDelCellNum.Size = new System.Drawing.Size(100, 22);
            this.txtEditDelCellNum.TabIndex = 0;
            // 
            // dtpEditDelBday
            // 
            this.dtpEditDelBday.Enabled = false;
            this.dtpEditDelBday.Location = new System.Drawing.Point(105, 152);
            this.dtpEditDelBday.Name = "dtpEditDelBday";
            this.dtpEditDelBday.Size = new System.Drawing.Size(200, 22);
            this.dtpEditDelBday.TabIndex = 2;
            // 
            // lblEditDelEmailAddress
            // 
            this.lblEditDelEmailAddress.AutoSize = true;
            this.lblEditDelEmailAddress.Location = new System.Drawing.Point(87, 71);
            this.lblEditDelEmailAddress.Name = "lblEditDelEmailAddress";
            this.lblEditDelEmailAddress.Size = new System.Drawing.Size(95, 16);
            this.lblEditDelEmailAddress.TabIndex = 5;
            this.lblEditDelEmailAddress.Text = "Email Address";
            // 
            // lblEditDelCellNum
            // 
            this.lblEditDelCellNum.AutoSize = true;
            this.lblEditDelCellNum.Location = new System.Drawing.Point(87, 32);
            this.lblEditDelCellNum.Name = "lblEditDelCellNum";
            this.lblEditDelCellNum.Size = new System.Drawing.Size(123, 16);
            this.lblEditDelCellNum.TabIndex = 4;
            this.lblEditDelCellNum.Text = "Cell Phone Number";
            // 
            // lblEditDelTitle
            // 
            this.lblEditDelTitle.AutoSize = true;
            this.lblEditDelTitle.Location = new System.Drawing.Point(269, 26);
            this.lblEditDelTitle.Name = "lblEditDelTitle";
            this.lblEditDelTitle.Size = new System.Drawing.Size(142, 16);
            this.lblEditDelTitle.TabIndex = 0;
            this.lblEditDelTitle.Text = "Edit/Delete Information";
            // 
            // lblEditDelFirstName
            // 
            this.lblEditDelFirstName.AutoSize = true;
            this.lblEditDelFirstName.Location = new System.Drawing.Point(168, 59);
            this.lblEditDelFirstName.Name = "lblEditDelFirstName";
            this.lblEditDelFirstName.Size = new System.Drawing.Size(80, 16);
            this.lblEditDelFirstName.TabIndex = 0;
            this.lblEditDelFirstName.Text = "* First Name";
            // 
            // lblEditDelLastName
            // 
            this.lblEditDelLastName.AutoSize = true;
            this.lblEditDelLastName.Location = new System.Drawing.Point(168, 103);
            this.lblEditDelLastName.Name = "lblEditDelLastName";
            this.lblEditDelLastName.Size = new System.Drawing.Size(80, 16);
            this.lblEditDelLastName.TabIndex = 1;
            this.lblEditDelLastName.Text = "* Last Name";
            // 
            // txtEditDelLastName
            // 
            this.txtEditDelLastName.Location = new System.Drawing.Point(292, 103);
            this.txtEditDelLastName.Name = "txtEditDelLastName";
            this.txtEditDelLastName.Size = new System.Drawing.Size(100, 22);
            this.txtEditDelLastName.TabIndex = 1;
            // 
            // txtEditDelFirstName
            // 
            this.txtEditDelFirstName.Location = new System.Drawing.Point(292, 59);
            this.txtEditDelFirstName.Name = "txtEditDelFirstName";
            this.txtEditDelFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtEditDelFirstName.TabIndex = 0;
            // 
            // msFileTab
            // 
            this.msFileTab.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFileTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msPersonalization});
            this.msFileTab.Location = new System.Drawing.Point(0, 0);
            this.msFileTab.Name = "msFileTab";
            this.msFileTab.Size = new System.Drawing.Size(710, 28);
            this.msFileTab.TabIndex = 2;
            this.msFileTab.Text = "menuStrip2";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msSaveToFile,
            this.msOpenText,
            this.msSaveBinary,
            this.msOpenBinary});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(46, 24);
            this.msFile.Text = "File";
            // 
            // msSaveToFile
            // 
            this.msSaveToFile.Name = "msSaveToFile";
            this.msSaveToFile.Size = new System.Drawing.Size(173, 26);
            this.msSaveToFile.Text = "Save Text";
            this.msSaveToFile.Click += new System.EventHandler(this.msSaveToFile_Click);
            // 
            // msOpenText
            // 
            this.msOpenText.Name = "msOpenText";
            this.msOpenText.Size = new System.Drawing.Size(173, 26);
            this.msOpenText.Text = "Open Text";
            this.msOpenText.Click += new System.EventHandler(this.msOpenText_Click);
            // 
            // msSaveBinary
            // 
            this.msSaveBinary.Name = "msSaveBinary";
            this.msSaveBinary.Size = new System.Drawing.Size(173, 26);
            this.msSaveBinary.Text = "Save Binary";
            this.msSaveBinary.Click += new System.EventHandler(this.msSaveBinary_Click);
            // 
            // msOpenBinary
            // 
            this.msOpenBinary.Name = "msOpenBinary";
            this.msOpenBinary.Size = new System.Drawing.Size(173, 26);
            this.msOpenBinary.Text = "Open Binary";
            this.msOpenBinary.Click += new System.EventHandler(this.msOpenBinary_Click);
            // 
            // msPersonalization
            // 
            this.msPersonalization.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPersonalizationColor});
            this.msPersonalization.Name = "msPersonalization";
            this.msPersonalization.Size = new System.Drawing.Size(123, 24);
            this.msPersonalization.Text = "Personalization";
            // 
            // msPersonalizationColor
            // 
            this.msPersonalizationColor.Name = "msPersonalizationColor";
            this.msPersonalizationColor.Size = new System.Drawing.Size(232, 26);
            this.msPersonalizationColor.Text = "Color Personalization";
            this.msPersonalizationColor.Click += new System.EventHandler(this.msPersonalizationColor_Click);
            // 
            // frmPersonalAddressBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 491);
            this.Controls.Add(this.tcAddressBook);
            this.Controls.Add(this.msFileTab);
            this.MainMenuStrip = this.msFileTab;
            this.Name = "frmPersonalAddressBook";
            this.Text = "Personal Address Book";
            this.tcAddressBook.ResumeLayout(false);
            this.tpTbAddContact.ResumeLayout(false);
            this.gbContactInfo.ResumeLayout(false);
            this.gbContactInfo.PerformLayout();
            this.tpTbSearch.ResumeLayout(false);
            this.tpTbSearch.PerformLayout();
            this.gbShowContactInfo.ResumeLayout(false);
            this.gbShowContactInfo.PerformLayout();
            this.tpTbSearchBdays.ResumeLayout(false);
            this.tpTbSearchBdays.PerformLayout();
            this.tpTbShowBdays.ResumeLayout(false);
            this.tpTbShowBdays.PerformLayout();
            this.tpTbEditDel.ResumeLayout(false);
            this.tpTbEditDel.PerformLayout();
            this.gbDisplayContactInfo.ResumeLayout(false);
            this.gbDisplayContactInfo.PerformLayout();
            this.msFileTab.ResumeLayout(false);
            this.msFileTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcAddressBook;
        private System.Windows.Forms.TabPage tpTbAddContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.GroupBox gbContactInfo;
        private System.Windows.Forms.Label lblAddBday;
        private System.Windows.Forms.TextBox txtAddInstaHandle;
        private System.Windows.Forms.Label lblAddInstaHandle;
        private System.Windows.Forms.TextBox txtAddEmailAddress;
        private System.Windows.Forms.TextBox txtAddCellNum;
        private System.Windows.Forms.DateTimePicker dtpAddBday;
        private System.Windows.Forms.Label lblAddEmailAddress;
        private System.Windows.Forms.Label lblAddCellNum;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.Label lblAddFirstName;
        private System.Windows.Forms.Label lblAddLastName;
        private System.Windows.Forms.TabPage tpTbSearch;
        private System.Windows.Forms.Label lblTitleSearchContacts;
        private System.Windows.Forms.GroupBox gbShowContactInfo;
        private System.Windows.Forms.Label lblShowContactInstaHandleTitle;
        private System.Windows.Forms.Label lblShowContactEmailAddressTitle;
        private System.Windows.Forms.Label lblShowContactCellNumTitle;
        private System.Windows.Forms.Button btnSearchContact;
        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.Label lblSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.TabPage tpTbSearchBdays;
        private System.Windows.Forms.Label lblSearchBdayLastName;
        private System.Windows.Forms.Label lblSearchBdayFirstName;
        private System.Windows.Forms.TextBox txtSearchBdayFirstName;
        private System.Windows.Forms.TextBox txtSearchBdayLastName;
        private System.Windows.Forms.Label lblTitleSearchBday;
        private System.Windows.Forms.Button btnSearchBday;
        private System.Windows.Forms.TabPage tpTbShowBdays;
        private System.Windows.Forms.Label lblTitleShowTodaysBdays;
        private System.Windows.Forms.Button btnShowTodaysBdays;
        private System.Windows.Forms.ListBox lbShowBdays;
        private System.Windows.Forms.TabPage tpTbEditDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox gbDisplayContactInfo;
        private System.Windows.Forms.Label lblEditDelBday;
        private System.Windows.Forms.TextBox txtEditDelInstaHandle;
        private System.Windows.Forms.Label lblEditDelInstaHandle;
        private System.Windows.Forms.TextBox txtEditDelEmailAddress;
        private System.Windows.Forms.TextBox txtEditDelCellNum;
        private System.Windows.Forms.DateTimePicker dtpEditDelBday;
        private System.Windows.Forms.Label lblEditDelEmailAddress;
        private System.Windows.Forms.Label lblEditDelCellNum;
        private System.Windows.Forms.Label lblEditDelTitle;
        private System.Windows.Forms.Label lblEditDelFirstName;
        private System.Windows.Forms.Label lblEditDelLastName;
        private System.Windows.Forms.TextBox txtEditDelLastName;
        private System.Windows.Forms.TextBox txtEditDelFirstName;
        private System.Windows.Forms.Button btnFindContactEditDel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpSearchBday;
        private System.Windows.Forms.Label lblShowContactInstaHandle;
        private System.Windows.Forms.Label lblShowContactEmailAddress;
        private System.Windows.Forms.Label lblShowContactCellNum;
        private System.Windows.Forms.MenuStrip msFileTab;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msSaveToFile;
        private System.Windows.Forms.ToolStripMenuItem msOpenText;
        private System.Windows.Forms.ToolStripMenuItem msSaveBinary;
        private System.Windows.Forms.ToolStripMenuItem msOpenBinary;
        private System.Windows.Forms.ToolStripMenuItem msPersonalization;
        private System.Windows.Forms.ToolStripMenuItem msPersonalizationColor;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

